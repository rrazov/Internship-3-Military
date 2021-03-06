using System;
using System.Collections.Generic;
using System.Text;
using Military.Interfaces;
using Military.Enums;

namespace Military.Classes
{
    public sealed class Tank:Vehicle,IDriveable
    {
        
        public Tank(double weight, double averageSpeed)
        {
            Id = Guid.NewGuid();
            Weight = weight;
            AverageSpeed = averageSpeed;
            FuelConsumption = (double)FuelConsumptionEnum.Tank;
            Capacity = (int)CapacityEnum.Tank;
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

        public string Print(int distance, int peopleToTransport)
        {
            return base.Print() + $" ,TotalFuelConsumption: {TotalFuelConsumption(distance , peopleToTransport)} ";
        }   

    }
}
