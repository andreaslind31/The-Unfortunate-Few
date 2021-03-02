using System;
using Figgle;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static void MenuCharacterCreation()
        {
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
                        break;
                    case 2:
                        Console.Clear();
                        Header();
                        break;
                    case 3:
                        Console.Clear();
                        Header();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Clear();
                        Header();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Nah ah somethins gun rung ");
                        break;
                }
            } while (menuNr != 4);
        }
        static void Header() 
        { 
        
        }
    }
}
