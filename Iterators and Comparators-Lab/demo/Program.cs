namespace demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fragment f = new Fragment("Hello, world");

            foreach (var item in f)
            {
                Console.WriteLine(item);
            }
        }
    }
}
