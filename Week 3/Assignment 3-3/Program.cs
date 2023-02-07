string Normalize(string nameToNormalize)
{
    var firstLetter = nameToNormalize.Substring(0, 1).ToUpper();
    var remainingLetters = nameToNormalize.Substring(1, (nameToNormalize.Length - 1)).ToLower();

    var normaLizedName = firstLetter + remainingLetters;

    return normaLizedName;
}

var name = "mAgNUs";

var fixedName = Normalize(name);

Console.WriteLine(fixedName);