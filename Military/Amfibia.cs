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

        public double Swim(int dicstance)
        {
            return 1;
        }
        public double Move(int distance)
        {
            return 1;
        }
    }
}