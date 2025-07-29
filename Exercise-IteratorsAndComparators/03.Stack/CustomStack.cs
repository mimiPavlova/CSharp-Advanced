using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class CustomStack<T>:IEnumerable<T>
    {
        private const int defaultCapacity = 4;
        private T?[] _buffer;
        private int _count;

        public int Count => this._count;

        public CustomStack() : this(defaultCapacity)
        {

        }

        public CustomStack(int capacity)
        {
            this._buffer=new T[capacity];
        }

        public void Push(T value)
        {
            GrowIfNesesery();
            this._buffer[this._count++] = value;
        }
        private void GrowIfNesesery()
        {
            if (this._count == this._buffer.Length)
            {
                this.Grow();
            }
        }
        private void Grow()
        {
            T[] newBuffer = new T[this._buffer.Length*2];
            Array.Copy(this._buffer, newBuffer, this._count);
            this._buffer=newBuffer;
        }
        private void EnsureNotEmpty()
        {
            if (this._count == 0)
                throw new InvalidOperationException("Stack is empty");

        }

        public T Pop()
        {
            EnsureNotEmpty();
            T value = this._buffer[this._count-1]!;
            this._buffer[this._count-1]=default;
            this._count--;
            return value;
        }

        public T Peek()
        {
            EnsureNotEmpty();
            return this._buffer[this._count-1]!;

        }
        public void ForEach(Action<T> action)
        {
            for (int i = this._count-1; i >=0; i--)
            {
                action(this._buffer[i]!);
            }
        }
        public T this[int index]
        {

            get
            {
                ValidateIndex(index);
                return this._buffer[index]!;
            }

        }
        private void ValidateIndex(int index)
        {
            if (index<0||index>=this._count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this._count-1; i >=0; i--)
            {
                yield return this._buffer[i]!;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

