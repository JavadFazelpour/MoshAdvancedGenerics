namespace Generics;
internal class Program
{
    static void Main(string[] args)
    {
        var number = new Nullable<int>();
        Console.WriteLine($"Has value: {number.HasValue}");
        Console.WriteLine($"Value: {number.GetValueOrNull()}");
    }
}
