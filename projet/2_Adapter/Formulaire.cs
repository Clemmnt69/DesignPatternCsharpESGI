using System;
using System.Collections.Generic;

namespace _2_Factory
{
    public class Formulaire
    {
        public string codeFormulaire;
        public string libelle;
        public string html;
        public List<ZonesFormulaire> zones;
        public List<ChampsFormulaire> champs;
        public FormulaireDataBank bank;

        public Formulaire(string libelle)
        {
            this.codeFormulaire = "Formulaire_" + libelle;;
            this.libelle = libelle;
        }

        public virtual void Afficher()
        {       
            //L'adapteur
            bank = new FormulaireDataBank();

            //Récupération du choix utilisateur pour la création de zones
            Console.WriteLine("Combien de zones voulez vous ?"); 
            int nombreZones = Int32.Parse(Console.ReadLine()); 

            //Création des zones
            zones = bank.creationZones(nombreZones);

            //Création des champs
            champs = bank.creationChamps(zones);

            //Création du formulaire au format HTML
            html = bank.creationFormulaire(this); 
            
            //Résumer du formulaire crée
            Console.WriteLine("Nom du formulaire : " + libelle);
            Console.WriteLine("Nombre de zone : " + zones.Count);
            Console.WriteLine("Nombre de champs : " + champs.Count);
            Console.WriteLine("Format HTML du formulaire : " + html); 
        }
    }  
}
