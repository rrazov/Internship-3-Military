using System;
using System.Collections.Generic;
using System.Text;
using Military.Interfaces;
using Military.Enums;

namespace Military.Classes
{
    public abstract class Vehicle
    {
        protected Guid Id { get; set; }
        protected double Weight { get; set; }
        protected double AverageSpeed { get; set; }
        protected double FuelConsumption { get; set; }
        protected int Capacity { get; set; }

        protected virtual string Print()
        {
            return $" Id: {Id}, Weight: {Weight}, Average speed: {AverageSpeed}, Fuel consumption: {FuelConsumption}, Capacity: {Capacity}";
        }

        protected static int RandomNumber()
        {
            var rnd = new Random();
            var randomNumber = rnd.Next(0,101);
            return randomNumber;

        }

        public double TotalFuelConsumption(int distance, int peopleToTransport)
        {
            var fuelConsumptionForOneDirection = distance * (FuelConsumption/100);
            var totalFuelConsumption = fuelConsumptionForOneDirection;

            for (var i = 0; i < peopleToTransport; i += (Capacity/2))
            {
                if (i > 0)
                    totalFuelConsumption += fuelConsumptionForOneDirection;
            }
            return totalFuelConsumption;
        }
        
    }
}
