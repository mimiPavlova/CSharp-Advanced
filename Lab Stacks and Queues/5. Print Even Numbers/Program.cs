namespace _5._Print_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]values=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Queue <int>que= new Queue<int>(values);
            int l=que.Count();
            for (int i = 0; i < l; i++)
            {
                 int n=que.Dequeue();
                if (n%2==0) { que.Enqueue(n); }
            }
            
            Console.WriteLine(string.Join(", ", que));
        }
    }
}
