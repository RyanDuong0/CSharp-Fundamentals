using System;
using C__Fundamentals.Basics; 

namespace C__Fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear(); //keep menu clear

                Console.WriteLine("=== C# Fundamentals Main Menu ===");
                Console.WriteLine("1. Text & Strings");
                Console.WriteLine("2. Variables (Coming Soon)");
                Console.WriteLine("0. Exit");
                Console.Write("Select a topic category: ");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        RunTextMenu();
                        break;

                    case "2":
                        Console.WriteLine("\nVariables notes aren't ready yet! Press any key to go back.");
                        Console.ReadKey();
                        break;

                    case "0":
                        Console.WriteLine("\nExiting notes... Happy coding!");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid selection. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        // --- SUB-MENUS ---
        static void RunTextMenu()
        {
            //instantiate your class here
            Text textNotes = new Text();
            bool inTextMenu = true;

            //loop acts exactly like the main menu, but only for Text notes
            while (inTextMenu)
            {
                Console.Clear();
                Console.WriteLine("=== Text & Strings Notes ===");
                Console.WriteLine("1. Printing & Interpolation");
                Console.WriteLine("2. Removing Whitespace");
                Console.WriteLine("3. Search and Replace text in strings");
                Console.WriteLine("0. Go Back to Main Menu");
                Console.Write("Select a specific note: ");

                string textChoice = Console.ReadLine();

                switch (textChoice)
                {
                    case "1":
                        textNotes.Printing();
                        break;

                    case "2":
                        textNotes.RemoveWhitespace();
                        break;

                    case "3":
                        textNotes.SearchAndReplace();
                        break;

                    case "0":
                        inTextMenu = false;
                        break;

                    default:
                        Console.WriteLine("\nInvalid selection. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
