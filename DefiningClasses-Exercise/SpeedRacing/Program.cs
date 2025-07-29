namespace SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Dictionary<string, Car> cars=new Dictionary<string, Car>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i <n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                double fuelAmount = double.Parse(data[1]);
                double fuelConsumation = double.Parse(data[2]);
                cars.Add(model,new Car { Model = model, FuelAmount = fuelAmount, FuelConsumptionPerKilometer=fuelConsumation, TravelledDistance=0 });
            }
            string command;
            while((command= Console.ReadLine())!="End")
            {
                string[] data = command.Split(" ");
                string model = data[1];
                double kilometers=double.Parse(data[2]);
                Car currentCar = cars[model];
                currentCar.Drive(kilometers);
            }
            foreach (var car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
