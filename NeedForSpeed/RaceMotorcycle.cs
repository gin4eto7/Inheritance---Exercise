using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumptionRceMotor = 8;
        public RaceMotorcycle(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumptionRceMotor;

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
