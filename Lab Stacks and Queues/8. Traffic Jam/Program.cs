namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCarsTottal = 0;
            string command;
            while ((command=Console.ReadLine())!="end")
            {
                if (command=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count==0) break;
                        Console.WriteLine(cars.Dequeue()+" passed!");
                        passedCarsTottal++;
                    }
                    
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
            Console.WriteLine($"{passedCarsTottal} cars passed the crossroads.");
        }
    }
}
