using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ComparingObjects
{
   public class Person:IComparable<Person>    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person? other)
        {
            if(other == null) return 1;
            int comparison = Comparer<string>.Default.Compare(Name, other.Name);
            if (comparison != 0) return comparison;
            else
            {
                comparison=Comparer<int>.Default.Compare(Age, other.Age);
                if (comparison != 0) return comparison;
                else
                {
                    comparison=Comparer<string>.Default.Compare(Town, other.Town);
                    return comparison;
                }
            }
        }
    }
}
