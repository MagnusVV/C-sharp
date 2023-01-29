using System;

class simpleDiscount
{
    public static void Main(string[] args)
    {
        var itemA = 45;
        var itemB = 122;
        var itemC = 73;

        var compFirst = Math.Min(itemA, itemB);
        var secondComp = Math.Min(itemB, itemC);
        var thirdComp = Math.Min(compFirst, secondComp);

        var totalCost = itemA + itemB + itemC - thirdComp;

        Console.WriteLine($"Your total is ${totalCost}:-");
    }

}