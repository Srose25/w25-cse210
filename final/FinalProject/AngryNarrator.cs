using System;
using System.Collections.Generic;

public class AngryNarrator : Narrator
{
    public AngryNarrator()
    {
        // Initialize dialogue responses
        _dialogue["greeting"] = new List<string>
        {
            
        };

        _dialogue["object_interaction"] = new List<string>
        {
            
        };

        _dialogue["key_found"] = new List<string>
        {
            
        };

        // Initialize hints
        _hint["box_hint"] = new List<string>
        {
            
        };

        _hint["grass_hint"] = new List<string>
        {
            
        };

        _hint["river_hint"] = new List<string>
        {
            
        };

        _hint["cave_hint"] = new List<string>
        {
            
        };

        // Initialize environment descriptions
        _environment["grass"] = new List<string>
        {
            
        };

        _environment["river"] = new List<string>
        {
            
        };

        _environment["cave"] = new List<string>
        {
            
        };
    }

        public override void DialogueSpeed()
    {
        //Fast Speed
    }
}