# Seamless-Level-Loading-Test
https://gorgigames.itch.io/sll-test

I didn't have time to add comments so I'm going to add notable detail here. It may be difficult to figure out my scripts because of the weird coding style used, so just read this information I guess.

This is a loading test for the game engine Unity (2017.3.1f1).

How loading works in Unity (learned from testing and experience):


In Unity3D, when you call the function to load another level in the Update function, the current frame has to be done before it actually freezes the game to load. The idea is to call the load function, return from the Update function (which finishes the current frame), and then the next time Update executes, the level has finished loading already. (Also the object with such script is DontDestroyOnLoad() so it isn't removed after the load, as usual)

Please note that calling the level load function does NOT block code execution in the update function!! This was my first mistake while trying to code this. The code execution technically blocks after Update has finished running.



(I don't know if the Asset files fully work or not, but the contained scripts should)
This code is free to use however you want, but you'll probably want to code a better version based off of this one. (i'm kinda bad at coding sometimes)
