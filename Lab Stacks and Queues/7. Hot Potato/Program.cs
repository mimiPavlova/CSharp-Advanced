namespace _7._Hot_Potato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            int toses = int.Parse(Console.ReadLine());
            Queue<string> q=new Queue<string>(names);
            int currentTosses = 1;
            while (q.Count>1)
            {
                string child=q.Dequeue();
                if (currentTosses!=toses)
                {
                    
                    q.Enqueue(child);
                    currentTosses++;
                }
                else
                {
                    Console.WriteLine($"Removed {child}");
                    currentTosses=1;
                }
            }
            Console.WriteLine("Last is " +q.Dequeue());
        }
    }
}
