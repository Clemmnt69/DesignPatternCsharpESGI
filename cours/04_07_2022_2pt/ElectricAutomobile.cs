using System;

namespace _04_07_2022_2pt
{
    public class ElectricAutomobile : Automobile
    {
        public ElectricAutomobile(string model, string color, int power, double space) : base(model, color, power, space)
        {
        }

        public override void showCarac()
        {
            Console.WriteLine("Electric car: ");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Power: " + power);
            Console.WriteLine("Space: " + space);
        }
    }
}
