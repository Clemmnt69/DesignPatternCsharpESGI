using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Command
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//Récupération du nom du formulaire
            Console.WriteLine("Le nom du formulaire ?"); 
            string nomFormulaire = Console.ReadLine(); 
			
            //Création d'un formulaire
            Formulaire formulaire = new Formulaire(nomFormulaire);

			//Récupération du choix utilisateur pour la création de zones
            Console.WriteLine("Combien de zones voulez vous ?"); 
            int nombreZones = Int32.Parse(Console.ReadLine()); 
			
            //Formulaire formules
			dynamic zones = formulaire.Recuperer("creeZones", nombreZones);
			formulaire.zones = zones;

			dynamic champs = formulaire.Recuperer("creeChamps", formulaire.zones);
            formulaire.champs = champs;

			dynamic html = formulaire.Recuperer("creeHTML", formulaire);
            formulaire.html = html;

            //Formulaire commande
            formulaire.Afficher(formulaire);

            //Attente d'une action utilisateur
            Console.ReadKey();
        }
    }

    
    

    

    
	
	 
		
	
}
