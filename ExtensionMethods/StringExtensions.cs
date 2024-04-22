namespace ExtensionMethods.Extensions;

public static class StringExtensions
{
    public static string Shorten(this String str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("Number of words should be greater than or equal to 0");

        var words = str.Split(' ');

        if (numberOfWords == 0)
            return "";

        if (words.Length <= numberOfWords)
            return string.Join(' ', words);

        return string.Join(" ", words.Take(numberOfWords));
    }
}
