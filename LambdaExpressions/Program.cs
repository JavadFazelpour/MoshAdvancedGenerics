namespace LambdaExpressions;

internal class Program
{
    static bool IsCheaperThan50Dollars(Book book)
    {
        return book.Price < 50.0;
    }
    static void Main(string[] args)
    {
        // args => expression

        // () => expression
        // x => expression
        // (x,y,z) => expression

        var books = new BookRepository().GetBooks();
        var cheapBooks = books.FindAll(b => b.Price < 50.0f);
        foreach (var item in cheapBooks)
        {
            Console.WriteLine($"{item.Title}: {item.Price}");
        }

        //var books = new BookRepository().GetBooks();
        //var cheapBooks = books.FindAll(IsCheaperThan50Dollars);
        //foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine(book.Title);
        //}

        //Func<int, int> square = number => number * number;
        //Console.WriteLine($"Using lambda expression 'square': {square(6)}");

        //const int factor = 5;
        //Func<int, int> fiveTimes = x => x * factor;
        //Console.WriteLine($"Using lambda expression 'fiveTimes': {fiveTimes(13)}");
    }
}
