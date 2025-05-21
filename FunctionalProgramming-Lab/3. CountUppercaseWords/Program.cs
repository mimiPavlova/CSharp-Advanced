namespace _3._CountUppercaseWords;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.ReadLine()
        //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        //    .Where(word => char.IsUpper(word[0]))
        //    .ToList()
        //    .ForEach(Console.WriteLine);


        //use predicate:
        Predicate<string> filter = isCapital;
        string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(w=>filter(w)).ToArray();
        Console.WriteLine(string.Join("\n", words));
        bool isCapital(string word)
        {
            return char.IsUpper(word[0]);
        }




    }
}
