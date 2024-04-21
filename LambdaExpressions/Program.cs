namespace LambdaExpressions;

internal class Program
{
    static void Main(string[] args)
    {
        // args => expression

        // () => expression
        // x => expression
        //(x,y,z) => expression

        Func<int, int> square = number => number * number;
        Console.WriteLine($"Using lambda expression 'square': {square(6)}");

        const int factor = 5;
        Func<int, int> fiveTimes = x => x * factor;
        Console.WriteLine($"Using lambda expression 'fiveTimes': {fiveTimes(13)}");
    }
}
