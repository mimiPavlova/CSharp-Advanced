namespace CarSalesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                int power = int.Parse(data[1]);
                if (data.Length==3)
                {
                    if (int.TryParse(data[2], out int displacement))
                    {

                        Engine engine = new Engine { Model=model, Power=power, Displacement=displacement };
                        engines.Add(engine);

                    }


                    else
                    {
                        string efficiency = data[2];
                        Engine engine = new Engine { Model=model, Power=power, Efficiency=efficiency };
                        engines.Add(engine);
                    }
                }


                else if (data.Length==4)
                {
                    int displacement = int.Parse(data[2]);
                    string efficiency = data[3];
                    Engine engine = new Engine { Model=model, Power=power, Displacement=displacement, Efficiency=efficiency };
                    engines.Add(engine);
                }
                else if (data.Length==2)
                {
                    Engine engine = new Engine { Model=model, Power=power };
                    engines.Add(engine);
                }
            }
            int m = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engineModel = data[1];
                Engine? engine = engines.FirstOrDefault(x => x.Model==engineModel);
                Car car = null;
                if (data.Length==3)
                {
                    if (int.TryParse(data[2], out int weight))
                    {
                         car = new Car
                        {
                            Model=model,
                            Engine=engine,
                            Weight=weight,

                        };
                    }
                    else
                    {
                        string color=data[2];
                         car = new Car
                        {
                            Model=model,
                            Engine=engine,
                           Color=color,

                        };

                    }


                   
                }
                else if (data.Length==4)
                {
                    int weight = int.Parse(data[2]);
                    string color = data[3];
                    car = new Car
                    {
                        Model=model,
                        Engine=engine,
                        Weight=weight,
                        Color=color
                    };
                    
                }
                else if (data.Length==2)
                {
                    car = new Car
                    {
                        Model = model,
                        Engine=engine
                    };

                }
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
