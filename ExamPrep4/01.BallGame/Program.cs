
using System.Diagnostics;

namespace _01.BallGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> strengtValues=new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Queue<int> accuraciesValues = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int goals = 0;
            while (strengtValues.Count>0&&accuraciesValues.Count>0)
            {
                int strengt = strengtValues.Peek();
                int accuracies = accuraciesValues.Peek();

                int sum=strengt+accuracies;
                if (sum==100)
                {
                    goals++;
                    strengtValues.Pop();
                    accuraciesValues.Dequeue();
                }
                else if (sum<100)
                {
                    if (strengt<accuracies) strengtValues.Pop();
                    else if (accuracies<strengt) accuraciesValues.Dequeue();
                    else if (strengt==accuracies)
                    {
                        accuraciesValues.Dequeue() ;
                        strengtValues.Pop();
                        strengtValues.Push(sum);
                    }
                }
                else
                {
                    accuraciesValues.Enqueue(accuraciesValues.Dequeue());
                    strengtValues.Push(strengtValues.Pop()-10);
                }

            }
            if (goals==3)
            {
                Console.WriteLine("Paul scored a hat-trick!");
            }
            else if (goals==0)
            {
                Console.WriteLine("Paul failed to score a single goal.");
            }
            else if(goals>3)
            {
                Console.WriteLine("Paul performed remarkably well!");
            }
            else
            {
                Console.WriteLine("Paul failed to make a hat-trick.");
            }
            if(goals!=0)
            Console.WriteLine($"Goals scored: {goals}");

            if (strengtValues.Count>0)
            {
                Console.WriteLine($"Strength values left: {string.Join(", ", strengtValues)}");
            }
            else if (accuraciesValues.Count>0)
            {
                Console.WriteLine($"Accuracy values left: {string.Join(", ", accuraciesValues)}");
            }
        }
    }
}
