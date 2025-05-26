using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CustomQueueFromArray
    {
        private const int defaultCapacity = 4;
        private int[] _buffer;
        private int _count, _start;
        public int Count => this._count;

        public CustomQueueFromArray() : this(defaultCapacity)
        {
        }

        public CustomQueueFromArray(int capacity)
        {
            if (capacity<=0) throw new ArgumentOutOfRangeException("Capacity must be greater than zero.");
            this._buffer=new int[capacity];
        }
        public int this[int index]
        {
            get 
            {
                ValidateIndex(index);
                return this._buffer[this.GetBufferposition(index)];
            }
        }
        public void Enqueue(int value)
        {
            GrowIfNesesery();
            this._buffer[this.GetBufferposition(this._count)]=value;
            this._count++;
        }
        private void GrowIfNesesery()
        {
            if (this._count==this._buffer.Length)
            {
                this.Grow();
            }
        }
        private void Grow()
        {
            int[] newBuffer = new int[this._buffer.Length*2];
            int rightCount=this._buffer.Length-this._start;
            
            Array.Copy(this._buffer, this._start, newBuffer, 0, rightCount);
            Array.Copy(this._buffer, 0, newBuffer, rightCount, this._count-rightCount);

            this._start=0;
            this._buffer=newBuffer;
        }
        private int GetBufferposition(int index)
        {
            return(this._start+index)%this._buffer.Length;
        }
        public int Dequeue()
        {
            this.EnsureNotEmpty();
            int value = this._buffer[this._start];
            this._buffer[this._start]=default;
            this._start=this.GetBufferposition(1);
            this._count--;
            return value;

        }
        public int Peek()
        {
            EnsureNotEmpty();
            return this._buffer[this._start];
        }
        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < this._count; i++)
            {
                int curent = this._buffer[this.GetBufferposition(i)];
                action(curent);
            }
        }
        private void EnsureNotEmpty()
        {
            if (this._count == 0)
                throw new InvalidOperationException("Queue is empty");

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