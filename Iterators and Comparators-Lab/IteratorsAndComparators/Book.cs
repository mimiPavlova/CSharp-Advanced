using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators;

public class Book:IComparable<Book>
{
    private readonly string _title;
    private readonly int _year;
    private readonly List<string> _authors;

    public string Title => this._title;

    public int Year => this._year;
    public List<string> Author => this._authors;

    public Book(string title, int year, params string[] authours)
    {
        _title = title;
        _year = year;
        _authors=new List<string>(authours);
    }

    public int CompareTo(Book? other)
    {
        int comparison = this.Year.CompareTo(other.Year);
       if(comparison == 0) 
        {
            return this.Title.CompareTo(other.Title);
        }
       return comparison;
    }
    public override string ToString() => $"{Title} - {Year}";
}
