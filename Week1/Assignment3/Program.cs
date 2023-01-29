using System;

class BuyTicket
{
    public static void Main(string[] args)
    {

        var ticketCostA = 33;
        var ticketCostB = 40;
        var ticketCostC = 60;

        var vipCost = 20;

        double discount;

        Console.WriteLine("Welcome to Amazing Ticket Systems 3.0\n");
        Console.WriteLine("Please type your email: ");

        var customerEmail = Console.ReadLine();

        if (customerEmail.EndsWith("@yrgo.se") || customerEmail.EndsWith("@w3c.org"))
        {
            discount = 0.8;

            Console.WriteLine("A 20% discount will be applied at checkout!");
        }
        else
        {
            discount = 1.0;
        }

        Console.WriteLine("Which ticket would you like?");
        Console.Write("Type A, B or C: ");

        var ticketChoice = Console.ReadLine();
        ticketChoice = ticketChoice.ToUpper();

        while (ticketChoice != "A" && ticketChoice != "B" && ticketChoice != "C")
        {
            Console.WriteLine("I'm sorry, that's not a valid ticket.\n");

            Console.WriteLine("Which ticket would you like?");
            Console.Write("Type A, B or C: ");

            ticketChoice = Console.ReadLine();
            ticketChoice = ticketChoice.ToUpper();
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
        else if (ticketChoice == "C")
        {
            Console.WriteLine("Would you like our special VIP package with that? +$20");
            Console.Write("Type yes or no: ");

            var vipChoice = Console.ReadLine();
            vipChoice = vipChoice.ToLower();

            while (vipChoice != "yes" && vipChoice != "no")
            {
                Console.Write("Type yes or no: ");

                vipChoice = Console.ReadLine();
                vipChoice = vipChoice.ToLower();
            }

            if (vipChoice == "yes")
            {
                totalCost = ticketCostC + vipCost;
            }
            else if (vipChoice == "no")
            {
                totalCost = ticketCostC;
            }
        }

        var convTotalCost = (double)totalCost;
        convTotalCost = (convTotalCost * discount);

        if (ticketChoice == "C" && convTotalCost == (80 * discount))
        {
            Console.WriteLine($"You have selected {ticketChoice}+VIP, your total cost is ${convTotalCost:F2}");
        }
        else
        {
            Console.WriteLine($"You have selected {ticketChoice}, your total cost is ${convTotalCost:F2}");
        }
    }
}