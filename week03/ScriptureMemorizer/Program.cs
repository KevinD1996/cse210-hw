using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
 
            List<Scripture> scriptures = new List<Scripture>()
            {
                new Scripture(new Reference("2 Nephi", 2, 25),
                    "Adam fell that men might be; and men are, that they might have joy."),
                new Scripture(new Reference("Mosiah", 2, 17),
                    "When ye are in the service of your fellow beings ye are only in the service of your God."),
                new Scripture(new Reference("Ether", 12, 27),
                    "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me."),
                new Scripture(new Reference("Alma", 37, 6, 7),
                    "By small and simple things are great things brought to pass; and small means in many instances doth confound the wise."),
                new Scripture(new Reference("Moroni", 7, 45, 47),
                    "Charity suffereth long, and is kind; charity never faileth. Wherefore, charity is the pure love of Christ."),
                new Scripture(new Reference("Matthew", 11, 28, 30),
                    "Come unto me, all ye that labour and are heavy laden, and I will give you rest."),
                new Scripture(new Reference("Philippians", 4, 13),
                    "I can do all things through Christ which strengtheneth me."),
                new Scripture(new Reference("John", 14, 27),
                    "Peace I leave with you, my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.")
            };

            Random random = new Random();
            string userInput = "";

            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.\n");

            int index = random.Next(scriptures.Count);
            Scripture currentScripture = scriptures[index];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(currentScripture.GetDisplayText());
                Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");

                if (currentScripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Well done!");
                    break;
                }

                userInput = Console.ReadLine()?.Trim().ToLower() ?? "";

                if (userInput == "quit")
                {
                    Console.WriteLine("Thanks for using Scripture Memorizer!");
                    break;
                }

                currentScripture.HideRandomWords(2);
            }
        }
    }
}
