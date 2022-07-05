using System.Collections.Generic;

public class Appli
{
    private static Appli _instance = null;
    public decimal primes { get; set; }

    private Appli() {
        
    }

    public static Appli Instance()
    {
        if (_instance == null)
            _instance = new Appli();
        return _instance;
    }
}
