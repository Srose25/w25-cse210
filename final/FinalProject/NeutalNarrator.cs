using System;
using System.Collections.Generic;

public class NeutralNarrator : Narrator
{
    public NeutralNarrator()
    {
        // Initialize dialogue responses
        _dialogue["greeting"] = new List<string>
        {
            "Ah, you again.",
            "Back so soon?",
            "Oh, hello. Let's get on with it then."
        };

        _dialogue["object_interaction"] = new List<string>
        {
            "You stare into it. It entrances you.",
            "Fascinating. A thing. Truly groundbreaking.",
            "This is sure to be useful."
        };

        _dialogue["key_found"] = new List<string>
        {
            "Well done, you found the key.",
            "The little broze key is now within your grasp.",
            "Good job, the key is yours."
        };

        // Initialize hints
        _hint["box_hint"] = new List<string>
        {
            "The box remains locked. You'll need keys. That much should be obvious.",
            "If I were you, I'd start pushing buttons."
        };

        _hint["grass_hint"] = new List<string>
        {
            "My guess is something important is over in that tree house.",
            "That locket doesn't seem important.",
            "There doesn't seem to be anything over at the hill but you may not have the right tool yet."
        };

        _hint["river_hint"] = new List<string>
        {
            "It would be nice to go fishing here. You should look into that.",
            "That boat is really cute, it may be nice to sit in it.",
            "That mound of dirt seems pretty useless."
        };

        _hint["cave_hint"] = new List<string>
        {
            "Holes don't seem to be worth our time.",
            "The Memorial probably contains the biggest secret.",
            "A rock may be useful in some cases."
        };

        // Initialize environment descriptions
        _environment["grass"] = new List<string>
        {
            "The grass stretches endlessly. If you stare too long, you might get lost in its beauty.",
            "Green, swaying, utterly unremarkable. The wind feels like the nearly forgotten touch of a loved one."
        };

        _environment["river"] = new List<string>
        {
            "Water flows. It doesn't complain. Unlike some people I know.",
            "The river is moving. Unlike you. Maybe start looking for those keys?"
        };

        _environment["cave"] = new List<string>
        {
            "Dark, damp, and full of regret. This Cave seems to shedding a tear for something...",
            "Echoes bounce off the cave walls. It's like they're speaking to me."
        };
    }

    public override void DialogueSpeed()
    {
        //Neutral Speed
    }
}
