using System;

class BuyTicket
{
    public static void Main(string[] args)
    {

        var ticketCostA = 33;
        var ticketCostB = 40;
        var ticketCostC = 60;

        var vipCost = 20;


        Console.WriteLine("Welcome to Amazing Ticket Systems 2.0\n");

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
        else if(ticketChoice == "C")
        {
            Console.WriteLine("Would you like our special VIP package with that? +$20");
            Console.Write("Type yes or no: \n");

            var vipChoice = Console.ReadLine();
            vipChoice = vipChoice.ToLower();

            while (vipChoice != "yes" && vipChoice != "no") {
                Console.Write("Type yes or no: \n");

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

        if (ticketChoice == "C" && totalCost == 80)
        {
            Console.WriteLine($"You have selected {ticketChoice}+VIP, your total cost is ${totalCost}");
        }
        else
        {
            Console.WriteLine($"You have selected {ticketChoice}, your total cost is ${totalCost}");
        }
    }
}