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
            "That won't help you, but sure, go ahead."
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
            "",
            "",
            ""
        };

        _hint["river_hint"] = new List<string>
        {
            "",
            "",
            ""
        };

        _hint["cave_hint"] = new List<string>
        {
            "",
            "",
            ""
        };

        // Initialize environment descriptions
        _environment["grass"] = new List<string>
        {
            "The grass stretches endlessly. If you stare too long, you might start contemplating existence. Don't.",
            "Green, swaying, utterly unremarkable."
        };

        _environment["river"] = new List<string>
        {
            "Water flows. It doesn't complain. Unlike some people I know.",
            "The river is moving. Unlike you. Maybe start looking for those keys?"
        };

        _environment["cave"] = new List<string>
        {
            "Dark, damp, and full of regret. Like my life.",
            "Echoes bounce off the cave walls. They sound smarter than you."
        };
    }

    public override string ProvideHint(string key)
    {
        return GetRandomResponse(_hint, key);
    }

    public override string DescribeEnvironment(string key)
    {
        return GetRandomResponse(_environment, key);
    }

    // Utility method to get a random response from a dictionary
    private string GetRandomResponse(Dictionary<string, List<string>> dictionary, string key)
    {
        if (dictionary.ContainsKey(key) && dictionary[key].Count > 0)
        {
            Random rnd = new Random();
            return dictionary[key][rnd.Next(dictionary[key].Count)];
        }
        return "The Narrator remains silent.";
    }
}
