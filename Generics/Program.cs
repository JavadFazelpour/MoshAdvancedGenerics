namespace Generics;
internal class Program
{
    static void Main(string[] args)
    {
        var book = new Book { ISBN = "1223-454543-787879", Title = "C#: All you need" };

        var bookList = new GenericList<Book>();
        bookList.Add(book);

        var numbers = new GenericList<int>();
        numbers.Add(13);

        var dict = new GenericDictionary<string, Book>();
        dict.Add("C# book", new Book());
    }
}
