using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Command
{
    public class FormulesCommande : Commande
    {
        public string nomFormule;
        public dynamic parametres;
        public Formule formule;

        public FormulesCommande(Formule formule, string nomFormule, dynamic parametres)
        {
            this.formule = formule;
            this.nomFormule = nomFormule;
            this.parametres = parametres;
        }

        public string NomFormule
        {
            set { nomFormule = value; }
        }

        public int Parametres
        {
            set { parametres = value; }
        }

        public override dynamic Executer()
        {
            return formule.LesFormules(nomFormule, parametres);
        }
    }
}