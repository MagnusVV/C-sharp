using System;
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

        private string ScrambleWord(string scrambleThis)
        {
            var scrambled = "";
            for (int i = 0; i < scrambleThis.Length; i++)
            {
                scrambled = scrambled.Insert(scrambled.Length, "*");
            }
            return scrambled;
        }

        public void LookFoorGuessedLetterInWord(string guessedLetter, string theWord, string scrambledWord)
        {
            for (int position = 0; position < theWord.Length; position++)
            {
                if (guessedLetter == theWord.Substring(position, 1))
                {
                    scrambledWord.Substring(position, 1).Replace("*", guessedLetter);
                    Console.WriteLine(scrambledWord);
                }
            }
        }
    }
}

