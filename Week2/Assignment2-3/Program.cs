int GetInteger(string prompt, int min, int max)
{
    while (true)
    {

        Console.WriteLine($"{prompt}: ");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int answerIsNumber))
        {
            if () { };
        };
    };
};

//Console.WriteLine("What's your taste in prompts?");

var inputPrompt = "Please type a number between 1-2000";

var number = GetInteger(inputPrompt);

Console.WriteLine($"Your number is {number}.");


//You need to update your GetInteger method to take two additional arguments, min and max integers. Now the answer must not only be an integer, it has to be within this range.

//It should work like this:

//var number = GetInteger("Please type a number between 1-2000: ", 1, 2000);

//Console.WriteLine($"Your number is {number}.");
//Please type a number between 1-2000: korv?
//Please type a number between 1-2000: -19
//Please type a number between 1-2000: 1337
//Your number is 1337.