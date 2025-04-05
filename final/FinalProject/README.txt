The technical gimmick I wanted to try is creating
a narration system that feels like it's different
every time. I decided that to do this the narrator 
would need to have multiple possible responses for
the same scenario, creating an organic feel to the 
game.

The inspiration for the story just sort of came
randomly as I was trying to think of a motivation 
for the narrator. I tried to tackle the idea of
loss. It's something that I've been trying to 
grapple with since coming home from my mission.
The Narrator loses someone he loves very dearly
and decides to lock his memories and feelings away.
I figured that despite having his memories locked
up, he still will have those feelings deep down
and if you choose to break some of the items you
come across the narrator will become more upset by
this.

It's a surreal idea but I hope you find some
enjoyment out of it.



Class Structure:

Program.cs

MainMenu.cs

Area.cs                     //Parent Class
    RiverArea.cs
    GrassArea.cs
    CaveArea.cs

Narrator.cs                 //Polymorphic Parent Class
    NeutralNarrator.cs
    DepressedNarrator.cs
    AngryNarrator.cs