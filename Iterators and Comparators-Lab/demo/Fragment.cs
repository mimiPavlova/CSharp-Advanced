using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public  class Fragment:IEnumerable<string>
    {
        public string Type {  get; set; }
        private List<string> _words;
        public int WordsCount=>_words.Count;

        public Fragment(string text)
        {
            char[]seeparators=" ,;.!?-:".ToCharArray();
            this._words=text.Split(seeparators, StringSplitOptions.RemoveEmptyEntries).ToList();

        }

        public IEnumerator<string> GetEnumerator()
        {
            return new Enumerator(_words);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        class Enumerator : IEnumerator<string>
        {
            private readonly List<string> _words;
            private int index;
            public Enumerator(List<string> words)
            {
                _words=words;
                Reset();
            }

            public string Current =>_words[index];

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                //throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                index++;
                if (this.index>=_words.Count) return false;
                else
                {
                    return true;
                }

            }

            public void Reset()
            {
                index=-1;
            }
        }
    }

}
