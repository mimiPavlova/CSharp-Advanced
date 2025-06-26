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
    private Engine _engine;
    private Tire []_tires;

    public Engine Engine
    {
        get { return _engine; }
        set { _engine = value; }

    }
    public Tire[] Tires
    {
        get { return _tires; }
        set { _tires = value; }
    }


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


    public Car()
    {
        this._make = "VW";

        this._model = "Golf";
        this._year=2025;
        this._fuelQuantity=200;
        this._fuelConsumption=10;
    }

    public Car(string make, string model, int year )
   :this()
    {
        Make=make;
        Model=model;
        Year=year;
        
    }

    public Car(string make, string model, int year, double quantity, double consumption):this(make, model, year) 
    {
        this._fuelConsumption=consumption;
        this._fuelQuantity = quantity;
    }
    

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
    {
        Engine=engine;
        this.Tires=tires;
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

        return $"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}\nFuel: {this.FuelQuantity:F2}\nConsumption: {this._fuelConsumption}";
    }



}
