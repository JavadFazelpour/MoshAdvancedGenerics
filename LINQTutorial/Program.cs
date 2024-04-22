using LambdaExpressions;
namespace LINQTutorial;
internal class Program
{
    static void Main(string[] args)
    {
        var books = new BookRepository().GetBooks();
        // Console.WriteLine(books.LastOrDefault(b => b.Title == "C# Advanced").Price);
        var paginatedBooks = books.Skip(3).Take(2);
        foreach (var book in paginatedBooks)
        {
            Console.WriteLine($"{book.Title} price is: {book.Price:c}");
        }
        var maxPrice = books.Max(b => b.Price);
        var minPrice = books.Min(b => b.Price);
        var sum = books.Sum(b => b.Price);
        Console.WriteLine(maxPrice);
        Console.WriteLine(minPrice);
        Console.WriteLine(sum);
        // LINQ extension methods syntax
        //var cheapBooks = books
        //                      .Where(b => b.Price < 50f)
        //                      .OrderBy(b => b.Title);

        //foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine($"{book.Title} price is: {book.Price:c}");
        //}


        //var cheapBooks = new List<Book>();
        //foreach (var book in books)
        //{
        //    if (book.Price < 55.0f)
        //        cheapBooks.Add(book);
        //}
        //foreach (var bookTitle in cheapBooks)
        //{
        //    Console.WriteLine($"{bookTitle}");
        //}

        //foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine($"{book.Title} price is: {book.Price:c}");
        //}

        // LINQ query operators
        //var cheaperBooks = from b in books
        //                   where b.Price < 40.0f
        //                   orderby b.Title
        //                   select b;

    }
}
