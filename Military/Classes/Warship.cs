using System;
using System.Collections.Generic;
using System.Text;
using Military.Interfaces;
using Military.Enums;

namespace Military.Classes
{
    public class Warship:Vehicle,ISwimmable
    {
        public Warship(double weight, double averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = (double)FuelConsumptionEnum.WarShip;
            Capacity = (int)CapacityEnum.Warship;

        }
        public int Swim(int distance)
        {
            double timeToTravel = (distance/AverageSpeed);
            double newDistance = distance;

            for (double i = 0.1; i < timeToTravel; i += 0.1)
            {
                if (RandomNumber() < 50)
                {
                    newDistance += 3;
                }
            }

            return (int)newDistance;
        }

        public virtual string Print(int distance, int peopleToTransport )
        {
            return base.Print() + $" ,TotalFuelConsumption: {TotalFuelConsumption(distance , peopleToTransport)} ";
        }   
    }
}