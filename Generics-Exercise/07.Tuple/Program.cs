namespace _07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            string[] drinkTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbersTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string> nameAndAdress = new(personTokens[0]+" "+personTokens[1], personTokens[2]);
            CustomTuple<string, int> NameAndBeer= new(drinkTokens[0], int.Parse(drinkTokens[1]));
            CustomTuple<int, double> numbersTuple = new(int.Parse(numbersTokens[0]), double.Parse(numbersTokens[1]));

            Console.WriteLine(nameAndAdress.ToString());
            Console.WriteLine(NameAndBeer.ToString());
            Console.WriteLine(numbersTuple.ToString());


        }
    }
}
