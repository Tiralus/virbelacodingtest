# Exercise 1 #

In this exercise you'll configure a Unity scene and write scripts to create an interactive experience. As you progress through the steps, feel free to add comments to the code about *why* you choose to do things a certain way. Add comments if you felt like there's a better, but more time intensive way to implement specific functionality. It's OK to be more verbose in your comments than typical, to give us a better idea of your thoughts when writing the code.

### What you need ###

* Unity 2020 (latest, or whatever you have already)
* IDE of your choice
* Git

## Instructions ##

### Phase 1 ###

**Project setup**:

 1. Clone this repository to your local machine
 1. Create a new Unity project inside this directory, put "VirBELA" and your name in the project name.
 1. Configure the scene:
     1. Add a central object, named "Player"
     1. Add 5 objects randomly distributed around the central object with name "Thing"
 1. Add two C# scripts to you project, the scripts are named "Player" and "Thing"
     1. Attach the scripts to the objects in the scene according to their name, Thing script goes on Thing objects, Player script goes on Player object.
     1. You may use these scripts or ignore them when pursuing the Functional Goals, the choice is yours. You're free to add any additional scripts you require to meet the functional goals.

**Functional Goal 1**:

When the game is running, make the Thing closest to Player turn red. One and only one Thing is red at a time. Ensure that when Player is moved around in the scene manually (by dragging the object in the scene view), the closest Thing is always red.

### Phase 2 ###

**Project modification**:

 1. Add 5 objects randomly distributed around the central object with the name "Bot"
 1. Add a C# script called "Bot" to your project.
 1. Attach the "Bot" script to the 5 new objects.
 1. Again, you may use this script or ignore it when pursing the Functional Goals.

**Functional Goal 2**:

When the game is running, make the Bot closest to the Player turn blue. One and only one object (Thing or Bot) has its color changed at a time. Ensure that when Player is moved around in the scene manually (by dragging the object in the scene view), the closest Thing is red or the closest Bot is blue.

### Phase 3 ###

**Functional Goal 3**:

Ensure the scripts can handle any number of Things and Bots.

**Functional Goal 4**:

Allow the designer to choose the color for Things/Bots at edit time.

## Questions ##

 1. How can your implementation be optimized?
    There are several critical code areas that can be optimized:
    1. Managing the list of bots/things
        1a. The list contains all of the things/bots gameobjects. Whenever something spawns it's added to the list. Extra logic could be added so that the list prunes gameobjects outside of an area around the player.
        1b. Add support for removing objects, this would be managed by the spawner and another action would be added to properly remove objects from the list. 
    2. Spawning gameobjects
        2a. If the requirements called for scaling up spawning, an object pool could be used. It could instantiate some number of objects and disable them on start.
    3. Optimize finding the nearest
        3a. I used Vector3.Distance, there is discussion around how optimized Distance is versus squaremagnitude. I preferred readability in this case. If it was going to scale up then I would opt for using a KD tree to segment the space so that the list only contains gameobjets in an area. Another option is to limit when the nearest is calculated so it isn't on every frame.

 1. How much time did you spend on your implementation?
    I committd my project through each phase. For the 1st 3 phases, I would say 45 minutes to an hour to have everything functional and working. I took some extra time for some quality-of-life elements and reorganizing some structures. So in total, about 4 hours.  

 1. What was most challenging for you?
    Architecting the code, keeping things modular, and laying out responsibilities within the code. It's very easy to just dump everything into the Player script. Defining code responsibilities can be challenging since it can mean refactoring and breaking apart code that is already functional. One other challenge is managing scope, writing code to the requirements exactly or trying to anticipate future requirements or features. Also naming things.



## Optional ##

* Add Unit Tests
* Add XML docs
* Optimize finding nearest
* Add new Things/Bots automatically on key press

## Next Steps ##

* Confirm you've addressed the functional goals
* Answer the questions above by adding them to this file
* Push your project to public source control
* Share your project URL with your VirBELA contact (Recruiter or Hiring Manager)

## If you have questions ##

* Reach out to your VirBELA contact (Recruiter or Hiring Manager)
