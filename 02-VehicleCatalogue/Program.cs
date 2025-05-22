using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _02_VehicleCatalogue
{
    internal class Program
    {
        class Trucks
        {
            public string Brand { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
        class Cars
        {
            public string Brand { get; set; }
            public string Color { get; set; }
            public int HP { get; set; }
        }
        class Catalogue
        {
            public List<Cars> TypeCars { get; set; }
            public List<Trucks> TypeTrucks { get; set; }
        }
        static void Main(string[] args)
        {
            Catalogue vehicleOnStock = new Catalogue()
            {
                TypeCars = new List<Cars>(),
                TypeTrucks = new List<Trucks>()
            };
            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    break;
                }
                string[] input = inputLine.Split(' ');

                string type = input[0].ToLower();
                string brand = input[1];
                string color = input[2];
                int horsePower = int.Parse(input[3]);

                if (type == "car")
                {
                    Cars typeCar = new Cars()
                    {
                        Brand = brand,
                        Color = color,
                        HP = horsePower
                    };
                    vehicleOnStock.TypeCars.Add(typeCar);
                }
                else if(type == "truck")
                {
                    Trucks typeTrucks = new Trucks()
                    {
                        Brand = brand,
                        Color = color,
                        HorsePower = horsePower
                    };
                    vehicleOnStock.TypeTrucks.Add(typeTrucks);
                }
            }
         

            while (true)
            {
                string searchedVehicle = Console.ReadLine();
                if (searchedVehicle == "Close the Catalogue")
                {
                    break;
                }

                Cars carVehicle = vehicleOnStock.TypeCars
                    .FirstOrDefault(c => c.Brand == searchedVehicle);

                if (carVehicle != null)
                {
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {carVehicle.Brand}");
                    Console.WriteLine($"Color: {carVehicle.Color}");
                    Console.WriteLine($"Horsepower: {carVehicle.HP}");
                    continue;
                }

                Trucks truckVehicle = vehicleOnStock.TypeTrucks
                    .FirstOrDefault(t =>  t.Brand == searchedVehicle);

                if( truckVehicle != null )
                {
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {truckVehicle.Brand}");
                    Console.WriteLine($"Color: {truckVehicle.Color}");
                    Console.WriteLine($"Horsepower: {truckVehicle.HorsePower}");
                };
            }
            if (vehicleOnStock.TypeCars.Count > 0)
            {
                double averageHp = vehicleOnStock
                     .TypeCars
                     .Average(c => c.HP);
                Console.WriteLine($"Cars have average horsepower of: {averageHp:F2}.");
            }
            else
            {
                Console.WriteLine("Cars have average horsepower of: 0.00.");
            }
            if (vehicleOnStock.TypeTrucks.Count > 0)
            {
                double averageHorsePower = vehicleOnStock
                    .TypeTrucks
                    .Average(t => t.HorsePower);
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsePower:F2}.");
            }
            else
            {
                Console.WriteLine("Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
