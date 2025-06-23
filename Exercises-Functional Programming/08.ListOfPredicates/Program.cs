using System.ComponentModel.DataAnnotations;

namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int[]dividers=Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Func<int, bool>[] conditions = new Func<int, bool>[dividers.Length];
            for (int i = 0; i < dividers.Length; i++)
            {
                int pos = i;
                conditions[pos]=x => x%dividers[pos]==0;
            }
            var result = Filter(1, n, conditions);
            Console.WriteLine(string.Join(" ", result));
        }

        static List<int>Filter(int start, int end, Func<int, bool>[] conditions)
        {
            List<int> result = new List<int>();
            
            for (int i = start; i <=end; i++)
            {
                bool isMath = true;
                foreach (var c in  conditions)
                {
                    if (!isMath) break;
                   isMath = c(i);
                }
                if(isMath)result.Add(i);
            }
            return result;
        }
    }
}
