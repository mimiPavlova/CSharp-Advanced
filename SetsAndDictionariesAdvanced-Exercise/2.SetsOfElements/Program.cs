namespace _2.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenghts = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = lenghts[0], m=lenghts[1];
            HashSet<int> first = ReadElements(n);
            HashSet<int> second =ReadElements(m);
            Console.WriteLine(string.Join(" ", first.Where(second.Contains)));
           



        }
        static HashSet<int> ReadElements(int n)
        {
            HashSet<int> result = new HashSet<int>();
            for (int i = 0; i <n; i++)
            {
                int element = int.Parse(Console.ReadLine());
                result.Add(element);
            }
            return result;
        }
    }
}
