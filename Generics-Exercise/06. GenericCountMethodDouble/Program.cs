namespace _06._GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> list = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(new Box<double>(input));
            }
            double comparable =double.Parse( Console.ReadLine());
            Console.WriteLine(GetCount(list, new Box<double>(comparable)));
        }
        static int GetCount<T>(List<Box<T>> list, Box<T> box) where T : IComparable<T>
        {
            int count = 0;
            foreach (Box<T> item in list)
            {   
                if (item.Value.CompareTo(box.Value)>0) count++;
            }
            return count;
        }
    }
}
