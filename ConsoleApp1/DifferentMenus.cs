using System;
using System.IO;
using Figgle;
using System.Threading.Tasks;

namespace ConsoleApp1
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
                        await StorySoFar();
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
        public static async Task StorySoFar()
        {
            String filename = "StorySoFar.txt";
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
            String filename = "CentaursStory.txt";
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
            String filename = "DwarfsStory.txt";
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
            String filename = "ElfsStory.txt";
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
            String filename = "HalflingsStory.txt";
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
            String filename = "HumansStory.txt";
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
        static void Header()
        {
            Console.WriteLine(FiggleFonts.Ogre.Render("The Unfortunate Few!"));
            Console.WriteLine("\n ");
        }
    }
}
