using System;
using System.IO;
using Figgle;
using System.Threading.Tasks;
using ClassLibraryLivingThings;

namespace Start
{
    public class DifferentMenus
    {
    /// 
    /// Start up menus
    /// 
        public static async Task MainMenu()
        {
            Console.Clear();
            Header();
            int menuNr;
            do
            {
                Console.WriteLine("{ 1 } New game");
                Console.WriteLine("{ 2 } Load game");
                Console.WriteLine("{ 3 } Story");
                Console.WriteLine("{ 4 } Exit");
                Console.WriteLine();

                bool parseNumber = int.TryParse(Console.ReadLine(), out menuNr);
                if (parseNumber == false)
                {
                    Console.WriteLine("Please enter a correct number");
                    break;
                }
                switch (menuNr)
                {
                    case 1:
                        Console.Clear();
                        Header();
                        await CharacterCreation();
                        break;
                    case 2:
                        Console.Clear();
                        Header();

                        break;
                    case 3:
                        Console.Clear();
                        Header();
                        await StoryMenu();
                        break;
                    case 4:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Nope");
                        break;
                }
            } while (menuNr != 4);
        }
        public static async Task StoryMenu()
        {
            Console.Clear();
            Header();
            int menuNr;
            do
            {

                Console.WriteLine("{ 1 } The story so far\n");
                Console.WriteLine("Playable races: ");
                Console.WriteLine("{ 2 } Centaurs");
                Console.WriteLine("{ 3 } Dwarfs");
                Console.WriteLine("{ 4 } Elfs");
                Console.WriteLine("{ 5 } Halflings");
                Console.WriteLine("{ 6 } Humans");
                Console.WriteLine();
                Console.WriteLine("\n Press any other key to go back");
                bool parseNumber = int.TryParse(Console.ReadLine(), out menuNr);
                if (parseNumber == false)
                {
                    await MainMenu();
                    break;
                }
                switch (menuNr)
                {
                    case 1:
                        Console.Clear();
                        Header();
                        await StoryUntilStart();
                        await BackToStoryMenu();
                        break;
                    case 2:
                        Console.Clear();
                        Header();
                        await AboutCentaurs();
                        await BackToStoryMenu();
                        break;
                    case 3:
                        Console.Clear();
                        Header();
                        await AboutDwarfs();
                        await BackToStoryMenu();
                        break;
                    case 4:
                        Console.Clear();
                        Header();
                        await AboutElfs();
                        await BackToStoryMenu();
                        break;
                    case 5:
                        Console.Clear();
                        Header();
                        await AboutHalflings();
                        await BackToStoryMenu();
                        break;
                    case 6:
                        Console.Clear();
                        Header();
                        await AboutHumans();
                        await BackToStoryMenu();
                        break;
                    default:

                        break;
                }
            } while (menuNr != 7);
        }
        public static async Task StoryUntilStart()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\StoryUntilStart.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
        public static async Task AboutCentaurs()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\ShortStoryRaces\AboutCentaurs.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
        public static async Task AboutDwarfs()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\ShortStoryRaces\AboutDwarfs.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
        public static async Task AboutElfs()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\ShortStoryRaces\AboutElfs.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
        public static async Task AboutHalflings()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\ShortStoryRaces\AboutHalflings.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
        public static async Task AboutHumans()
        {
            String filename = @"C:\Users\User\Google Drive\Systemutveckling VT-21\The Unfortunate Few\ConsoleApp1\TextFiles\ShortStoryRaces\AboutHumans.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));

        }
        public static async Task BackToStoryMenu()
        {
            Console.WriteLine();
            Console.WriteLine("\nEnter or escape to return\n");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Enter || consoleKeyInfo.Key == ConsoleKey.Escape)
            {
                await StoryMenu();
            }
        }
        public static async Task CharacterCreation()
        {
            Console.Clear();
            Header();
            int menuNr;
            do
            {
                Console.WriteLine("{ 1 } New character");
                Console.WriteLine("{ 2 } Check out the origin characters");
                Console.WriteLine("{ 3 } Back");
                Console.WriteLine();

                bool parseNumber = int.TryParse(Console.ReadLine(), out menuNr);
                if (parseNumber == false)
                {
                    Console.WriteLine("Enter a correct number");
                    break;
                }
                switch (menuNr)
                {
                    case 1:
                        Console.Clear();
                        Header();

                        break;
                    case 2:
                        Console.Clear();
                        Header();
                        await StoryOfOriginChars();
                        break;
                    case 3:
                        Console.Clear();
                        Header();
                        await StoryMenu();
                        break;
                    default:
                        Console.WriteLine("Nope");
                        break;
                }
            } while (menuNr != 4);
        }
        public static async Task StoryOfOriginChars() 
        {
            Console.Clear();
            Header();
            int menuNr;
            do
            {
                Console.WriteLine("{ 1 } Fane, human male");
                Console.WriteLine("{ 2 } Adalgrim, male halfling");
                Console.WriteLine("{ 3 } Virnan, male elf");
                Console.WriteLine("{ 4 } Dweld Fogdefender, female centaur");
                Console.WriteLine("{ 5 } Anspori, female dwarf");
                Console.WriteLine("{ 6 } Jullan, female elf");
                Console.WriteLine();

                bool parseNumber = int.TryParse(Console.ReadLine(), out menuNr);
                if (parseNumber == false)
                {
                    Console.WriteLine("Enter a correct number");
                    break;
                }
                switch (menuNr)
                {
                    case 1:
                        Console.Clear();
                        Header();
                        
                        break;
                    case 2:
                        Console.Clear();
                        Header();

                        break;
                    case 3:
                        Console.Clear();
                        Header();

                        break;
                    case 4:
                        Console.Clear();
                        Header();

                        break;
                    case 5:
                        Console.Clear();
                        Header();

                        break;
                    case 6:
                        Console.Clear();
                        Header();

                        break;
                    default:
                        Console.WriteLine("Nope");
                        break;
                }
            } while (menuNr != 4);
        }
        static void Header()
        {
            Console.WriteLine(FiggleFonts.Ogre.Render("The Unfortunate Few!"));
            Console.WriteLine("\n ");
        }
    }
}
