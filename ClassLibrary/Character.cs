using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryLivingThings
{
    public class Character
    {
        string Name { get; set; } // föreslå namn vid skapandet beroende på race
        private double Height // default beroende på race
        {
            get
            {
                return Height;
            }
            set
            {
                if (Race == race.Human || Race == race.Elf)
                {
                    Height = 1.80;
                }
                if (Race == race.Centaur)
                {
                    Height = 1.95;
                }
                if (Race == race.Dwarf)
                {
                    Height = 1.5;
                }
                if (Race == race.Halfling)
                {
                    Height = 1.1;
                };
            }
        } 
        private int Weight // default beroende på race
        {
            get
            {
                return Weight;
            }
            set
            {
                if (Race == race.Human || Race == race.Elf)
                {
                    Weight = 85;
                }
                if (Race == race.Centaur)
                {
                    Weight = 300;
                }
                if (Race == race.Dwarf)
                {
                    Weight = 95;
                }
                if (Race == race.Halfling)
                {
                    Weight = 50;
                };
            }
        } 
        private double Reach // default beroende på race
        {
            get
            {
                return Reach; 
            }
            set
            {
                if (Race == race.Human || Race == race.Elf)
                {
                    Reach = Height /2;
                }
                if (Race == race.Centaur)
                {
                    Reach = Height + 0.5;
                }
                if (Race == race.Dwarf || Race == race.Halfling)
                {
                    Reach = Height;
                };
            }
        } 
        private string Description
        {
            get { return Description; }
            set
            {
                if (Name == "Jullan") //female Elf, climbing expert, perceptive
                {
                    Description = "Once a ";
                }
                if (Name == "Fane") //Human male, a likeable 
                {
                    Description = "Once a ";
                }
                if (Name == "Adalgrim") //Halfling male, 
                {
                    Description = "Once a "; 
                }
                if (Name == "Virnan") //Elf male, a condescending swords expert, lone wolf
                {
                    Description = "Once a "; 
                }
                if (Name == "Dweld Fogdefender") //Centaur, male, a noble 
                {
                    Description = "Once a ";
                }
                if (Name == "Anspori") //Dwarf
                {
                    Description = "";
                }
            }
                
        }
        public enum race { Human = 1, Elf = 2, Dwarf = 3, Centaur = 4, Halfling = 5 }
        race Race { get; set; }

        int Strength //+1 human / centaur, dwarf
        {
            get
            { return Strength; }
            set
            {
                if (Race == race.Human)
                {Strength += 1;}
                if (Race == race.Centaur)
                { Strength += 1; }
                if (Race == race.Dwarf)
                { Strength += 1; }; 
            } 
        }  
        int Dexterity //+1 human, +2 elf, halfling
        {
            get
            { return Dexterity; }
            set
            {
                if (Race == race.Human)
                { Dexterity += 1; }
                if (Race == race.Elf || Race == race.Halfling)
                { Dexterity += 2; };
            }
        } 
        int Constitution //+1 human/ dwarf, +2 centaur
        {
            get
            { return Constitution; }
            set
            {
                if (Race == race.Human || Race == race.Dwarf)
                { Constitution += 1; }
                if (Race == race.Centaur)
                { Constitution += 2; };
            }
        } 
        int Intelligence //+1 human / elf
        {
            get
            { return Intelligence; }
            set
            {
                if (Race == race.Human || Race == race.Elf)
                { Intelligence += 1; };
            }
        } 
        int Wisdom //+1 human / dwarf
        {
            get
            { return Wisdom; }
            set
            {
                if (Race == race.Human || Race == race.Dwarf)
                { Wisdom += 1; };
            }
        } 
        int Charisma //+1 human/ halfling 
        {
            get
            { return Charisma; }
            set
            {
                if (Race == race.Human || Race == race.Halfling)
                { Charisma += 1; };
            }
        }

        public EventHandler<CharacterCreation> characterCreation;

        public Character(string name, race race, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            this.Name = name;
            this.Race = race;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Constitution = constitution;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom;
            this.Charisma = charisma;
        }
        public static void CreateOriginCharacters()
        {
            Character Fane = new Character
                (name: "Fane", race: Character.race.Human, strength: 13, dexterity: 9, constitution: 11, intelligence: 12, wisdom: 13, charisma: 15);
            Character Adalgrim = new Character
                (name: "Adalgrim", race: Character.race.Halfling, strength: 9, dexterity: 15, constitution: 11, intelligence: 10, wisdom: 12, charisma: 10);
            Character Virnan = new Character
                (name: "Virnan", race: Character.race.Elf, strength: 12, dexterity: 14, constitution: 10, intelligence: 15, wisdom: 12, charisma: 8);
            Character DweldFogdefender = new Character
                (name: "Dweld Fogdefender", race: Character.race.Centaur, strength: 14, dexterity: 9, constitution: 16, intelligence: 10, wisdom: 12, charisma: 11);
            Character Anspori = new Character
                (name: "Anspori", race: Character.race.Dwarf, strength: 15, dexterity: 10, constitution: 13, intelligence: 8, wisdom: 13, charisma: 10);
            Character Jullan = new Character
                (name: "Jullan", race: Character.race.Elf, strength: 10, dexterity: 17, constitution: 11, intelligence: 11, wisdom: 10, charisma: 11);

            List<Character> characters = new List<Character>();
            characters.Add(Jullan);
            characters.Add(Fane);
            characters.Add(Adalgrim);
            characters.Add(Virnan);
            characters.Add(DweldFogdefender);
            characters.Add(Anspori);
        }
    }
    public class CharacterCreation : EventArgs { }
}
