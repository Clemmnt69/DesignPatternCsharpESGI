using System.Collections.Generic;

public class Vendeur
{
    private static Vendeur _instance = null;
    public decimal primes { get; set; }

    private Vendeur() {
    }

    public static Vendeur Instance()
    {
        if (_instance == null)
            _instance = new Vendeur();
        return _instance;
    }
}
