using System;
using System.Collections.Generic;

public class AngryNarrator : Narrator
{
    public AngryNarrator()
    {
        //Initialize dialogue responses
        _dialogue["_interaction"] = new List<string>
        {

        };

        //River Dialogue
        _dialogue["fishing_nopole"] = new List<string>
        {

        };

        _dialogue["fishing_pole"] = new List<string>
        {
           
        };

        _dialogue["boat_noshovel"] = new List<string>
        {
            
        };

        _dialogue["boat_shovel"] = new List<string>
        {

        };

        _dialogue["mound_norock"] = new List<string>
        {

        };

        _dialogue["mound_rock"] = new List<string>
        {

        };

        //Grass Dialogue
        _dialogue["treehouse_norock"] = new List<string>
        {
           
        };

        _dialogue["treehouse_rock"] = new List<string>
        {
            
        };

        _dialogue["locket_norock"] = new List<string>
        {
            
        };

        _dialogue["locket_rock"] = new List<string>
        {

        };

        _dialogue["hill_noshovel"] = new List<string>
        {
           
        };

        _dialogue["hill_shovel"] = new List<string>
        {
           
        };

        //Cave Dialogue
        _dialogue["pit_nopole_norock"] = new List<string>
        {

        };

        _dialogue["pit_pole_norock"] = new List<string>
        {

        };

        _dialogue["pit_pole_rock"] = new List<string>
        {

        };

        _dialogue["rock_noshovel"] = new List<string>
        {

        };

        _dialogue["rock_shovel"] = new List<string>
        {

        };

        _dialogue["memo_noshovel"] = new List<string>
        {

        };

        _dialogue["memo_shovel"] = new List<string>
        {

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

        };

        _dialogue["river_hint"] = new List<string>
        {

        };

        _dialogue["cave_hint"] = new List<string>
        {

        };

        // Environment descriptions
        _dialogue["describe_grass"] = new List<string>
        {

        };

        _dialogue["describe_river"] = new List<string>
        {
            
        };

        _dialogue["describe_cave"] = new List<string>
        {
            
        };
    }

    public override void DialogueSpeed(string sentence)
    {
        
        string[] words = sentence.Split(' '); // Split into words

        foreach (string word in words)
        {
            Console.Write(word + " "); // Print each word
            Thread.Sleep(150); // Pause between words
        }

        Console.WriteLine(); // New line at the end
    }
}