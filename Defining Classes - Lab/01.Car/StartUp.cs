namespace CarManufacturer;

public class StartUp
{
    static void Main(string[] args)
    {

        List<Tire[]>tires = new List<Tire[]>();
        List<Engine>engines = new List<Engine>();
        List<Car>cars=new List<Car>();
        string command;
        while((command=Console.ReadLine())!="No more tires")
        {
            string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int year1=int.Parse(data[0]);
            double pressure1=double.Parse(data[1]);


            int year2 = int.Parse(data[2]);
            double pressure2 = double.Parse(data[3]);


            int year3 = int.Parse(data[4]);
            double pressure3 = double.Parse(data[5]);

            int year4 = int.Parse(data[6]);
            double pressure4 = double.Parse(data[7]);
            Tire[] readTires = new Tire[4]
            {
                new Tire(year1, pressure1),
                new Tire(year2, pressure2),
                new Tire(year3, pressure3),
                new Tire(year4, pressure4),
            };
            tires.Add(readTires);
        }
        while ((command=Console.ReadLine())!="Engines done")
        {
            string[] data = command.Split(" ");
            int horsePower=int.Parse(data[0]);
            double capasity=double.Parse(data[1]);
            engines.Add(new Engine(horsePower, capasity));

        }
        while((command=Console.ReadLine())!="Show special")
        {
            string[] data = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string make=data[0];
            string model=data[1];
            int year = int.Parse(data[2]);
            double quantity=double.Parse(data[3]);
            double consumption=double.Parse(data[4]);
            int engineIndex=int.Parse(data[5]);
            int tiresIndex=int.Parse(data[6]);

            Engine engine = engines[engineIndex];
            Tire []carTires=tires[tiresIndex];

            Car car=new Car(make, model, year, quantity, consumption, engine, carTires);
            cars.Add(car);
        }

        var filteredCars = cars.Where(c => c.Engine.HorsePower>330&&c.Year>=2017).ToList();
        filteredCars=FilterCars(filteredCars, (t1, t2, t3, t4) => t1+t2+t3+t4>9&&t1+t2+t3+t4<10);

        foreach (var car in filteredCars)
        {
            car.Drive(20);
            Console.WriteLine(car.WhoAmI());
        }

          
    }   
    static List<Car> FilterCars(List<Car>cars, Func<double, double, double, double, bool>longDumpFilter)
    {
        return cars.Where(car => longDumpFilter(car.Tires[0].Pressure, car.Tires[1].Pressure, car.Tires[2].Pressure, car.Tires[3].Pressure)).ToList();
    }
   
}
