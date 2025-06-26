using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer;


public class Car
{
    private string _make;
    private string _model;
    private int _year;
    private double _fuelQuantity;
    private double _fuelConsumption;

    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }


    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }
    public double FuelQuantity
    {
        get { return _fuelQuantity; }
       set { _fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return _fuelConsumption; }
       set
        {
            _fuelConsumption = value;
        }
    }

    public void Drive(double distance)
    {
        if (this._fuelQuantity -(distance*this._fuelConsumption)>0)
        {
            this._fuelQuantity-=distance*this._fuelConsumption;
        }
        else
        {
            Console.WriteLine("Not enough fuel to perform this trip!");
        }
    }
    public string WhoAmI()
    {

        return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}";
    }

    

}
