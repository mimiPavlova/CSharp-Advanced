namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers=Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            int num=int.Parse(Console.ReadLine());

           var result=FilterInReverse(numbers, n => n%num!=0);
            Console.WriteLine(string.Join(" " ,result));
        }
        static List<int> FilterInReverse(List<int>arr, Predicate<int> conditon)
        {
            List<int>result = new List<int>();
            for (int i = arr.Count-1; i >=0; i--)
            {
                if (conditon(arr[i]))
                {
                    result.Add(arr[i]);
                }
            }
            return result;
        }
    }
}
