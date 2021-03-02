using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Character
    {
        string Name { get; set; }
        enum Race { Human = 1, Elf = 2, Dwarf = 3, Kentaur = 4, Halfling = 5 }
        Race race { get; set; }
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Constitution { get; set; }
        int Intelligence { get; set; }
        int Wisdom { get; set; }
        int Charisma { get; set; }

    }
}
