using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OopIntro;
public class OopApp
{
    public void Run2()
    {
        var cars = new Car[10];
        for (int i = 0; i < cars.Length; i++)
        {
            var input2 = Console.ReadLine();
            cars[i] = new Car(1, 1, 1, input2);
        }

        Console.WriteLine("Type licence plate");
        var input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input))
        {
            Car wantedCar = null;
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i].LicencePlate == input)
                {
                    wantedCar = cars[i];
                }
            }

            Console.WriteLine($"Car with plate {wantedCar.LicencePlate}");
            //Console.WriteLine($"Brand is {wantedCar.B} model {carModels[index]}");
            Console.WriteLine($"Max gas {wantedCar.TankCapacity}, current gas {wantedCar.CurrentGas}");
            Console.WriteLine($"Consuption is {wantedCar.Consumption}");
        }
    }

    public void Run()
    {
        var carBrands = new string[10];
        var carModels = new string[10];
        var carPlates = new string[10];
        var carMaxTanks = new int[10];
        var carCurrentTanks = new int[10];
        var carAvgConsumptions = new double[10];
        var carDistances = new double[10];

        var plate = Console.ReadLine();
        var car = new Car(50, 40, 8.5, plate);
        car.CurrentGas++;
        car.CurrentGas = 1000;

        for (int i = 0; i < carMaxTanks.Length; i++)
        {
            var brandInput = Console.ReadLine();
            carBrands[i] = brandInput;
            var modelInput = Console.ReadLine();
            carModels[i] = modelInput;
            var licenceInput = Console.ReadLine();
            carPlates[i] = licenceInput;

            // other arrays goes here…
        }

        bool proceed = true;
        while (proceed)
        {
            Console.WriteLine("Type licence plate");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                var index = -1;
                for (int i = 0; i < carPlates.Length; i++)
                {
                    if (carPlates[i] == input)
                    {
                        index = i;
                    }
                }

                Console.WriteLine($"Car with plate {carPlates[index]}");
                Console.WriteLine($"Brand is {carBrands[index]} model {carModels[index]}");
                Console.WriteLine($"Max gas {carMaxTanks[index]}, current gas {carCurrentTanks[index]}");
                Console.WriteLine($"Consuption is {carAvgConsumptions[index]} with {carDistances[index]}km.");
            }
            else
            {
                proceed = false;
            }
        }
    }
}
