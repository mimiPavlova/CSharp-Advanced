namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
           CustomStack<int>stack = new CustomStack<int>();
            string command;
            while ((command=Console.ReadLine())!="END")
            {
                if (command=="Pop")
                {
                    if (stack.Count==0)
                    {
                        Console.WriteLine("No elements");
                        continue;
                    }

                   stack.Pop();
                }
                else if (command.StartsWith("Push"))
                {
                   IEnumerable<int> numbers=command.Substring(5).Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
                    foreach (int num in numbers)
                    {
                        stack.Push(num);
                    }
                }
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
