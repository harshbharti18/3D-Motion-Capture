using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnimationCode : MonoBehaviour
{
    public GameObject[] Body;
    List<string> lines;
    int counter = 0;
    bool isPlaying = true;

    void Start()
    {
        lines = System.IO.File.ReadLines("Assets/AnimationFile.txt").ToList();
        StartCoroutine(PlayAnimation());
    }

    void Update()
    {
        // Toggle animation with Escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPlaying = !isPlaying;
        }
    }

    IEnumerator PlayAnimation()
    {
        int expectedValues = Body.Length * 3;

        while (true)
        {
            if (isPlaying)
            {
                if (counter >= lines.Count)
                {
                    counter = 0;
                }

                string[] points = lines[counter].Split(',')
                                                .Where(s => !string.IsNullOrWhiteSpace(s))
                                                .ToArray();

                if (points.Length < expectedValues)
                {
                    Debug.LogError($"Line {counter}: only {points.Length} values, expected {expectedValues}.");
                }

                int joints = Mathf.Min(Body.Length, points.Length / 3);

                for (int i = 0; i < joints; i++)
                {
                    float x = float.Parse(points[i * 3 + 0]) / 100f;
                    float y = float.Parse(points[i * 3 + 1]) / 100f;
                    float z = float.Parse(points[i * 3 + 2]) / 300f;
                    Body[i].transform.localPosition = new Vector3(x, y, z);
                }

                counter++;
            }

            yield return new WaitForSeconds(0.03f); // ~30 milliseconds
        }
    }
}
