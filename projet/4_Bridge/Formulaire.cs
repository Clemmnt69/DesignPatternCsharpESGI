using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Bridge
{
    public class Formulaire : FormulaireBase
    {
		public string codeFormulaire;
        public string libelle;
        public string html;
        public List<Zones> zones;
        public List<Champs> champs;

		public Formulaire(string nomFormulaire)
        {
            this.codeFormulaire = "Formulaire_" + nomFormulaire;
            this.libelle = nomFormulaire;
        }
    }
}