using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions;
internal class BookRepository
{
    public BookRepository()
    {
        
    }
    public List<Book> GetBooks()
    {
        return new List<Book> {
        new(){Title="LINQ in Action",Price=23.65f},
        new(){Title="EF Core in Action",Price=36.95f},
        new(){Title="ASP .NET Core in Action",Price=45.99f},
        new(){Title="Database System concepts 7",Price=59.37f},
        new(){Title=".NET MAUI in Action",Price=65.5f},
        new(){Title="Head First C# 5th edition",Price=50.65f},
        };
    }
}
