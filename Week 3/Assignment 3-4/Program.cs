int SumAllDigits(string digits)
{
    var addedTotal = 0;

    for (int iteration = 0; iteration < digits.Length; iteration++)
    {
        var digit = digits.Substring(iteration, 1);

        int.TryParse(digit, out int number);

        addedTotal = addedTotal + number;
    }

    return addedTotal;
}

var input = "87668";

var output = SumAllDigits(input);

Console.WriteLine(output);