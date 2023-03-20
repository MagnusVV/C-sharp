var input = new[] { 6, 1, 4, 5, 2, 8 };

var output = ThresholdSum(input, 4);


Console.Write(output);


int ThresholdSum(int[] input, int threshold)
{

    int total = 0;

    foreach (int number in input)
    {
        if (number > threshold)
        {
            total += number;
        }
    }

    return total;

}