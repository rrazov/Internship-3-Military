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
            return 1;
        }
    }
}