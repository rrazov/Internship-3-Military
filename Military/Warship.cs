using System;
using System.Collections.Generic;
using System.Text;

namespace Military
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
        public double Swim(int distance)
        {
            double timeToTravel = (distance/AverageSpeed);
            double newDistance = distance;

            for (int i = 10; i < timeToTravel; i+=10)
            {
                if (RandomNumber() < 50)
                {
                    newDistance += 3;
                }
            }

            return newDistance;
        }
    }
}
