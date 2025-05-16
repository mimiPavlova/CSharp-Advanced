namespace _3._Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string>stack=new Stack<string>();
            string[] data = Console.ReadLine().Split(" ");
            for (int i =data.Length-1 ; i>=0; i--)
            {
                stack.Push(data[i]);
            }

            string lastIndex = "+";
            int result = 0;
            while (stack.Count!=0)
            {
                if (stack.Peek()=="+") { lastIndex = "+"; stack.Pop(); continue; }
                else if (stack.Peek()=="-") { lastIndex="-"; stack.Pop(); continue; }
                else
                {
                    int n = int.Parse(stack.Pop());
                    if (lastIndex=="+") result+=n;
                    else if (lastIndex=="-") result-=n;
                }
            }
            Console.WriteLine(result);
        }
    }
}
