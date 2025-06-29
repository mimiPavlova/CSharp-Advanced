namespace Exercise_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
               // string str=Console.ReadLine();
               int num=int.Parse(Console.ReadLine());
                Box<int>box=new Box<int> { Value=num};
                Console.WriteLine(box.ToString()); 
            }
        }
    }
}
