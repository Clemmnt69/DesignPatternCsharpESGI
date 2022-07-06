using System.Collections.Generic;

public class Appli
{
    private static Appli _instance = null;
    public List<Zones> zones { get; set; }
    public List<Champs> champs { get; set; }
    public Formulaire formulaire { get; set; }

    private Appli() {
        
    }

    public static Appli Instance()
    {
        if (_instance == null)
            _instance = new Appli();
        return _instance;
    }
}
