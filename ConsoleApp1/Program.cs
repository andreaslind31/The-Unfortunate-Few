using System.Threading.Tasks;
using ClassLibraryLivingThings;


namespace Start
{
    class Program
    {
        static async Task Main(string[] args)
        {

           CreateOriginCharacters();
           await DifferentMenus.MainMenu();
        }
        static void CreateOriginCharacters() 
        {
            Character Fane = new Character
                (name: "Fane", race: Character.race.Human, strength: 13, dexterity: 10, constitution: 11, intelligence: 12, wisdom: 15, charisma: 13);
            Character Adalgrim = new Character
                (name: "Adalgrim", race: Character.race.Halfling, strength: 9, dexterity: 15, constitution: 11, intelligence: 10, wisdom: 12, charisma: 10);
            Character Virnan = new Character
                (name: "Virnan", race: Character.race.Elf, strength: 12, dexterity: 14, constitution: 10, intelligence: 15, wisdom: 12, charisma: 8);
            Character DweldFogdefender = new Character
                (name: "Dweld Fogdefender", race: Character.race.Centaur, strength: 14, dexterity: 9, constitution: 16, intelligence: 10, wisdom: 12, charisma: 11);
            Character Anspori = new Character
                (name: "Anspori", race: Character.race.Dwarf, strength: 15, dexterity: 10, constitution: 13, intelligence: 8, wisdom: 13, charisma: 10);
            
        }
        
       
        
    }
}
