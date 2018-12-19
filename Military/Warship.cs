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
        public double Swim(int dicstance)
        {
            return 1;
        }
    }
}