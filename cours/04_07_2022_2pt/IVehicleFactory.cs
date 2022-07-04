using System;

namespace _04_07_2022_2pt
{
    public interface IVehicleFactory
    {
        Automobile CreateAutomobile(string model, string color, int power, double space);
    }
}
