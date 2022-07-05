using System;

namespace _1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendeur vendeur1 = Vendeur.Instance();
            Vendeur vendeur2 = Vendeur.Instance();

            vendeur1.primes = 455;
            if(vendeur2.primes == vendeur1.primes)
                Console.WriteLine("Singleton ok");
            else
                Console.WriteLine("Singleton ko");
        }
    }
}
