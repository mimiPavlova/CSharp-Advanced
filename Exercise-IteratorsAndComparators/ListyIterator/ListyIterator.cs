using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace ListyIterator
{
   public class ListyIterator<T>:IEnumerable<T>
    {
        private readonly List<T> list;
        private int _index;
        public ListyIterator(IEnumerable<T> values)
        {
            this.list=new List<T>(values);
        }
        public T Current => GetCurrentElement();
        public bool Move()
        {
            if(!HasNext()) return false;
            _index++; 
             return true;
        }
        
        public bool HasNext()
        {
            return this._index+1<list.Count;
        }
       private T GetCurrentElement()
        {
            if (_index>=list.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            return list[_index];
        }



        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < list.Count; i++)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
