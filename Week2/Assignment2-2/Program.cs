int GetInteger(string prompt)
{
    while (true)
    {

        Console.Write($"{prompt}: ");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int answerIsNumber))
        {
            return answerIsNumber;
        };
    };
};

//Console.Write("What's your taste in prompts?");

//var inputPrompt = "Please type a number: ";

var number = GetInteger("Please type a number: ");

Console.WriteLine($"Your number is {number}.");