﻿namespace CarManufacturer;

public class StartUp
{
    static void Main(string[] args)
    {
       Car car=new Car();
        car.Make="VW";

        car.Model="MK3";
        car.Year=1992;

        Console.WriteLine($"Make: {car.Make}\n Model: {car.Model}\nYear: {car.Year}");

        car.FuelQuantity=200;
        car.FuelConsumption=200;
        car.Drive(2000);
        Console.WriteLine(car.WhoAmI());

    
    }
}
