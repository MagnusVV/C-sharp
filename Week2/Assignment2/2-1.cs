
internal class Program
{
    private static void Main(string[] args)
    {
        double GetAverage(double value1, double value2, double value3)
        {
            return (value1 + value2 + value3) / 3;
        };

        var average = GetAverage(5, 10, 7.4);

        Console.WriteLine($"Averge: {average:F2}");
    }
}