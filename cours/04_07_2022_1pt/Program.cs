using System;

namespace _04_07_2022_1pt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //Abstract factory

    //Interface : Définir chaque produit du catalogue
    interface FabriquerVehicule 
    {
        
    }

    public abstract class Automobile
    {
        protected string modele;
        protected string couleur;
    }
}
