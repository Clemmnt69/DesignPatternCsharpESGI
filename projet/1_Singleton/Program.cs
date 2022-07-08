using System;
using System.Linq;
using System.Collections.Generic;

namespace _1_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Création d'une instance de Appli : "app"
            Appli app = Appli.Instance();

            //Récupération du nom du formulaire
            Console.WriteLine("Le nom du formulaire ?"); 
            string nomFormulaire = Console.ReadLine(); 

            //Récupération du choix utilisateur pour la création de zones
            Console.WriteLine("Combien de zones voulez vous ?"); 
            int nombreZones = Int32.Parse(Console.ReadLine()); 

            //Création des zones         
            app.zones = creationZones(nombreZones);

            //Création des champs
            app.champs = creationChamps(app);

            //Création du formulaire au format HTML
            app.formulaire = creationFormulaire(app, nomFormulaire);      

            //Résumer du formulaire crée
            Console.WriteLine("Nom du formulaire : " + app.formulaire.libelle);
            Console.WriteLine("Nombre de zone : " + app.zones.Count());
            Console.WriteLine("Nombre de champs : " + app.champs.Count());
            Console.WriteLine("Format HTML du formulaire : " + app.formulaire.html); 
            
            //Attente d'une action utilisateur
            Console.ReadKey();   
        }

        private static List<Zones> creationZones(int nombreZones)
        {
            List<Zones> listeZones = new List<Zones>();
            int i = 0;
            while (i < nombreZones) 
            {
                Zones zone = new Zones("Zone_" + (i + 1));
                listeZones.Add(zone);
                i++;
            }
            return listeZones;
        }

        private static List<Champs> creationChamps(Appli app)
        {
            List<Champs> listeChamps = new List<Champs>();

            //Pour chaques zones, l'utilisateur ajoute des champs 
            foreach (Zones zone in app.zones)
            {
                //Récupération du choix utilisateur pour la création des champs
                Console.WriteLine("Pour la " + zone.codeZone +" combien de champs voulez vous ?"); 
                int nombreChamps = Int32.Parse(Console.ReadLine()); 

                //Pour chaques champs souhaités, récupération des choix utilisateur
                int y = 0;
                while (y < nombreChamps) 
                {
                    Champs champs = new Champs();

                    champs.codeChamp = "Champs_" + (y + 1); 
                    champs.codeZone = zone.codeZone; 

                    Console.WriteLine("Champs numéro " + (y + 1) + ", type du champs (label, input, date, checkbox, button) ?");
                    champs.type = Console.ReadLine();

                    Console.WriteLine("Champs numéro " + (y + 1) + ", class CSS utilisée ?");
                    champs.className = Console.ReadLine();
                    
                    Console.WriteLine("Champs numéro " + (y + 1) + ", style CSS utilisé ?");
                    champs.style = Console.ReadLine();

                    Console.WriteLine("Champs numéro " + (y + 1) + ", placeholder ?");
                    champs.placeholder = Console.ReadLine();

                    Console.WriteLine("Champs numéro " + (y + 1) + ", valeur par défaut ?");
                    champs.valeur = Console.ReadLine();

                    //Ajout du champs
                    listeChamps.Add(champs);

                    y++;
                }
            }
            return listeChamps;
        }

        private static Formulaire creationFormulaire(Appli app, string nomFormulaire)
        {
            //Mise en place du formulaire 
            Formulaire formulaire = new Formulaire(nomFormulaire);
            formulaire.html = $"<h1 style='text-align : center;'> {formulaire.libelle} </h1>";

            //Création au format HTML de chaques zones
            foreach (Zones Unezone in app.zones)  
            {
                formulaire.html += $"<div id='{Unezone.codeZone}'>";

                //Récupération des champs associé à la zone
                List<Champs> champs = app.champs.Where(item => item.codeZone == Unezone.codeZone).ToList();

                //Création au format HTML de chaques champs dans la zone
                foreach (Champs unChamps in champs)
                {
                    switch (unChamps.type)
                    {
                        case "label" : 
                            formulaire.html += $"<label id='{unChamps.codeChamp}_{Unezone.codeZone}' ";

                            if(!String.IsNullOrEmpty(unChamps.className))
                                formulaire.html += $"class='{unChamps.className}'";

                            if(!String.IsNullOrEmpty(unChamps.style))
                                formulaire.html += $"style='{unChamps.style}'";

                            if(!String.IsNullOrEmpty(unChamps.valeur))
                                formulaire.html += $">{unChamps.valeur}"; 

                            formulaire.html += "</label>";
                            break;

                        case "input" : 
                            formulaire.html += $"<input id='{unChamps.codeChamp}_{Unezone.codeZone}' ";

                            if(!String.IsNullOrEmpty(unChamps.className))
                                formulaire.html += $"class='{unChamps.className}'";

                            if(!String.IsNullOrEmpty(unChamps.style))
                                formulaire.html += $"style='{unChamps.style}'";

                            if(!String.IsNullOrEmpty(unChamps.placeholder))
                                formulaire.html += $"placeholder='{unChamps.placeholder}'";
                            
                            if(!String.IsNullOrEmpty(unChamps.type))
                                formulaire.html += $"type='{unChamps.type}'";

                            if(!String.IsNullOrEmpty(unChamps.valeur))
                                formulaire.html += $"value='{unChamps.valeur}'";; 

                            formulaire.html += "></input>";
                            break; 

                        case "date" : 
                            formulaire.html += $"<input id='{unChamps.codeChamp}_{Unezone.codeZone}' ";

                            if(!String.IsNullOrEmpty(unChamps.className))
                                formulaire.html += $"class='{unChamps.className}'";

                            if(!String.IsNullOrEmpty(unChamps.style))
                                formulaire.html += $"style='{unChamps.style}'";
                            
                            if(!String.IsNullOrEmpty(unChamps.type))
                                formulaire.html += "type='date'";

                            if(!String.IsNullOrEmpty(unChamps.valeur))
                                formulaire.html += $"value='{unChamps.valeur}'";

                            formulaire.html += "></input>";
                            break;

                        case "checkbox" : 
                            formulaire.html += $"<input id='{unChamps.codeChamp}_{Unezone.codeZone}' ";

                            if(!String.IsNullOrEmpty(unChamps.className))
                                formulaire.html += $"class='{unChamps.className}'";

                            if(!String.IsNullOrEmpty(unChamps.style))
                                formulaire.html += $"style='{unChamps.style}'";
                            
                            if(!String.IsNullOrEmpty(unChamps.type))
                                formulaire.html += "type='checkbox'";

                            formulaire.html += "></input>";
                            break;

                        case "button" : 
                            formulaire.html += $"<button id='{unChamps.codeChamp}_{Unezone.codeZone}' ";

                            if(!String.IsNullOrEmpty(unChamps.className))
                                formulaire.html += $"class='{unChamps.className}'";

                            if(!String.IsNullOrEmpty(unChamps.style))
                                formulaire.html += $"style='{unChamps.style}'";
                            
                            if(!String.IsNullOrEmpty(unChamps.type))
                                formulaire.html += $"type='{unChamps.type}'";

                            if(!String.IsNullOrEmpty(unChamps.valeur))
                                formulaire.html += $">{unChamps.valeur}"; 

                            formulaire.html += "></button>";
                            break;
                        
                        default:
                            break;
                    }
                }
                formulaire.html += "</div>";             
            }
            return formulaire;
        }  
    }
}
