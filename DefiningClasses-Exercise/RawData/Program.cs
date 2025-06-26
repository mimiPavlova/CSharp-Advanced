namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car>  cars = new List<Car>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model=data[0];
                int speed=int.Parse(data[1]);
                int power=int.Parse(data[2]);
                Engine engine = new Engine { MaxSpeed=speed, HorsePower=power };
            
                double weight=int.Parse(data[3]);
                string type=data[4];
                Cargo cargo = new Cargo { Type=type, Weight=weight};

                Tire t1 = new Tire { Pressure=double.Parse(data[5]), Year=int.Parse(data[6]) };
                Tire t2 = new Tire { Pressure=double.Parse(data[7]), Year=int.Parse(data[8]) };
                Tire t3 = new Tire { Pressure=double.Parse(data[9]), Year=int.Parse(data[10]) };
                Tire t4 = new Tire { Pressure=double.Parse(data[11]), Year=int.Parse(data[12]) };



                Tire[] tires = new Tire[4]
                {
                    t1,t2,t3, t4

                };
                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);

            }
            string command=Console.ReadLine();
            List<Car> result = null;
            if (command=="fragile")
            {
                result = cars.Where(c => c.Cargo.Type=="fragile"&&c.Tires.Any(t => t.Pressure<1)).ToList();
            }
            else if (command=="flammable")
            {
                result = cars.Where(c => c.Cargo.Type=="flammable"&&c.Engine.HorsePower>250).ToList();

            }
            Print(result);
        }
        
        static void Print (List<Car> cars)
        {
            foreach(Car c in cars)
            {
                Console.WriteLine(c.Model);
            }
        }
    }
    
}
