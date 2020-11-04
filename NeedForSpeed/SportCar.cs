using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class SportCar : Car
    {
        private const double DefaultFuelConsumptionSportCar = 10;
        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumptionSportCar;

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
