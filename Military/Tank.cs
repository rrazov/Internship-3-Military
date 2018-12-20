using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public class Tank:Vehicle,IDriveable
    {
        
        public Tank(double weight, double averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = (double)FuelConsumptionEnum.Tank;
            Capacity = (int)CapacityEnum.Tank;
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

        public virtual string Print(double distance, int peopleToTransport )
        {
            return base.Print() + $" TotalFuelConsumption: {TotalFuelConsumption(Move((int)distance), peopleToTransport)} ";
        }   

    }
}
