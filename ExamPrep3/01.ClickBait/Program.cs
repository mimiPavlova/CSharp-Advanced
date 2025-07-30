namespace _01.ClickBait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> s = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());

            List<int>result=new List<int>();
            int targetValue=int .Parse(Console.ReadLine());

            while (q.Count>0&&s.Count>0)
            {
                int queueElement = q.Dequeue();
                int stackElement = s.Pop();

                if(stackElement>queueElement)
                {
                    int remainder=stackElement%queueElement;
                    result.Add(Math.Abs(remainder));
                    if (remainder>0)
                    {
                        s.Push(remainder*2);
                    }
                }
                else if (queueElement>stackElement)
                {
                    int remainder=queueElement%stackElement;
                    result.Add(0-remainder);
                    if (remainder>0)
                    {
                        q.Enqueue(remainder*2);
                    }

                }
                else if (queueElement==stackElement)
                {
                    result.Add(0);
                }



            }
            Console.WriteLine($"Final Feed: {string.Join(", ", result)}");
            int totalEngagementValue=result.Sum();
            if (totalEngagementValue>=targetValue)
            {
                Console.WriteLine($"Goal achieved! Engagement Value: {totalEngagementValue}");
            }
            else
            {
                int shortfall=targetValue-totalEngagementValue;
                Console.WriteLine($"Goal not achieved! Short by: {shortfall}");
            }
           
        }
    }
}
