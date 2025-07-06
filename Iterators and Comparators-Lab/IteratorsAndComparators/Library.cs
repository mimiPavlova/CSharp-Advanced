using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;

public class Library : IEnumerable<Book>
{
    private readonly List<Book> _books;
    public List<Book> Books => this._books;

    public Library(params Book[] books)
    {
        //this._books=new List<Book>(books.OrderBy(b=>b));
        this._books=new List<Book>(books);
        this._books.Sort(new BookComparator());
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(_books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }


    private class LibraryIterator : IEnumerator<Book>
    {

        private readonly List<Book> _books;
        int index;
        public LibraryIterator(List<Book> books)
        {
            this._books = books;
            Reset();
        }
        public Book Current => _books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            if (index>=this._books.Count) return false;
            else
            {
                return ++index<this._books.Count;
            }
        }

        public void Reset()
        {
            index=-1;
        }
    }
}
