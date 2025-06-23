using System.Net.Sockets;

namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

             Filter(names, name=>name.Length<=n, name=>Console.WriteLine(name) );
            



        }
        static void Filter(string[] names, Predicate<string> filter, Action<string>action)
        {
           
            foreach(string name in names)
            {
                if (filter(name))
                {
                    action(name);
                }
            }
            
            
        }
    }
}
