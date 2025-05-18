namespace _3.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            HashSet<string> table = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in data)
                {
                    table.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",table.OrderBy(e=>e)));
        }
    }
}
