using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class CustomLinkedQueue
    {
        private Node?_head, _tail;
        private int count;


        //O(1)
        public void Enqueue(int element)
        {
            Node newNode=new Node();
            newNode.Value = element;
            if(this.count == 0)
            {
                this._head = newNode;
                this._tail=newNode;
            }
            else
            {
                this._tail!.Next=newNode;
                this._tail = newNode;
               
            } 
            this.count++;
        }

        //O(1)
        public int Dequeue()
        {
            this.EnsureNotEmpty();
            int removedElement = this._head.Value;
            if (this.count==1)
            {
                this._head = this._tail = null;
            }
            else
            {
                Node?next = this._head.Next;
                this._head.Next=null;
                this._head=next;
            }
            this.count--;
            return removedElement;
               
        }

        //O(1)
        public int Peek()
        {
            this.EnsureNotEmpty();
            return this._head.Value;
        }

        //O(n)
        public void ForEach(Action<int> action)
        {
            Node eter = this._head;
            while (eter is not null)
            {
                action(eter.Value);
                eter =eter.Next;
            }
        }
       
        //O(n)
        public int this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                Node iter = this._head;
                for (int i = 0; i < index; i++)
                {
                    iter=iter.Next;

                }
                return iter.Value;
            }
        }
        private void EnsureNotEmpty()
        {
            if (this.count == 0)
                throw new InvalidOperationException("Queue is empty");

        }
        private void ValidateIndex(int index)
        {
            if (index<0||index>=this.count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }
        }


        private class Node 
        {
            public int Value { get; set; }
         public Node Next { get; set; }
        }

    }
}
