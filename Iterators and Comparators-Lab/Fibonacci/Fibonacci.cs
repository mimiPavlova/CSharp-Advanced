using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public  class Fibonacci:IEnumerable<long>
    {
        private readonly int _n;
        public int n=>this._n;

        public Fibonacci(int n) 
        {
            this._n = n;
        }

        public IEnumerator<long> GetEnumerator()
        {
            return new Enumerator(this._n);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        //1, 1, 2, 3, 5, 8, 13, 21, 34, 55...
        private class Enumerator : IEnumerator<long>
        {
            private readonly int _n;
            private long _prev, _current;
            private int _index;

            public Enumerator(int n)
            {

                this._n=n;
                this.Reset();
            }


            public long Current => this._current;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                
            }

            public bool MoveNext()
            {
                if(this._index>=this._n)return false;
                long next = this._prev+this._current;
                this._prev=this._current;
                this._current=next;
                _index++;
                return true;
            }

            public void Reset()
            {
                _index=0;
               this._prev=1;
                this._current=0;
            }
        }

    }
}
