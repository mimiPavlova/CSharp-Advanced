namespace _3._CountUppercaseWords;

internal class Program
{
    static void Main(string[] args)
    {
        Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(word => char.IsUpper(word[0]))
            .ToList()
            .ForEach(Console.WriteLine);
      
    }
}
