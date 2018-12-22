using System;
using System.Collections.Generic;
using System.Text;
using Military.Classes;
using Military.Enums;
using Military.Interfaces;

namespace Military
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Tank
            var leopard2 = new Tank(61.7,72);
            //Warship
            var zumwaltClass = new Warship(35000,56);
            //Amphibious
            var amphibiousPts = new Amphibious(17, 60);
            
            Console.WriteLine("\n------- Military -------");
            Console.Write("Enter the shortest distance from A to B using TANK(km): "); var tankDistance = int.Parse(Console.ReadLine());
            Console.Write("Enter the shortest distance from A to B using WARSHIP (km): "); var warshipDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the shortest distance from A to B using AMPHIBIOUS (km)");
            Console.Write("Enter the land part of the route: "); var amphibiousDistanceMove = int.Parse(Console.ReadLine());
            Console.Write("Enter the sea part of the route: "); var amphibiousDistanceSwim = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of soldiers that must be transported: "); var soldiersToTransport = int.Parse(Console.ReadLine());

            // Calculation of total distance    
            tankDistance = leopard2.Move(tankDistance);
            warshipDistance = zumwaltClass.Swim(warshipDistance);
            var totalAmphibiousDistance = amphibiousPts.Move(amphibiousDistanceMove) + amphibiousPts.Swim(amphibiousDistanceSwim);

            // Calculation of total fuel consumption
            
            var totalFuelConsumptionTank = leopard2.TotalFuelConsumption(tankDistance,soldiersToTransport);
            var totalFuelConsumptionWarship = zumwaltClass.TotalFuelConsumption(warshipDistance, soldiersToTransport);
            var totalFuelConsumptionAmphibious = amphibiousPts.TotalFuelConsumption(totalAmphibiousDistance,soldiersToTransport);

            // Print the details for all vehicles
            Console.WriteLine("\n All details of TANK");
            Console.WriteLine( leopard2.Print(tankDistance,soldiersToTransport));
            Console.WriteLine("\n All details of WARSHIP");
            Console.WriteLine(zumwaltClass.Print(warshipDistance,soldiersToTransport));
            Console.WriteLine("\n All details of AMPHIBIOUS");
            Console.WriteLine(amphibiousPts.Print(totalAmphibiousDistance,soldiersToTransport));

            var bestChoiceString = "TANK!";
            var bestChoice = totalFuelConsumptionTank;

            if (bestChoice > totalFuelConsumptionWarship)
            {
                bestChoice = totalFuelConsumptionWarship;
                bestChoiceString = "WARSHIP!";
            }
            if (bestChoice > totalFuelConsumptionAmphibious)
            {
                bestChoiceString = "AMPHIBIOUS!";
            }
            Console.WriteLine("\n------------");
            Console.WriteLine($"The best choice is: {bestChoiceString}");       
        }
    }
}
