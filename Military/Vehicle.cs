using System;
using System.Collections.Generic;
using System.Text;

namespace Military
{
    public abstract class Vehicle
    {
        public Guid Id { get; set; }
        public double Weight { get; set; }
        public double AverageSpeed { get; set; }
        public double FuelConsumption { get; set; }
        public int Capacity { get; set; }

        public virtual string Print()
        {
            return $"Id: {Id}, Weight: {Weight}, Average speed: {AverageSpeed}, Fuel consumption: {FuelConsumption}, Capacity: {Capacity}";
        }

        public int RandomNumber()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0,101);
            return randomNumber;

        }

        public double TotalFuelConsumption(double distance, int peopleToTransport)
        {
            double fuelConsumptionForOneDirection = distance * (FuelConsumption/100);
            double totalFuelConsumption = fuelConsumptionForOneDirection;

            for (int i = 0; i < peopleToTransport; i += (Capacity/2))
            {
                if (i > 0)
                    totalFuelConsumption += fuelConsumptionForOneDirection;
            }
            return totalFuelConsumption;
        }
        
    }
}
