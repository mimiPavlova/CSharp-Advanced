﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
   public  class Parking
    {
        private readonly List<Car> cars;

        private readonly int capacity;

        public List<Car> Cars=>this.cars;
        public int Count => this.Cars.Count;
        
        public Parking(int capacity)
        {
            this.capacity=capacity;
            cars=new List<Car>(capacity);
        }
        public string AddCar(Car car)
        {
            if(this.cars.Any(c=>c.RegistrationNumber==car.RegistrationNumber)) 
            {
                return"Car with that registration number, already exists!";
            }
            else if (cars.Count==capacity)
            {
               return "Parking is full!" ;
            }
            else 
            {
                cars.Add(car);
                return$"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string registrationNumber)
        {
            Car car = cars.FirstOrDefault(c => c.RegistrationNumber==registrationNumber);
            if(car==null)
            {
                return"Car with that registration number, doesn't exist!";
                
            }
            else
            {
                cars.Remove(car);
                return $"Successfully removed {registrationNumber}";
            }
        }
        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(c => c.RegistrationNumber==registrationNumber);

        }
         public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var n in registrationNumbers)
            {

                cars.RemoveAll(c => c.RegistrationNumber==n);
            }
           
        }

    }
}
