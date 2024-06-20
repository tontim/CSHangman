using System.Collections.Generic;
using System.IO;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>(File.ReadAllLines("words.txt"));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n____ ");
            Console.ResetColor();
            Console.Write("Welcome to hangman!\n\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[1] ");
            Console.ResetColor();
            Console.Write("Play against computer.\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[2] ");
            Console.ResetColor();
            Console.Write("Play with own words.\n\n" +
                "Choice:");

            int gameChoice = int.Parse(Console.ReadLine());

            Random random = new Random();
            string secretWord = "";

            switch (gameChoice)
            { 
                case 1:
                    int index = random.Next(words.Count);
                    secretWord = words[index];

                    break;

                case 2:
                    Console.Write("\nOwn words!\n\n" +
                    "First player type in a secret word,\n" +
                    "the other player ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("please look away!\n\n");
                    Console.ResetColor();

                    Console.Write("Secret word: ");
                    secretWord = Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Choose one of the options please.");
                    break;
            }

            List<char> guessedLetters = new List<char>();
            int wrongGuesses = 0;

            Console.Clear();
            Console.WriteLine("     \n" +
                            "     \n" +
                            "     \n" +
                            "_____\n" +
                            "\nCurrent word: \n");

            if (Utility.StringWithin1and10(secretWord))
            {
                while (true)
                {
                    Console.WriteLine("Guess a letter: ");
                    char guess = Console.ReadLine()[0];

                    if (secretWord.Contains(guess))
                    {
                        guessedLetters.Add(guess);
                    }
                    else
                    {
                        wrongGuesses++;
                    }

                    Utility.DrawHangman(wrongGuesses);
                    Console.Write("Current word: ");
                    Console.WriteLine(Utility.GetWordState(secretWord, guessedLetters));
                }
            }
            else
            {
                Console.WriteLine("Enter a word between 1 and 10");
            }

        }
    }
}
