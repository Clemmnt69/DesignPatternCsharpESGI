using System.Collections.Generic;

public class Champs
{
    public string codeChamp {get; set; }
    public string codeZone {get; set; }
    public string type { get; set; }
    public string className { get; set; }
    public string style { get; set; }
    public string placeholder { get; set; }
    public string valeur { get; set; }

    public Champs()
    {
        
    }

    public Champs(string codeChamp, string codeZone, string type, string className, string style, string placeholder, string valeur) 
    {
        this.codeChamp = codeChamp;
        this.codeZone = codeZone;
        this.type = type;
        this.className = className;
        this.style = style;
        this.placeholder = placeholder;
        this.valeur = valeur;
    }
}
