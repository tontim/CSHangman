﻿namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to hangman!\n" +
                "First player type in a secret word, the other player please look away!\n" +
                "Secret word: ");
            
            string secretWord = Console.ReadLine();
            List<char> guessedLetters = new List<char>();
            int wrongGuesses = 0;

            Console.Clear();

            if (Utility.StringWithin1and10(secretWord))
            {
                while (true)
                {
                    Console.WriteLine();
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