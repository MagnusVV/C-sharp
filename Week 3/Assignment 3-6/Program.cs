bool IsValidPassword(string passwordSuggestion)
{
    int digits = 0;

    for (int i = 0; i < passwordSuggestion.Length; i++)
    {
        if (char.IsDigit(passwordSuggestion, i))
        {
            digits++;
        }
    }

    if (!((passwordSuggestion.Length == digits) || digits < 2 || passwordSuggestion.Length < 8))
    {
        return true;
    }

    else
    {
        return false;
    }
}

//Console.Write("Input password suggestion: ");
//var passwordInput = Console.ReadLine();

//Console.WriteLine(IsValidPassword(passwordInput));

Console.WriteLine(IsValidPassword("short"));
Console.WriteLine(IsValidPassword("password"));
Console.WriteLine(IsValidPassword("12345678"));
Console.WriteLine(IsValidPassword("xxxxxxx0"));
Console.WriteLine(IsValidPassword("p4ssw0rd"));