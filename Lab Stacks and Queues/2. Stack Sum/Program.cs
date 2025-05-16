namespace _2._Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int>stack= new Stack<int>();  
           int[]numbers=Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            foreach (var item in numbers)
            {
                stack.Push(item);
            }


            string command;
            while ((command=Console.ReadLine().ToLower())!="end")
            {
                string[] data = command.Split(" ");
                if (data[0]=="add")
                {
                    stack.Push(int.Parse(data[1]));
                    stack.Push(int.Parse(data[2]));

                }
                if (data[0]=="remove")
                {
                    int count=int.Parse(data[1]);
                    if (count<=stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                           stack.Pop();
                        }
                       
                    }
                }
            }
            int sum = 0;
            foreach (var item in stack)
            {
                sum+=item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
