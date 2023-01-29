using System;

class simpleLogin
{
    public static void Main(string[] args)
    {
        var username = "falken";
        var password = "joshua";

        var noTries = 0;

        Console.WriteLine("Welcome to NORAD Online Systems\n");

        while (noTries < 3)
        {
            noTries ++;

            Console.Write("Input USERNAME: ");
            var inputUsername = Console.ReadLine();
            Console.Write("Input PASSWORD: ");
            var inputPassword = Console.ReadLine();

            if (noTries < 4 && inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Greetings professor Falken, would you like to play a game?");
                noTries = 3;
            }
            else if (noTries < 3)
            {
                Console.WriteLine("INCORRECT\n");
            }
            else
            {
                Console.WriteLine("INCORRECT\n");
                Console.WriteLine("Application shutdown, bye!");
            }
        }

    }

}