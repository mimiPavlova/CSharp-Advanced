using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class CustomLinkedStack
    {
        private Node ?_top { get; set; }
        private int _count;

        //O(1)
        public void Push(int value)
        {
            Node node = new Node();
            node.Value = value;
            node._Prev=this._top;
            this._top=node;
            _count++;
        }
        //O(1)
        public int Pop()
        {
            this.EnsureNotEmpty();
            int removedValue = this._top!.Value;

            Node nextTop=this._top._Prev;
            this._top._Prev=null;
            this._top=nextTop;
            this._count--;
            return removedValue;


        }
        //O(1)
        public int Peek()
        {
            this.EnsureNotEmpty();
            return this._top.Value;
        }
        //O(n)
        public void ForEach(Action<int> action)
        {
            Node? iter = this._top;
            while (iter is not null)
            {
                action(iter.Value);
                iter=iter._Prev;

            }
            
        }
        private void ValidateIndex(int index)
        {
            if (index<0||index>=this._count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }
        public int this[int index]
        {
            //O(n)
            get
            {
                ValidateIndex(index);
                int stepsBack = this._count-(index+1);
                Node iter=this._top;
                for (int i = 0; i <stepsBack; i++)
                {
                    iter=iter._Prev;
                }
                return iter!.Value;
            }

        }
        public int Count()
        {
            return this._count;
        }
        private class Node 
        {
        public int Value { get; set; }
            public Node _Prev{ get; set; }
        }

        private void EnsureNotEmpty()
        {
            if (this._count == 0)
                throw new InvalidOperationException("Stack is empty");

        }
    }
}
