Console.WriteLine(" -- Amazing Leap Year Calculator -- \n");

int GetYear(string prompt, int minYear, int maxYear)
{
    while (true)
    {
        Console.Write($"{prompt}: ");
        var answer = Console.ReadLine();

        if (!int.TryParse(answer, out int fakeYear))
        {
            Console.WriteLine("A year must be a number.\n");
        }
        if (int.TryParse(answer, out int invalidYear) && invalidYear < minYear || invalidYear > maxYear)
        {
            Console.WriteLine($"The number has to be between {minYear} and {maxYear}\n");
        }
        if (int.TryParse(answer, out int validYear) && validYear >= minYear && validYear <= maxYear)
        {
            Console.WriteLine("OK!\n");
            return validYear;
        }
    }
}

int min = 0;
int max = 9999;

var firstYear = GetYear("First year", min, max);
var secondYear = GetYear("Second year", firstYear, max);

for (int year = firstYear; year <= secondYear; year++)
{
    if (DateTime.IsLeapYear(year))
    {
        Console.WriteLine($"{year} *");
    }
    else
    {
        Console.WriteLine(year);
    }
}
