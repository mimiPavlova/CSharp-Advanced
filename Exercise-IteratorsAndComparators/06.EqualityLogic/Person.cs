using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.EqualityLogic
{
    public class Person : IComparable<Person>, IEquatable<Person>
    {
        private readonly string _name;
        private readonly int _age;
        public Person(string name, int age)
        {
            _name=name;
            _age=age;

        }

        public int CompareTo(Person? other)
        {
            if (other is null)
                throw new ArgumentNullException();

            int nameComparison = this._name.CompareTo(other._name);
            if (nameComparison!=0) return nameComparison;

            int ageComparison = this._age.CompareTo(other._age);
            return ageComparison;


        }


        public override bool Equals(object obj)
       => obj is Person && Equals((Person)obj);
        public override int GetHashCode()
        {
            return HashCode.Combine(_name.GetHashCode(), _age);
        }

        public bool Equals(Person? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            else return EqualityComparer<string>.Default.Equals(this._name, other._name)
            &&EqualityComparer<int>.Default.Equals(this._age, other._age);
        }

        public static bool operator ==(Person left, Person right)
        => EqualityComparer<Person>.Default.Equals(left, right);

        public static bool operator !=(Person left, Person right)
        {
            return !(left==right);
        }

        public static bool operator <(Person left, Person right)
        {
            return Comparer<Person>.Default.Compare(left, right) < 0;
        }

        public static bool operator <=(Person left, Person right)
        {
            return Comparer<Person>.Default.Compare(left, right) <=0;
        }

        public static bool operator >(Person left, Person right)
        {
            return Comparer<Person>.Default.Compare(left, right) > 0; ;
        }

        public static bool operator >=(Person left, Person right)
        {
            return Comparer<Person>.Default.Compare(left, right) >= 0;
        }
    }
}
