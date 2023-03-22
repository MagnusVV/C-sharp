using System;

namespace Wordplay
{
	public class PlayHangedman
	{
        private WordHandler PreparedWord { get; }
        private int _counter = 0;

		public PlayHangedman(WordHandler theWord)
		{
            PreparedWord = theWord;

            Console.WriteLine("WELCOME to the GREATEST Hanged man game of ALL* time!");
			Console.WriteLine(" *(User experience may vary)");
            Console.WriteLine(" ...\n");
            Console.WriteLine($"Anyway, the word consists of {PreparedWord.TheWord.Length} letters. Why don't you guess one?\n");
        }

        public bool playGame()
        {
            var scrambledWord = PreparedWord.ScrambledWord;
            var wrongGuesses = new List<string>();

            while (true)
            {
                Console.WriteLine(PreparedWord.TheWord);
                
                if (wrongGuesses.Count > 0)
                {
                    Console.Write("\nWRONG guesses: ");

                    foreach (var wrongGuess in wrongGuesses)
                    {
                        Console.Write($"{wrongGuess} ");
                    }

                    Console.WriteLine();
                }

                Console.WriteLine($"\n{scrambledWord}\n");
                Console.Write("\nGuess letter: ");

                var guessedLetter = Console.ReadLine().ToLower();

                Console.Clear();

                if (guessedLetter.Length > 1 || guessedLetter.Length < 1 || !guessedLetter.All(Char.IsLetter))
                {
                    Console.WriteLine($"'{guessedLetter}'? Are you playing the game, or what? Come on.\n");

                    continue;
                }

                var guessResult = PreparedWord.LookFoorGuessedLetterInWord(
                    guessedLetter, PreparedWord.TheWord, scrambledWord
                    );

                if (guessResult == guessedLetter)
                {
                    Console.WriteLine($"Seriously? '{guessedLetter}' again? Come on.\n");

                    continue;
                }

                if (scrambledWord == guessResult)
                {
                    
                    if (wrongGuesses.Contains(guessedLetter))
                    {
                        Console.WriteLine($"'{guessedLetter}'? It was wrong the last time you trid.\n");

                        continue;
                    }

                    else
                    {
                        Console.WriteLine($"The letter '{guessedLetter}' is not present. Try again.\n");

                        wrongGuesses.Add(guessedLetter);

                        _counter++;

                        continue;
                    }                   
                }

                scrambledWord = guessResult;

                Console.WriteLine($"'{guessedLetter}'! Well guessed!\n");

                if (scrambledWord == PreparedWord.TheWord)
                {
                    Console.Clear();
                    Console.WriteLine($"{scrambledWord}! You did it!");
                    Console.WriteLine("GONGRATS! ...Please do come again.");

                    return false;
                }

                //Console.WriteLine(_counter);

            }
        }
	}
}