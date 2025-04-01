using System;
using System.Collections.Generic;

public class NeutralNarrator : Narrator
{
    public NeutralNarrator()
    {
        // Initialize dialogue responses

        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {
            "The water rushes by as you ponder, how will I catch a fish?",
            "You watch the water flow, but without a fishing pole, you're left with only your thoughts.",
            "The river moves steadily, indifferent to your dilemma. Perhaps you need the right tool for the job."
        };

        _dialogue["fishing_pole"] = new List<string>
        {
            "The wind in your hair, the mist across your body, and the smile on your face. You plunge the fishing rod down into the depths and wait patiently. Suddenly a tug at the twig and out of the water it launches!",
            "With patience, you cast your line into the current. A moment passes, then—success! A fish leaps from the water, caught in your grasp.",
            "The river is alive with motion, and for a moment, so are you. A tug on the line, a swift pull, and a fish breaks the surface."
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            "The boat is tranquil despite the rushing water off in the distance. You notice next to you a little shovel. This may be useful.",
            "You step into the boat, feeling it rock gently beneath you. A small shovel lies nearby, seemingly waiting for a purpose.",
            "The quiet of the river surrounds you. A lone shovel rests beside you, its presence strangely inviting."
        };

        _dialogue["boat_shovel"] = new List<string>
        {
            "Just you, a shovel, and a boat. What could be better than this?",
            "You sit in the boat, shovel in hand. It's a peaceful moment, though you can't shake the feeling that there's something more to do.",
            "A boat and a shovel—unlikely companions, yet here they are, waiting with you on the water."
        };

        _dialogue["mound_norock"] = new List<string>
        {
            "You unearth a small frame with a picture that seems like it was taken a long time ago. It's of a man and a woman. They seem happy together.",
            "Beneath the dirt, you find a framed photograph. The image is faded, but the expressions remain—content, hopeful.",
            "The ground gives way to a small picture frame. The faces within belong to a time long past, yet they still linger here."
        };

        _dialogue["mound_rock"] = new List<string>
        {
            "You unearth a small picture. The item itself is worthless, but the memories are priceless.",
            "The dirt shifts away, revealing a tiny photograph. The past lingers in its edges, even if the meaning is lost.",
            "A picture buried beneath the earth, waiting to be found. Its story is unknown, but its presence is undeniable."
        };

        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
            "The inside of the treehouse reminds you of a younger time. In the corner is a little box with no openings or locks. It does, however, look breakable.",
            "Dust lingers in the air, caught in the fading light. The strange box sits in the corner, silent, waiting.",
            "The treehouse stands frozen in time, untouched yet worn. The small, unopenable box remains where it always has."
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            "You investigate the treehouse and find little interesting about it. You find the box that seemed unopenable not too long ago. You take your rock and strike the box with everything you have!",
            "With the rock in hand, the box no longer seems so mysterious. A single strike—splintering wood, a quiet resolve.",
            "The box meets the rock, and for a moment, nothing happens. Then—crack. The mystery begins to unfold."
        };

        _dialogue["locket_norock"] = new List<string>
        {
            "There is something unnerving about this little trinket. On the one hand, it's just a simple picture of a woman, nothing of note. However, someone went through the trouble of printing this so small, and then to put that picture in a frame that is now wearable. She must have meant a lot to him.",
            "A small locket rests in your hand, its clasp worn from use. Inside, the image of a woman, carefully preserved.",
            "You hold the locket up to the light. A woman's face looks back at you, frozen in time, her significance a quiet mystery."
        };

        _dialogue["locket_rock"] = new List<string>
        {
            "The locket has puzzled you long enough. You have the power to destroy it if you like.",
            "The weight of the locket is small, yet something about it feels heavy. You could rid yourself of that weight with a single motion.",
            "You run your fingers over the locket's surface. To keep or to break—such a simple decision, yet it lingers."
        };

        _dialogue["hill_noshovel"] = new List<string>
        {
            "A tranquil hill far away from civilization. On paper, it sounds like a dream, but now that you're here, you can't help but feel like you're missing something.",
            "The breeze carries a quiet stillness over the hilltop. There's peace here, but also an absence.",
            "The view stretches far and wide, yet something feels incomplete. Perhaps there's more beneath the surface."
        };

