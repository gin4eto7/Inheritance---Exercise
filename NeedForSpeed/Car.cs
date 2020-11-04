using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class Car : Vehicle
    {
        private const double DefaultFuelConsumptionCar = 3;
        public Car(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumptionCar;
        public override void Drive(double kilometers)
        {
            double consumFuel = Fuel - kilometers * FuelConsumption;
            if (consumFuel >= 0)
            {
                Fuel = consumFuel;
            }
        }
    }
}
