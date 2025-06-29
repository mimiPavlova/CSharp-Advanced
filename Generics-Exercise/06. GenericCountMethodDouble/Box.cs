using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._GenericCountMethodDouble;

public class Box<T> where T : IComparable<T>
{
    public T Value { get;set;}
    public Box(T value)
    {
        Value=value;
    }

    public override string ToString()
    {
        return $"{Value.GetType().FullName}: {Value.ToString()}";
    }
}
