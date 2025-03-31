using System;
using System.Collections.Generic;

public class NeutralNarrator : Narrator
{
    public NeutralNarrator()
    {
        // Initialize dialogue responses

        //Object Interactions
        _dialogue["_interaction"] = new List<string>
        {

        };

        _dialogue["key_found"] = new List<string>
        {
            "Well done, you found the key.",
            "The little broze key is now within your grasp.",
            "Good job, the key is yours."
        };

        // Initialize hints
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

        // Initialize environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {
            "The grass stretches endlessly. If you stare too long, you might get lost in its beauty.",
            "Green, swaying, utterly unremarkable. The wind feels like the nearly forgotten touch of a loved one."
        };

        _dialogue["describe_river"] = new List<string>
        {
            "Water flows. It doesn't complain. Unlike some people I know.",
            "The river is moving. Unlike you. Maybe start looking for those keys?"
        };

        _dialogue["describe_cave"] = new List<string>
        {
            "Dark, damp, and full of regret. This Cave seems to shedding a tear for something...",
            "Echoes bounce off the cave walls. It's like they're speaking to me."
        };
    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(300); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}
