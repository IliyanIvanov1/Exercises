
namespace IteratorsAndComparatorsDemo1
{
    using System;
    using System.Collections.Generic;
    public class Startup
    {

        public static void Main()
        {
            var books = new BookCollection();

            books.Add(new Book { Title = "Book1" });
            books.Add(new Book { Title = "Book2" });
            books.Add(new Book { Title = "Book3" });
            books.Add(new Book { Title = "Book4" });
            books.Add(new Book { Title = "Book5" });

            // var enumerator = new BookCollection.BooksEnumerator(new List<Book>());

            // enumerator.Reset();

            // while (enumerator.MoveNext())
            // {
            //    Console.WriteLine(enumerator.Current.Title);
            // } 

            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
