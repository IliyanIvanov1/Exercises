
namespace IteratorsAndComparatorsDemo1
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BookCollection : IEnumerable<Book> 
    {
        private readonly List<Book> books;

        public BookCollection()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //public class BooksEnumerator : IEnumerator<Book>
        //{
        //    private int currentIndex;
        //    private readonly List<Book> books;

        //    public BooksEnumerator(List<Book> books)
        //    {
        //        Reset();
        //        this.books = books;
        //    }

        //    public Book Current => this.books[currentIndex];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {

        //    }

        //    public bool MoveNext()
        //    {
        //        currentIndex+=2;
        //        if (this.currentIndex >= this.books.Count)
        //        {
        //            return false;
        //        }
        //        return true;
        //    }

        //    public void Reset() => this.currentIndex = -2;
        //}
    }
    
}
