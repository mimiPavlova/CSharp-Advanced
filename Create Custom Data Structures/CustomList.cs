using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListImplementation;

public class CustomList
{
    private const int defaultCapacity = 4;
    private int[] buffer;
    private int _count;
    public int Count => this._count;

    public CustomList() : this(defaultCapacity)
    {

    }
    public CustomList(int startCapacity)
    {
        if (startCapacity<=0) throw new ArgumentException("capacity must be at least 1");

        this.buffer = new int[startCapacity];
    }
    public int this[int index]
    {
        get
        {
            if (index<0||index>=this.Count) throw new IndexOutOfRangeException("Index out of range ");
            return this.buffer[index];
        }
        set
        {
          if (index<0||index>=this.Count) throw new IndexOutOfRangeException("Index out of range");
            this.buffer[index]=value;
        }
    }

    public void Add(int element)
    {       
        GrowIfNecessary();
        this.buffer[this._count++]=element;
    }
    public int RemoveAt(int index)
    {

        if (index<0||index>=this.Count) throw new ArgumentOutOfRangeException("index out of range");
        int elementToRemove = this.buffer[index];
       
        for (int i = index+1; i <this._count; i++)
        {
            this.buffer[i-1]=this.buffer[i];
        }
        this.buffer[this._count-1]=default;
        this._count--;
        
        return elementToRemove;
    }
    public void Insert(int index, int element)
    {
        if (index<0||index>this.Count) throw new ArgumentOutOfRangeException("Index is out of range");
        GrowIfNecessary();
        
        for (int i = this.Count; i >index; i--)
        {
            this.buffer[i]=this.buffer[i-1];
        }
        this.buffer[index]=element;
        this._count++;


    }
    public bool Contains(int value)
    {
        for (int i = 0; i < this._count; i++)
        {
            if (this.buffer[i]==value) return true;
        }
        return false;
    }
    public void Swap(int firstIndex, int secondIndex)
    {

        if(firstIndex<0||firstIndex>=this.Count||secondIndex<0||secondIndex>=this.Count||firstIndex==secondIndex)
            throw new IndexOutOfRangeException($"Index is out of the range of the array [0, {this._count}]");

        int temp=this.buffer[firstIndex];
        this.buffer[firstIndex]=this.buffer[secondIndex];
        this.buffer[secondIndex]=temp;
    }
    private void GrowIfNecessary()
    {
        if(this.Count==buffer.Length)
        {
            Grow();
        }
    }
    private void Grow()
    {
        int[] newBuffer = new int[this.buffer.Length*2];
        Array.Copy(this.buffer, newBuffer, this.buffer.Length);
        this.buffer = newBuffer;
    }

}
