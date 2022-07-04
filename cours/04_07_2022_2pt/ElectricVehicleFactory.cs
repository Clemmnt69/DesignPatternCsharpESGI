using System;

namespace _04_07_2022_2pt
{
    public class ElectricVehicleFactory : IVehicleFactory
    {
        public Automobile CreateAutomobile(string model, string color, int power, double space)
        {
            return new ElectricAutomobile(model, color, power, space);
        }
    }
}


