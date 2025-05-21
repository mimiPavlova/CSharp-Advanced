namespace _2.SumNumbers
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //    List<int> numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            //    Console.WriteLine(numbers.Count);
            //    Console.WriteLine(numbers.Sum());

            Func<string, int> parser = Parse;
            List<int> numbers = Console.ReadLine().Split(", ").Select(parser).ToList();
            Console.WriteLine(numbers.Count);
            Console.WriteLine(numbers.Sum());

        }
       static  int Parse(string x)
        {
            return int.Parse(x);
        }
    }
}
