using System;
using System.Collections.Generic;
using System.Text;
using Military.Interfaces;
using Military.Enums;

namespace Military.Classes
{
    public sealed class Amphibious:Vehicle,IDriveable,ISwimmable
    {
        public Amphibious(double weight, double averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = (double)FuelConsumptionEnum.Amphibious;
            Capacity = (int)CapacityEnum.Amphibious;
        }

        public int Move(int distance)
        {
            var newDistance = distance;
            for (var i = 10; i < distance; i+=10)
            {
                if (RandomNumber() < 30)
                {
                    newDistance += 5;
                }
            }
            return newDistance;
        }
        public int Swim(int distance)
        {
            var timeToTravel = (distance/AverageSpeed);
            var newDistance = distance;

            for (var i = 0.1; i < timeToTravel; i += 0.1)
            {
                if (RandomNumber() < 50)
                {
                    newDistance += 3;
                }
            }

            return (int)newDistance;
        }

        public string Print(int distance, int peopleToTransport )
        {
            return base.Print() + $" ,TotalFuelConsumption: {TotalFuelConsumption(distance , peopleToTransport)} ";
        }   
    }
}
