using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Utility
    {
        public static bool StringWithin1and10(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("Error, no input.");
            }
            else
            {
                return input.Length >= 1 && input.Length <= 10;
            }
        }

        public static string GetWordState(string secretWord, List<char> guessedLetters)
        {
            string wordState = "";

            foreach (char c in secretWord)
            {
                if (guessedLetters.Contains(c))
                {
                    wordState += c;
                }
                else
                {
                    wordState += '_';
                }
            }
            return wordState;
        }

        public static void DrawHangman(int wrongGuesses)
        {
            Console.Clear();
            switch (wrongGuesses)
            {
                case 0:
                    Console.WriteLine("     \n" +
                        "     \n" +
                        "     \n" +
                        "_____\n");
                    break;

                case 1:
                    Console.WriteLine("     \n" +
                        "     \n" +
                        "     \n" +
                        "_|___\n");
                    break;

                case 2:
                    Console.WriteLine("     \n" +
                        "     \n" +
                        " |   \n" +
                        "_|___\n");
                    break;
                case 3:
                    Console.WriteLine("     \n" +
                        " |   \n" +
                        " |   \n" +
                        "_|___\n");
                    break;
                case 4:
                    Console.WriteLine(",____\n" +
                        " |´  \n" +
                        " |   \n" +
                        "_|___\n");
                    break;
                case 5:
                    Console.WriteLine(",____\n" +
                        " |´ |\n" +
                        " |   \n" +
                        "_|___\n");
                    break;

                default:
                    Console.WriteLine(",____\n" +
                        " |´ o - Oh no!\n" +
                        " | ´|`\n" +
                        "_|__^\n");
                    break;
            }
        }

    }
}
