---
layout: post
title:  "SDDD"
date:   2015-11-30 14:34:25
categories: ddd
tags: ddd
image: /assets/article_images/2014-11-30-mediator_features/night-track.JPG
---
#SDDD-Intro
##Motivation
##Cronus Sample
##Praxis Domain

#SDDD-Scrum
##How we wrote the stories, Exploring the domain
##Creating the project structure
When deciding where to place the source files, we took into account that different bounded contexts(see the post about the Praxis domain) should live into separate repositories. But after we gave it some tought, we decided that this will be a bottleneck while deveoloping, or at least in the begining when major refactorings are more ofthen, resuling in multiple nuget publishes, multiple local deployments etc. Thats why we decided to have a folder per bounded context, thus emulating different repositories and enabling us to easly separate them in different source controls. From there on the setup is pretty standart: 
```
|-root
    |-Clubs
        |-src
    |-IdentityManagement
        |-src 
    |-IdentityAndAccess
        |-src
```
##GitHub Flow - how it works, how we use it

#SDDD-HackIt



