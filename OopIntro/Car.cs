using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntro;
public class Car
{
    private int _tankCapacity;
    public int TankCapacity
    {
        get { return _tankCapacity; }
        set { _tankCapacity = value; }
    }

    private double _currentGas;
    public double CurrentGas
    {
        get { return _currentGas; }
        set
        {
            if (value >= 0 && value <= _tankCapacity)
            {
                _currentGas = value;
            }
        }
    }

    private double _consumption;
    public double Consumption
    {
        get { return _consumption; }
        set { CurrentGas = value; }
    }
    private string _licencePlate;
    public string LicencePlate
    {
        get { return _licencePlate; }
        set { _licencePlate = value; }
    }

    public Car()
    {
    }

    public Car(int tankCapacity,
        double currentGas,
        double consumption,
        string licencePlate
        )
    {
        if (tankCapacity > 0)
        {
            _tankCapacity = tankCapacity;
        }
        _currentGas = currentGas;
        _consumption = consumption;
        _licencePlate = licencePlate;
    }

    public void TurnOn()
    {
        Console.WriteLine(_tankCapacity);
    }
}
