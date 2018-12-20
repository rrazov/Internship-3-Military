using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {   
            //tank
            var leopard2 = new Tank(61.7,72);
            //warship
            var zumwaltClass = new Warship(35000,56);
            //amfibia
            var amfibiaPTS = new Amfibia(17, 60);
            
            Console.WriteLine("\n------- Military -------");
            Console.Write("Enter the shortest distance from A to B using TANK(km): "); int tankDistance = int.Parse(Console.ReadLine());
            Console.Write("Enter the shortest distance from A to B using WARSHIP (km): "); int warshipDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the shortest distance from A to B using AMFIBIA (km)");
            Console.Write("Enter the land part of the route: "); int amfibiaDistanceMove = int.Parse(Console.ReadLine());
            Console.Write("Enter the sea part of the route: "); int amfibiaDistanceSwim = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of soldiers that must be transported: "); int soldiersToTransport = int.Parse(Console.ReadLine());

            // Calculation of total distance
            tankDistance = leopard2.Move(tankDistance);
            warshipDistance = zumwaltClass.Swim(warshipDistance);
            var totalAmfibiaDistance = amfibiaPTS.Move(amfibiaDistanceMove) + amfibiaPTS.Swim(amfibiaDistanceSwim);

            // Calculation of total fuel consumption
            var TotalFuelConsumptionTank = leopard2.TotalFuelConsumption(tankDistance,soldiersToTransport);
            var TotalFuelConsumptionWarship = zumwaltClass.TotalFuelConsumption(warshipDistance,soldiersToTransport);
            var TotalFuelConsumptionAmfibia = amfibiaPTS.TotalFuelConsumption(totalAmfibiaDistance,soldiersToTransport);

            // Print the details for all vehicles
            Console.WriteLine("\n All details of TANK");
            Console.WriteLine( leopard2.Print(tankDistance,soldiersToTransport));
            Console.WriteLine("\n All details of WARSHIP");
            Console.WriteLine(zumwaltClass.Print(warshipDistance,soldiersToTransport));
            Console.WriteLine("\n All details of AMFIBIA");
            Console.WriteLine(amfibiaPTS.Print(totalAmfibiaDistance,soldiersToTransport));

            var bestChoiceString = "TANK!";
            var bestChoice = TotalFuelConsumptionTank;

            if (bestChoice > TotalFuelConsumptionWarship)
            {
                bestChoice = TotalFuelConsumptionWarship;
                bestChoiceString = "WARSHIP!";
            }
            else if (bestChoice > TotalFuelConsumptionAmfibia)
            {
                bestChoice = TotalFuelConsumptionAmfibia;
                bestChoiceString = "AMFIBIA!";
            }
            Console.WriteLine("\n------------");
            Console.WriteLine($"The best choice is: {bestChoiceString}");       
        }
    }
}
