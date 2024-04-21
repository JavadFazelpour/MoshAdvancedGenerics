namespace LambdaExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Square(6));
    }
    static int Square(int number)
    {
        return number * number;
    }
}
