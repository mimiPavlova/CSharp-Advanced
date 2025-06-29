using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Generics;

public class Box<T> 
{
    public T Value;
    public override string ToString()
    {
        return $"{Value.GetType().FullName}: {Value.ToString()}";
    }
}
