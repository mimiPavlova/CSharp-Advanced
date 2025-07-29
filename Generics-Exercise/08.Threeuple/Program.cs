namespace _08.Threeuple
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] tookens1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] tookens2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] tookens3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            string fullName = $"{tookens1[0]} {tookens1[1]}";
            string address = tookens1[2];
            string town = string.Join(" ", tookens1.Skip(3));
            CustomTreeuple<string, string, string> first = new(fullName, address, town);

            string name2 = tookens2[0];
            int letersBeer = int.Parse(tookens2[1]);
            bool isDrunk = false;
            if (tookens2[2].ToLower()=="drunk")
            {
                isDrunk=true;
            }
            else if (tookens2[2]=="not")
            {
                isDrunk=false;
            }
            CustomTreeuple<string, int, bool> second = new(name2, letersBeer, isDrunk);

            string name3 = tookens3[0];
            double balance = double.Parse(tookens3[1]);
            string bankName = string.Join(" ", tookens3.Skip(2));

            CustomTreeuple<string, double, string> third = new(name3, balance, bankName);
            
            
            Console.WriteLine(first.ToString());
            Console.WriteLine(second.ToString());
            Console.WriteLine(third.ToString());

        }
    }
}
