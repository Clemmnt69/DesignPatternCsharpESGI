using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Command
{
    public class Formulaire
    {
        public Formule formule = new Formule();
		public string codeFormulaire;
        public string libelle;
        public string html;
        public List<Zones> zones;
        public List<Champs> champs;

		public Formulaire(string libelle)
        {
            this.codeFormulaire = "Formulaire_" + libelle;
            this.libelle = libelle;
        }
		
        public dynamic Recuperer(string nomFormule, dynamic parametres)
        {
			//Création d'une composition de formule
            Commande commande = new FormulesCommande(formule, nomFormule, parametres);
            return commande.Executer();
        }
		
		public void Afficher(Formulaire formulaire)
        {          
            //Affiche les information du formulaire
			Console.WriteLine("Nom du formulaire : " + formulaire.libelle);
            Console.WriteLine("Nombre de zone : " + formulaire.zones.Count);
            Console.WriteLine("Nombre de champs : " + formulaire.champs.Count);
            Console.WriteLine("Format HTML du formulaire : " + formulaire.html);
        }	
    }
}