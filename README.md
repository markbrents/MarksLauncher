# Marks Launcher
Mark's Launcher is a program launcher for Windows that sits above your taskbar and allows you to organize your application shortcuts into groups, making it easier to find and run your programs:

![Mark's Launcher Screenshot](MarksLauncherScreenshot.png "Mark's Launcher Screenshot")

## How it works 
Mark's Launcher is a Windows Forms program written in C# (targets .NET 6.0). It uses [AppBarHelper](https://github.com/tip2tail/t2tWinFormAppBarLib) to turn a form into an App Bar that sits at the bottom of the screen. 

It reads the list of groups and links from a SQLite database (MarksLauncer.db) that gets installed into the user's AppData/Local/MarksLauncher folder. 

This data is used to create the group buttons you see along the bottom of your screen. Clicking on a group reveals the links in that group. 

## Known Issues
+ When you exit the program, it doesn't free up the space at the bottom of the screen. 
+ The name. I couldn't really come up with a good one. I'm open to suggestions for a better one. 
