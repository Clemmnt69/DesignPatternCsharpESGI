using System.Collections.Generic;

public class Champs
{
    private string codeChamp {get; set; }
    private string type { get; set; }
    private string className { get; set; }
    private string style { get; set; }
    private string placeholder { get; set; }
    private string valeur { get; set; }

    public Champs(string codeChamp, string type, string className, string style, string placeholder, string valeur) 
    {
        this.codeChamp = codeChamp;
        this.type = type;
        this.className = className;
        this.style = style;
        this.placeholder = placeholder;
        this.valeur = valeur;
    }

    public void ajouterChampsAUneZone()
}
