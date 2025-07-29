using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
        public string Model {  get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double distanse)
        {
            if (FuelAmount-distanse*FuelConsumptionPerKilometer>=0)
            {
                FuelAmount-=distanse*FuelConsumptionPerKilometer;
                TravelledDistance+=distanse;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
