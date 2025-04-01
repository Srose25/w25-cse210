using System;
using System.Collections.Generic;

public class DepressedNarrator : Narrator
{
    public DepressedNarrator()
    {
        //Initlialize dialogue responses
        _dialogue["_interaction"] = new List<string>
        {

        };

        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {
            "The river flows on, careless and eternal. You stand at its edge, empty-handed, wondering if you belong here at all.",
            "The water rushes forward, always moving, never waiting. You, however, remain still.",
            "A reflection stares back at you from the river's surface. It wavers, unformed, incomplete—much like your efforts here."
        };

        _dialogue["fishing_pole"] = new List<string>
        {
           "The fishing line vanishes into the depths, swallowed whole. For a moment, something pulls back. A brief resistance, a fleeting connection.",
           "The wind whispers across the water. The pole bends, the line tenses, and then—a catch. You've taken something from the river, but was it ever really yours?",
           "The ripples spread outward as you reel in your prize. The river does not mourn what it has lost."
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            "The boat drifts in quiet defiance, untouched by the raging currents beyond. The shovel beside you lies still, purposeless.",
            "This place is frozen in time, a sanctuary or a prison—you can't tell. The shovel at your feet seems to wait for something.",
            "The river sings a song of movement, but here, everything is still. The shovel, the boat, even you."
        };

        _dialogue["boat_shovel"] = new List<string>
        {
            "A boat, a shovel, and silence. If there is meaning here, it eludes you.",
            "The current pulls at the boat, but you do not move. You sit, waiting, though you're not sure what for.",
            "The shovel rests in your grip, but all it offers is a vague sense of purpose, like a memory too faded to grasp."
        };

        _dialogue["mound_norock"] = new List<string>
        {
            "You unearth a photograph—two faces frozen in a moment of joy, long since buried. Happiness preserved in paper and ink, yet lifeless in your hands.",
            "The dirt falls away, revealing a picture of strangers. Or perhaps, people you once knew.",
            "A forgotten relic from a forgotten time. Their smiles linger, but time has stolen whatever warmth once lived here."
        };

        _dialogue["mound_rock"] = new List<string>
        {
            "The photograph is small, insignificant. And yet, holding it feels like holding a ghost.",
            "Beneath the dirt, a piece of history gasps for air. It does not recognize you.",
            "Time has claimed nearly everything, yet this picture remains. A monument to something long lost."
        };

        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
           "Dust clings to forgotten wood, the scent of old memories thick in the air. A box sits in the corner—sealed, waiting.",
           "The treehouse stands alone, a monument to what once was. The strange little box watches you from the shadows.",
           "There is a stillness here, like a dream left unfinished. A locked box, an unanswered question."
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            "The rock meets wood with force. Splinters fly, and with them, something intangible is released.",
            "A crack, a break, a shattering of secrets. But does breaking something truly reveal its meaning?",
            "The box opens, but the answer you expected does not come. Some things remain lost, even in discovery."
        };

        _dialogue["locket_norock"] = new List<string>
        {
            "The locket sits in your palm, its delicate clasp resisting your touch. The woman inside stares forward, waiting for someone who will never return.",
            "A small, fragile thing. A memory condensed into metal and glass. Someone treasured this once—does anyone still?",
            "You hold a life between your fingers, preserved but forgotten. What is remembrance, if not the act of carrying another's sorrow?"
        };

        _dialogue["locket_rock"] = new List<string>
        {
            "You could break it. End the weight of its story. But even shattered things still whisper their histories.",
            "Destruction is an easy choice, but it does not erase what once was.",
            "A simple motion, a moment of force, and it would be gone. Yet, would its absence truly change anything?"
        };

        _dialogue["hill_noshovel"] = new List<string>
        {
           "The hill stretches endlessly, yet it feels smaller than it should. Like something is missing, something buried beneath the grass.",
           "The wind whispers across the earth, but it does not answer your questions. The emptiness lingers.",
           "There is peace here, but it is the peace of an abandoned place. Something was left behind."
        };

        _dialogue["hill_shovel"] = new List<string>
        {
           "The soil parts, reluctant but yielding. Beneath it, something forgotten—something waiting.",
           "Digging feels strangely familiar, like an old habit. Your hands move without thought, until finally, a prize emerges.",
           "You uncover the fishing pole, but the real discovery is the unease that follows."
        };

        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {
            "The abyss breathes, though it has nothing to say. It simply waits.",
            "The darkness below stretches endlessly, swallowing all light, all sound, all meaning.",
            "There is nothing here, and yet, the emptiness feels heavy."
        };

