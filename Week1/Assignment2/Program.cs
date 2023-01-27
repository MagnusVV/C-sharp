using System;

class BuyTicket
{
    public static void Main(string[] args)
    {

        var ticketCostA = 33;
        var ticketCostB = 40;
        var ticketCostC = 60;


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

        var totalCost = 0;

        if (ticketChoice == "A")
        {
            totalCost = ticketCostA;
        }
        else if (ticketChoice == "B")
        {
            totalCost = ticketCostB;
        }
        else
        {
            totalCost = ticketCostC;
        }

        Console.WriteLine($"You have selected {ticketChoice}, your total cost is ${totalCost}");
    }
}