using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Node
    {
       
        //Всеки възел съдържа референция към следващ и предишен възел
        //При инициализирането на първият възел, следващият и предишният са null

        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

 
        
        public Node(int value, Node next=null, Node previous=null )
        {
            this.Value=value;
            this.Next=next;
            this.Previous=previous;
        }
    }
}
