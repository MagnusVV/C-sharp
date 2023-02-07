void outputNameWeirdly(string inputName)
{
    Console.WriteLine($"\n{inputName}");

    for (int position = 0; position < inputName.Length; position++)
    {
        var letter = inputName.Substring(position,1);

        for (int writeLetter = 0; writeLetter < inputName.Length; writeLetter++)
        {
            Console.Write(letter.ToUpper());
        }

        Console.Write("\n");
    }
}

Console.Write("What is your name? ");
var name = Console.ReadLine();

outputNameWeirdly(name);