        _dialogue["hill_shovel"] = new List<string>
        {
            "What's better than a hill? A hole, of course. You begin digging and find a real treasure—a fishing pole! Who went through all the trouble of putting this down here?",
            "The ground gives way beneath your shovel. After a few moments, your effort is rewarded—someone buried a fishing pole here.",
            "You dig, expecting nothing, yet uncover something—a fishing pole. Forgotten or hidden? The answer remains unknown."
        };

        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {
            "The cavern seems to slowly drip down into the endless abyss.",
            "A quiet emptiness stretches downward, the depths holding their secrets close.",
            "The abyss stares back at you, vast and silent, offering no answers."
        };

        _dialogue["pit_pole_norock"] = new List<string>
        {
            "You toss your fishing pole into the bottomless pit and manage to find a music box. It sings its precious lullaby. Who would throw something so precious away?",
            "The fishing line catches onto something. As you reel it in, a soft melody fills the air—a music box, lost but not forgotten.",
            "Your pole finds purchase in the void. Slowly, you pull up an object—a music box, its song delicate yet enduring."
        };

        _dialogue["pit_pole_rock"] = new List<string>
        {
            "You toss your fishing pole into the bottomless pit and manage to find a music box. It sings its precious lullaby. It seems unwanted. You have the power to take it out of its misery.",
            "The melody drifts through the cavern, soft yet heavy. You hold the music box in your hands. A single action could silence it forever.",
            "The song lingers, its notes echoing off the stone. The music box rests in your grasp, waiting for a choice."
        };

        _dialogue["rock_noshovel"] = new List<string>
        {
            "Man, having a rock like this would be so cool.",
            "A solid, sturdy rock sits before you. Quite the find.",
            "It's just a rock, yet something about it feels... right."
        };

        _dialogue["rock_shovel"] = new List<string>
        {
            "You shovel the rock with all your might. A mighty rock for a mighty lad.",
            "With effort, you pry the rock loose. It's heavier than expected, but yours now.",
            "The shovel gives you just enough leverage to claim your prize—a simple rock, yet undeniably yours."
        };

        _dialogue["memo_noshovel"] = new List<string>
        {
            "A weathered stone stands before you, its surface etched with names long forgotten. Time has not been kind to it.",
            "The memorial is old, its carvings worn by the years. Someone must have cared once, but now it stands alone.",
            "You run your fingers across the rough surface. The words are faded, but their weight still lingers."
        };

        _dialogue["memo_shovel"] = new List<string>
        {
            "You dig at the base of the memorial, unearthing something hidden beneath the years. A key, buried in silence.",
            "Beneath the dirt, something glints in the dim light. A small key, as if left behind for someone to find.",
            "The shovel scrapes against something solid. As you lift it from the earth, you realize—this was meant to be uncovered."
        };


        _dialogue["key_found"] = new List<string>
        {
            "Well done, you found the key.",
            "The little bronze key is now within your grasp.",
            "Good job, the key is yours."
        };

        // Hints
        _dialogue["box_hint"] = new List<string>
        {
            "The box remains locked. You'll need keys. That much should be obvious.",
            "If I were you, I'd start pushing buttons."
        };

        _dialogue["grass_hint"] = new List<string>
        {
            "My guess is something important is over in that tree house.",
            "That locket doesn't seem important.",
            "There doesn't seem to be anything over at the hill but you may not have the right tool yet."
        };

        _dialogue["river_hint"] = new List<string>
        {
            "It would be nice to go fishing here. You should look into that.",
            "That boat is really cute, it may be nice to sit in it.",
            "That mound of dirt seems pretty useless."
        };

        _dialogue["cave_hint"] = new List<string>
        {
            "Holes don't seem to be worth our time.",
            "The Memorial probably contains the biggest secret.",
            "A rock may be useful in some cases."
        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "The grass stretches endlessly. If you stare too long, you might get lost in its beauty.",
            "Green, swaying, utterly remarkable. The wind feels like the nearly forgotten touch of a loved one."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "The River flows like a raging storm off in the distance, but at the shore it still seems so peaceful.",
            "The shore of the river greets you like an old friend. The beautiful sound of the water rushing by fills your soul."
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Dark, damp, and full of regret. This Cave seems to shedding a tear for something...",
            "Echoes bounce off the cave walls. It's like they're speaking to me."
        };

        _dialogue["repeat"] = new List<string>
        {
            "Ah, back again? Guess you just can't get enough of this place.",
            "Familiar sights, familiar actions. A classic choice.",
            "Déjà vu? No, just a well-trodden path.",
            "Revisiting past decisions... or just stalling for time?",
            "You know, there are other things to explore, but hey, do what makes you happy.",
            "Some say repetition is the key to mastery. Others say it's just habit. Either way, here we are."
        };


    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(250); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}
