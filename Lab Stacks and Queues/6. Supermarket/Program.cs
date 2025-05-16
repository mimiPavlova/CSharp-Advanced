using System.Collections.Concurrent;

namespace _6._Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            string command;
            while ((command=Console.ReadLine())!="End")
            {
                if (command=="Paid")
                {
                    while (q.Count>0)
                    {
                      Console.WriteLine(q.Dequeue());
                    }
                    
                }
                else
                {
                    q.Enqueue(command);
                }
            }
            Console.WriteLine($"{q.Count} people remaining.");
        }
    }
}
