int GetInteger(string prompt, int min, int max)
{
    while (true)
    {

        Console.Write($"{prompt}: ");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int answerIsNumber))
        {
            if (answerIsNumber >= min && answerIsNumber <= max)
            {
                return answerIsNumber;
            };
        };
    };
};


var inputPrompt = "Please type a number between 1-2000";

int min = 1;
int max = 2000;

var number = GetInteger(inputPrompt, min, max);

Console.WriteLine($"Your number is {number}.");