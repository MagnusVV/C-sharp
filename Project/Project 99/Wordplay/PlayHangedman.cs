using System;

namespace Wordplay
{
	public class PlayHangedman
	{
        private WordHandler PreparedWord { get; }

		public PlayHangedman(WordHandler theWord)
		{
            Console.WriteLine(theWord.TheWord);

            PreparedWord = theWord;
            Console.WriteLine("WELCOME to the GREATEST Hanged man game of ALL* time!\n");
			Console.WriteLine(" *(User experience is subjective)");
            Console.WriteLine(" ...\n");
            Console.WriteLine($"Anyway, the word consists of {PreparedWord.TheWord.Length} letters. Why don't you guess a letter?");
        }

        public void playGame()
        {
            while(true)
            {
                var scrambledWord = PreparedWord.ScrambledWord;

                Console.WriteLine(scrambledWord);
                var guessedLetter = Console.ReadLine();

                PreparedWord.LookFoorGuessedLetterInWord(guessedLetter, PreparedWord.TheWord, scrambledWord);
            }
        }
	}
}