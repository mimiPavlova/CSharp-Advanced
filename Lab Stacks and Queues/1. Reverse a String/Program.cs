namespace _1._Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string str = Console.ReadLine();
            foreach (char simbol in str)
            {
                stack.Push(simbol);
            }
            foreach (char simbol in stack)
            {
                Console.Write(simbol);
            }
            Console.WriteLine();
        }
    }
}
