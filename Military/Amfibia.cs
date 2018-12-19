using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Amfibia:Vehicle,IDriveable,ISwimmable
    {
        public Amfibia(double weight, double averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = (double)FuelConsumptionEnum.Amfibia;
            Capacity = (int)CapacityEnum.Amfibia;
        }

        public double Move(int distance)
        {
            double newDistance = distance;
            for (int i = 10; i < distance; i+=10)
            {
                if (RandomNumber() < 30)
                {
                    newDistance += 5;
                }
            }
            return newDistance;
        }
        public double Swim(int distance)
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

            return newDistance;
        }
    }
}
