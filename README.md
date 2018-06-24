# SkypeCall

A .NET Library from 2013

In `original` branch you will find the original source code for this application. In `master` an upgraded, refactored version.

## Description

In 2013 I bought a webcam for my media center. I started to investigate different basic video surveillance software, free and licensed. In a weekend I implemented this project which basically consists in a basic ASP NET MVC application a Winform desktop application and SignalR for the realtime communication hosted in Azure.

The web application (running in Azure) consists on different links to call known Skype users. When you click on the link it sends a realtime message that is handled from a Winform application (running in the media center) and triggers a Skype call to the user in the link. 

Then from the user perspective you click on a web application link and seconds later you get a video skype call from your home and you can basically see what the camera (in my media center in my case) shows.

This application never left it is POC status, but it works :)

## Screenshot

![screenshot](https://raw.githubusercontent.com/mamcer/skype-call/master/doc/screenshot.png)

## Technologies

- Visual Studio 2013
- .NET Framework 4.5
- SignalR 1.0.1