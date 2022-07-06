using System;
using System.Collections.Generic;

namespace _2_Factory
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
          
            //Affchage du formulaire
            formulaire.Afficher();

            //Attente d'une action utilisateur
            Console.ReadKey();
        }
    }
}
