namespace NullableTypes;

internal class Program
{
    static void Main(string[] args)
    {
        // Nullable<DateTime> date is identical to DateTime? date
        DateTime? date = null;

        Console.WriteLine($"Has value:{date.HasValue}");
        Console.WriteLine($"GetValueOrDefault: {date.GetValueOrDefault()}");
        // Console.WriteLine($"value:{date.Value}");
        DateTime? date2 = DateTime.Now;
        Console.WriteLine($"value:{date2.Value}");

        // This line below gives error
        // DateTime date3 = date2;

        var date3 = date2.GetValueOrDefault(); //This is ok

        // We can write this code below in a shorter way
        //if (date!=null)
        //    Console.WriteLine(date);
        //else
        //    Console.WriteLine("it's null");

        // Null-Coalescing operator
        DateTime aDay = date ?? DateTime.Today;



    }
}
