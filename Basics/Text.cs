using System;

namespace C__Fundamentals.Basics
{
    public class Text
    {
        public void Printing()
        {
            Console.Clear(); //clears the menu off the screen for clean reading

            Console.WriteLine("=== PRINTING & STRING INTERPOLATION ===");
            Console.WriteLine(@"
Notes:
- You can build strings by concatenating with the '+' operator.
- String Formatting uses placeholders like {0} and {1}.
- String Interpolation uses a '$' before the string, allowing you 
  to place variables directly inside { } brackets.
");

            Console.WriteLine("--- Code Output ---");
            Console.WriteLine("Hello, World!");

            string aFriend = "Bill";
            Console.WriteLine($"Original variable: {aFriend}");

            aFriend = "Maria";
            Console.WriteLine($"Overwritten variable: {aFriend}");

            Console.WriteLine("Concatenation: Hello " + aFriend);
            Console.WriteLine("Formatting: Hello {0}", aFriend);
            Console.WriteLine($"Interpolation: Hello {aFriend}");

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        public void RemoveWhitespace()
        {
            Console.Clear();

            Console.WriteLine("=== REMOVING WHITESPACE ===");
            Console.WriteLine(@"
Notes:
- TrimStart() removes spaces at the beginning.
- TrimEnd() removes spaces at the end.
- Trim() removes spaces from both ends.
");

            Console.WriteLine("--- Code Output ---");
            string greeting = "      Hello World!       ";
            Console.WriteLine($"Original: [{greeting}]");

            string trimmedStart = greeting.TrimStart();
            Console.WriteLine($"TrimStart: [{trimmedStart}]");

            string trimmedEnd = greeting.TrimEnd();
            Console.WriteLine($"TrimEnd: [{trimmedEnd}]");

            string trimmedBoth = greeting.Trim();
            Console.WriteLine($"Trim: [{trimmedBoth}]");

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }

        public void SearchAndReplace()
        {
            Console.Clear();
            Console.WriteLine("=== SEARCH AND REPLACE STRINGS ===");
            Console.WriteLine(@"
Notes:
- Replace(old, new) swaps out specific text with new text.
- ToUpper() converts the entire string to UPPERCASE.
- ToLower() converts the entire string to lowercase.
- Contains(text) searches the string and returns true if it finds a match, or false if it doesn't.
");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        } 
    }
}
