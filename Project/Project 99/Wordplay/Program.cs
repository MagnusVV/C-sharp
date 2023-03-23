using System;
using Wordplay;

var wordFetch = new FetchRandomWord();
var fetchedWord = wordFetch.FetchWordFromApi();

var word = new WordHandler(fetchedWord);

var game = new PlayHangedman(word);
game.playGame();