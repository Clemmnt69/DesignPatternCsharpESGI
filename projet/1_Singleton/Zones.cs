using System.Collections.Generic;

public class Zones
{
    private string codeZone {get; set; }
    private List<Champs> champs { get; set; }

    public Zones(string codeZone, List<Champs> champs) 
    {
        this.codeZone = codeZone;
        this.champs = champs;
    }
}
