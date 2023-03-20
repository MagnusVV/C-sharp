var names = new[]
{
    "Egon Spengler",
    "Peter Venkman",
    "Ray Stantz",
    "Winston Zeddemore",
};

var output = GetLongestString(names);

Console.WriteLine(output);

string GetLongestString(string[] names)
{
    string longestName = "";

    foreach (var name in names)
    {
        if (name.Length > longestName.Length)
        {
            longestName = name;
        }
    }

    return longestName;
}