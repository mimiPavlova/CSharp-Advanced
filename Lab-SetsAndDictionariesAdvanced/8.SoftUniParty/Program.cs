namespace _8.SoftUniParty;

internal class Program
{
    static void Main(string[] args)
    {
        HashSet<string> guests = new HashSet<string>();

        string command;
        while ((command = Console.ReadLine()) !="PARTY")
        {
            guests.Add(command);

        }


        while ((command = Console.ReadLine())!="END")
        {
            guests.Remove(command);
        }
        guests=guests.OrderBy(g => !char.IsDigit(g[0])).ToHashSet();
        Console.WriteLine(guests.Count);
        Console.WriteLine(string.Join("\n", guests));
    
    }
}
