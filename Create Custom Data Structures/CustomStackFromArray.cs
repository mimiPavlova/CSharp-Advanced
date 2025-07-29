using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomStackFromArray
    {
        private const int defaultCapacity = 4;
        private int[] _buffer;
        private int _count;

        public int Count => this._count;

        public CustomStackFromArray():this(defaultCapacity)
        {
            
        }

        public CustomStackFromArray(int capacity)
        {
            this._buffer=new int[capacity];
        }

        public void Push(int value)
        {
            GrowIfNesesery();
            this._buffer[this._count++] = value;
        }
        private void GrowIfNesesery()
        {
            if(this._count == this._buffer.Length)
            {
                this.Grow();
            }
        }
        private void Grow()
        {
            int[] newBuffer = new int[this._buffer.Length*2];
           Array.Copy(this._buffer, newBuffer, this._count);
            this._buffer=newBuffer;
        }
        private void EnsureNotEmpty()
        {
            if (this._count == 0)
                throw new InvalidOperationException("Stack is empty");

        }
        
        public int  Pop()
        {
            EnsureNotEmpty();
            int value=this._buffer[this._count-1];
            this._buffer[this._count-1]=default;
            this._count--;
            return value;
        }
        
        public int Peek()
        {
            EnsureNotEmpty();
            return this._buffer[this._count-1];

        }
        public void ForEach(Action<int> action)
        {
            for (int i = this._count-1; i >=0; i--)
            {
                action(this._buffer[i]);
            }
        }
        public int this[int index]
        {

            get 
            {
            ValidateIndex(index);
                return this._buffer[index];
            }
           
        }
        private void ValidateIndex(int index)
        {
            if (index<0||index>=this._count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }

    }

}
