﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class BoxOfT<T>
    {
        private Stack<T> stack;
        public int Count=>stack.Count;
        public BoxOfT()
        {
            stack = new Stack<T>();
        }


        public void Add(T item)
        {
            stack.Push(item);
           
        }
        public T Remove()
        {  
            return stack.Pop();
        }
        
    }
}
