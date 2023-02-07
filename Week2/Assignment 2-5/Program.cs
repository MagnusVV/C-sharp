int CalculatePrice(int productAmount, int productCost)
{
    // For every 10th productAmount, rebate will deduct one unit from the total amount:
    double rebate = (productAmount / 10);

    var modifiedAmount = productAmount - Math.Floor(rebate);

    return ((int)modifiedAmount * productCost);
};

Console.Write("Amount of items to buy: ");
int.TryParse(Console.ReadLine(), out int productAmount);

Console.Write("Cost per item: ");
int.TryParse(Console.ReadLine(), out int productCost);

Console.WriteLine();

Console.WriteLine($"Buying {productAmount} units for unit price ${productCost} will give the total cost of ${CalculatePrice(productAmount, productCost)}");