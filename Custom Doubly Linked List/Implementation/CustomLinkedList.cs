using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Implementation;

public class CustomLinkedList
{
    //Всеки свързан лист съдържа в момента на създаването си два възела, които са null
    public Node First { get; set; }
    public Node Last { get; set; }


    //1.Създаваме нов възел
    //2.Ако листа ни е празен първият и последният 
    //  елемент са равни на този нов възел и приключваме
    //3. В противен случай, 
    //->next на новия възел = първия
    //->previous на първия = новия 
    //->първия възел = на новия
    public void AddFirst(int value)
    {
        Node newNode = new Node(value);
        if (First==null)
        {
            First= newNode;
            Last=newNode;
            return;
        }
        newNode.Next = First;
        First.Previous = newNode;
        First=newNode;
    }

    public void AddLast(int value)
    {
        Node newNode = new Node(value);
        if (Last==null)
        {
            Last= newNode;
            First=newNode;
            return;
        }
        newNode.Previous = Last;
        Last.Next = newNode;
        Last=newNode;
    }
    public void RemoveFirst()
    {
        if (First==null)
            throw new ArgumentNullException("List is Empty 😵");
        if (First==Last)
        {
            First=null;
            Last=null;
            return;
        }
        First=First.Next;
        First.Previous=null;
    }
    public void RemoveLast()
    {
        if (First==null)
            throw new ArgumentNullException("List is Empty 😵");
        if (First==Last)
        {
            First=null;
            Last=null;
            return;
        }
        Last=Last.Previous;
        Last.Next=null;

    }
    public void ForEach(Action<int> action)
    {
        Node current = First;
        while (current != null)
        {
            action(current.Value);
            current = current.Next;
        }
    }



}
