namespace NullableTypes;

internal class Program
{
    static void Main(string[] args)
    {
        DateTime? date = null; 
        Console.WriteLine($"Has value:{date.HasValue}");
        Console.WriteLine($"GetValueOrDefault: {date.GetValueOrDefault()}");
       // Console.WriteLine($"value:{date.Value}");
        

    }
}
