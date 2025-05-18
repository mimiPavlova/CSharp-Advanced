namespace _1.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> input=Console.ReadLine().Split(" ").Select(double.Parse).ToList();
            Dictionary<double, int>values_count=new Dictionary<double, int>();
            foreach (double number in input)
            {
                if (values_count.ContainsKey(number))
                {
                    values_count[number]++;
                }
                else
                {
                    values_count[number] = 1;
                }
            }
            foreach (var (number, count) in values_count)
            {
                Console.WriteLine($"{number} - {count} times");
            }
        }
    }
}
