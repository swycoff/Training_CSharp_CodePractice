
using System;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
