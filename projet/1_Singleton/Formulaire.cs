using System.Collections.Generic;

public class Formulaire
{
    public string codeFormulaire {get; set; }
    public string libelle {get; set; }
    public string html { get; set; }

    public Formulaire(string libelle)
    {
        this.codeFormulaire = "Formulaire_" + libelle;
        this.libelle = libelle;
    }

    public Formulaire(string libelle, string html) 
    {
        this.codeFormulaire = "Formulaire_" + libelle;
        this.libelle = libelle;
        this.html = html;
    }
}
