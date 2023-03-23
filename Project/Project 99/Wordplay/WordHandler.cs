using System;
using System.Text;

namespace Wordplay
{
    public class WordHandler
    {
        public string TheWord { get; }
        public string ScrambledWord { get; private set; }

        public WordHandler(string theWord)
        {
            TheWord = theWord;
            ScrambledWord = ScrambleWord(theWord);
        }

        private static string ScrambleWord(string scrambleThisWord)
        {
            var scrambledWord = "";
            for (int i = 0; i < scrambleThisWord.Length; i++)
            {
                scrambledWord = scrambledWord.Insert(scrambledWord.Length, "*");
            }

            return scrambledWord;
        }

        public static string LookFoorGuessedLetterInWord(
            string guessedLetter, string theWord, string scrambledWord
            )
        {

            for (int position = 0; position < theWord.Length; position++)
            {
                if (guessedLetter == scrambledWord.Substring(position, 1))
                {
                    return guessedLetter;
                }

                if (guessedLetter == theWord.Substring(position, 1))
                {
                    StringBuilder modifyScrambledWord = new StringBuilder(scrambledWord);
                    char guessedChar = char.Parse(guessedLetter);
                    modifyScrambledWord[position] = guessedChar;

                    scrambledWord = modifyScrambledWord.ToString();
                }
            }

            return scrambledWord;
        }
    }
}