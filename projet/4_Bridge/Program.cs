using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Bridge
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//Récupération du nom du formulaire
            Console.WriteLine("Le nom du formulaire ?"); 
            string nomFormulaire = Console.ReadLine(); 
			
            //Création d'un formulaire
            var formulaire = new Formulaire(nomFormulaire);

            //Instansation de l'implémenteur
            formulaire.Data = new FormulaireData(nomFormulaire);

			//Récupération du choix utilisateur pour la création de zones
            Console.WriteLine("Combien de zones voulez vous ?"); 
            int nombreZones = Int32.Parse(Console.ReadLine());
			
			//Formulaire formules
			formulaire.zones = formulaire.CreeZones(nombreZones);

			formulaire.champs = formulaire.CreeChamps(formulaire.zones);

			formulaire.html = formulaire.CreeHTML(formulaire);

            //Affiche les information du formulaire
            formulaire.Afficher(formulaire);

            //Attente d'une action utilisateur
            Console.ReadKey();
        }
    }
}
