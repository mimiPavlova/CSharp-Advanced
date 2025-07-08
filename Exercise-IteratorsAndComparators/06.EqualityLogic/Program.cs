namespace _06.EqualityLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> set = new HashSet<Person>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person=new Person(data[0], int.Parse(data[1]));
                sortedSet.Add(person);
                set.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(set.Count);
        }
    }
}
