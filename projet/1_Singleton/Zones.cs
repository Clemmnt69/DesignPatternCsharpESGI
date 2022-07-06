using System.Collections.Generic;

public class Zones
{
    public string codeZone {get; set; }
    public List<Champs> champs { get; set; }

    public Zones(string codeZone, List<Champs> champs) 
    {
        this.codeZone = codeZone;
        this.champs = champs;
    }

    public Zones(string codeZone) 
    {
        this.codeZone = codeZone;
    }
}
