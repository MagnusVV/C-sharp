using System;

class BuyTicket
{
    public static void Main(string[] args)
    {

        var ticketA = 33;
        var ticketB = 40;
        var ticketC = 60;


        Console.WriteLine("Welcome to Amazing Ticket Systems 1.0\n");

        Console.WriteLine("Which ticket would you like?");
        Console.Write("Type A, B or C: ");

        var ticketChoice = Console.ReadLine();

        while (ticketChoice != "A" && ticketChoice != "B" && ticketChoice != "C")
        {
            Console.WriteLine("I'm sorry, that's not a valid ticket.\n");

            Console.WriteLine("Which ticket would you like?");
            Console.Write("Type A, B or C: ");

            ticketChoice = Console.ReadLine();
        };

        Console.WriteLine("Hej");
    }
}