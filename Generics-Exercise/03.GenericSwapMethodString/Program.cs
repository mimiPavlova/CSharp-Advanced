namespace _03.GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> list = new List<string>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            int[] indexers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            Swap(list, indexers[0], indexers[1]);
            foreach (string str in list)
            {
                Console.WriteLine(str.GetType().FullName+": "+str);
            }
        }
        static void Swap<T>(List<T>list, int index1, int index2)
        {
            T tempValue=list[index1];
            list[index1] = list[index2];
            list[index2] = tempValue;
        }
    }
}
