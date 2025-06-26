# 3D-Motion-Capture
About  :
        In this project we will use a video to mark landmarks on our performer , whose actions and movements we wish to copy and integrate in our character flawlessly.
        In this project we used pycharm for python coding which created the landmarks , then used thosed landmarks to mark anchor points of our character's nodes              based on the x,y,z-axis of the perfomer,
        then unity hub is used to create solid for the character and animation is integrated using C sharp scripting, below are the steps to complete this project , 
        note that all these steps are in respect to the mediia given in repo  it step 2 may vary based on the media given.:
        video.mp4:https://github.com/harshbharti18/3D-Motion-Capture/blob/e1ad489de91878060e52f56bd180a6c5a31f5971/Video.mp4 , if you cannot see the video click on            view raw it will download the video for you and you view it then .

Step 1:
        Choose any video or choose given media (video.mp4) or import the video of performer , whose actions are wished to be copied.
        Copy the main.py , import the necessary libraries and run in it  any platform eg. visual studio ( I used pycharm) to mark the landmarks on the performer.
        Screenshot for the same : https://github.com/harshbharti18/3D-Motion-Capture/blob/9ae167b876789cebc80e061bb01b5486dd2ce3e0/Screenshot%20(27).png 
Step 2:
        Once the landmarks are created , check the string for maximum value in case of video.mp4 the max value was about 340-350 therefore values more than 300 were           best suited for my media after this we need to create a postion list to according to which the solids will move and animate .
        To create the list we will run our main.py and as soon as our landmark strings will hit 300 we will hit "s" and stop the program , with this a new text file 
        will be created , in which the position of each landmark will be given based on 3rd dimension axises (note: we will save text file after string hits 300               because we need maximum information for our model to learn and train from it)
Step 3:
        We only need the text file generated with this python program for our project , open unity hub now choose 3d core , i used editor version : 2022.3.60f1 LTS
        but you also used 6000.0.43f1 LTS it should still work fine , below is the screenshot of the starting page to give more clarity:
        Unity welcome page : https://github.com/harshbharti18/3D-Motion-Capture/blob/713fcf15b74bc85ab02a1bae65522d88ea86c3dc/Screenshot%20(32).png
        In case you face license issue in unity apply for the student offer on unity website and you can have unity hub for free.
Step 4:
        Then create a new project and open the project , 
        
