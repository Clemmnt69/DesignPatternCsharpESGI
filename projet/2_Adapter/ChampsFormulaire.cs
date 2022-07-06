using System;
using System.Collections.Generic;

namespace _2_Factory
{
    public class ChampsFormulaire
    {
        public string codeChamp;
        public string codeZone;
        public string type;
        public string className;
        public string style;
        public string placeholder;
        public string valeur;

        public ChampsFormulaire()
        {

        }

        public ChampsFormulaire(string codeChamp, string codeZone, string type, string className, string style, string placeholder, string valeur)
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
}
