var number = FindDuplicateNumber(new[] { 2, 14, 95, 8, 20, 14, 7, 3 });

Console.WriteLine(number);

int FindDuplicateNumber(int[] numbers)
{
    foreach (var checkNumber in numbers)
    {
        int occurence = 0;

        foreach (var number in numbers)
        {
            if (checkNumber == number)
            {
                occurence += 1;

                if (occurence > 1)
                {
                    return number;
                }
            }
        }
    }

    return -1;
}