using System.Reflection.Metadata.Ecma335;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n=int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ");


            string result = First(names, x => NameIsSpecial(x, n));
            Console.WriteLine(result);
        }
        static string First(string[] names, Func<string, bool> condition)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (condition(names[i])) return names[i];
            }
            return "No elements";
        }
       static bool NameIsSpecial(string name, int n)
        {
            int sum = 0;
            for (int i = 0; i <name.Length; i++)
            {
                sum+=name[i];
            }
            return sum>=n;

        }
    }
}
