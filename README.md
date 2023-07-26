# C-sharp

## About
This is bit of a strange bird. My Github behaved... strange... during the C-sharp course.

The only real interesting thing here is the "Project" folder (or rather Project -> Project 99 -> Wordplay), since this is the place for the project that marked the end of the C-sharp course.

The task was to create "something" that utilised what we learned during the course. It was supposed to be an object-based console application. I programmed it in the Visual Studio (Preview) editor for Mac, and also ran the program in that editor's console.

I built a simple Hanged man-game. It fetches a word from a random-word-generator-API (some reeeeeeaaaaaally hard words there) every time the game starts. You put in a letter as a guess by the prompt int the console. The program checks if a letter exists, if it's been used before, and also piece by piece draws a hanged man in the console window if you guess wrong. It also shows a the word's length and unmask letters that were correctly guessed. It also reacts (harshly) with a new prompt if you try putting in numbers, symbols or more than one letter at a time.

To avoid bloating the code, I created two text files that the application uses. The first contains the coordinates (in the console) where the hanged man should be drawn. The other contains the different symbols that make up the figure itself. Depending on how many wrong guesses that's been made, more of the imported coordinates will be looped through (and also more of the symbols drawn).
