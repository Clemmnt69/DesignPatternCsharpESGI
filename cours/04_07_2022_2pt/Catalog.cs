using System;

namespace _04_07_2022_2pt
{
    public class Catalog
    {
        public static int vehicleNumber = 3;
        static void Main(string[] args)
        {
            IVehicleFactory factory = new ElectricVehicleFactory();         
        }
    }
}
