using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public  class EqualityScale<T> where T:IComparable
    {
        public T Left;
        public T Right;

        public EqualityScale(T left, T right)
        {
            this.Left=left;
            this.Right=right;
        }
        public bool AreEqual()
        {
            return this.Left.Equals(this.Right);
        }
    }
}