        _dialogue["pit_pole_norock"] = new List<string>
        {
            "The line vanishes into the void. Then, resistance. Something is down there, something left behind. A music box...",
            "A music box emerges, its song thin, wavering. It sings to no one, yet it sings still.",
            "The melody fills the cavern, quiet yet persistent. A voice calling out from the depths of time."
        };

        _dialogue["pit_pole_rock"] = new List<string>
        {
            "The music box plays, fragile and desperate. You could stop its song forever, if you wished.",
            "A simple twist, a moment of pressure, and the music would cease. Would it matter?",
            "The notes drift upward, clinging to the walls like echoes of things unsaid."
        };

        _dialogue["rock_noshovel"] = new List<string>
        {
            "A rock, cold and indifferent. Somehow, it feels more permanent than anything else here.",
            "Of all the things lost to time, this rock remains. A small, quiet defiance.",
            "Solid, unyielding, a relic of a world that once was."
        };

        _dialogue["rock_shovel"] = new List<string>
        {
            "The rock comes free with effort, yet it does not feel like a victory.",
            "It is yours now, though it never truly belonged to anyone before.",
            "You pry the rock from the earth. It leaves a small emptiness behind."
        };

        _dialogue["memo_noshovel"] = new List<string>
        {
            "A broken monument to names the world has already let go of. Whatever it once stood for, time has stripped it bare.",
            "Fingers trace letters that have long since lost their voices. No one visits anymore. No one remembers.",
            "A stone, weathered and alone. It tries to hold on to its purpose, but even the carvings are slipping away."
        };

        _dialogue["memo_shovel"] = new List<string>
        {
            "The earth resists you at first, as if trying to keep its secrets buried. But you dig anyway. And there it is—a key, waiting in the silence.",
            "You unearth something small, something forgotten. A key, left behind like an unanswered question.",
            "Beneath the weight of years and soil, a key emerges. Whoever left it here is gone, but the question remains—why?"
        };

        _dialogue["key_found"] = new List<string>
        {
            "You found the key... though it hardly feels like a victory.",
            "A little bronze key, cold in your grasp. It unlocks something, but does it truly lead anywhere?",
            "The key is yours. Another piece of a puzzle that may never feel complete."
        };

        // Hints
        _dialogue["box_hint"] = new List<string>
        {
            "The box remains locked. You'll need keys. That much should be obvious.",
            "If I were you, I'd start pushing buttons."
        };

        _dialogue["grass_hint"] = new List<string>
        {
            "The treehouse holds something important, or at least, it once did. Now, it waits in silence.",
            "That locket... just a trinket, a memory of someone who is long gone. It doesn't matter anymore, does it?",
            "The hill stands alone, quiet, empty. Maybe you lack what's needed to uncover what it hides."
        };

        _dialogue["river_hint"] = new List<string>
        {
            "The river moves on, always forward. You could try fishing here… if only to pass the time.",
            "That boat... it looks almost inviting, a fragile thing adrift in an endless current.",
            "The mound of dirt seems forgotten, just another piece of the past left to erode away."
        };

        _dialogue["cave_hint"] = new List<string>
        {
            "There are holes everywhere, aren't there? Some things, once lost, are never meant to be found.",
            "The Memorial lingers, a remnant of something no one remembers. Yet, perhaps, it holds the truth.",
            "A rock may serve a purpose, or maybe it's just another thing to carry until you tire of the weight."

        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "The wind moves through the field, but it carries no warmth. Just a hollow rustling, like distant laughter long since faded.",
            "The grass bows and sways, bending under forces unseen. It reminds you of something, though you can't recall what."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "The water flows ever forward, dragging the past with it. You watch from the shore, unable to follow.",
            "The river hums a song you don't recognize, though something in you aches at the sound."
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Shadows linger here, clinging to the walls like old regrets.",
            "The air is damp, thick with the scent of things left behind. It feels like standing inside a forgotten memory."
        };

        _dialogue["repeat"] = new List<string>
        {
            "Ah. Here again. Some places pull you back, even when you don't know why.",
            "You retrace your steps, but each time, they feel heavier.",
            "Some roads lead forward. Others simply loop back on themselves.",
            "A familiar scene, an old memory, a path well-worn. Why do you keep returning?",
            "Perhaps you're searching for something. Perhaps you already lost it.",
            "The past and the present blur, and yet, here you stand."
        };
    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(400); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}