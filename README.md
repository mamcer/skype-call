# SkypeCall

A .NET Web Application from 2013

In `original` branch you will find the original source code for this application. In `master` an upgraded, refactored version.

> More details about why I published this project in [this blog post](https://mamcer.github.io/2018-09-02-i-cleaned-up-my-virtual-basement/)

## Description

In 2013 I bought a webcam for my media center. I started to investigate different basic video surveillance software, free and licensed. In a weekend I implemented this project which basically consists in a basic ASP NET MVC application a Winform desktop application and SignalR for the realtime communication hosted in Azure.

The web application (running in Azure) consists on different links to call known Skype users. When you click on the link it sends a realtime message that is handled from a Winform application (running in the media center) and triggers a Skype call to the user in the link. 

From the user's perspective, he simply clicked on a link in a web application and seconds later he received a Skype video call from his own home.

This application never left the POC status, but it worked :)

## Screenshot

![screenshot](https://raw.githubusercontent.com/mamcer/skype-call/master/doc/screenshot-02.png)

![screenshot](https://raw.githubusercontent.com/mamcer/skype-call/master/doc/screenshot-01.png)

## Technologies

- Visual Studio 2013
- .NET Framework 4.5
- SignalR 1.0.1
