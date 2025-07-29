namespace _04.GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<int> list = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int[] indexers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Swap(list, indexers[0], indexers[1]);
            foreach (int number in list)
            {
                Console.WriteLine(number.GetType().FullName+": "+number);
            }
        }
        static void Swap<T>(List<T> list, int index1, int index2)
        {
            T tempValue = list[index1];
            list[index1] = list[index2];
            list[index2] = tempValue;
        }
    }
}
