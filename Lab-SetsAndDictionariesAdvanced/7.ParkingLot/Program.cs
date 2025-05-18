namespace _7.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string>parkingLot = new HashSet<string>();
            string command;
            
            while ((command=Console.ReadLine())!="END")
            {
                string[] data = command.Split(", ");
                string direction = data[0];
                string number=data[1];
                switch (direction)
                {
                    case "IN":
                        parkingLot.Add(number);
                        break;
                    case "OUT":
                        parkingLot.Remove(number);
                        break;
                }
            }
            if (parkingLot.Count > 0) Console.WriteLine(string.Join("\n", parkingLot));
            else Console.WriteLine("Parking Lot is Empty");


        }
    }
}
