using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Froggy
{
    public class Lake : IEnumerable<int>
    {
        private readonly int[] _stones;
        public Lake(IEnumerable<int>stones)
        {
            this._stones=stones.ToArray();
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _stones.Length; i+=2)
            {
                yield return _stones[i];
            }
            for (int i = _stones.Length-_stones.Length%2-1; i >=0; i-=2)
            {
                yield return _stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
