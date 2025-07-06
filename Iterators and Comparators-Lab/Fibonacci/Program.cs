namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci f=new Fibonacci(15);
            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Sum:");
            
            Console.WriteLine(f.Sum());
        }
    }
}
