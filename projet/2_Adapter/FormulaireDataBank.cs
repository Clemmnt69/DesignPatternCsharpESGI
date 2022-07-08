using System;
using System.Linq;
using System.Collections.Generic;

namespace _2_Factory
{
    public class FormulaireDataBank
    {
        public List<ZonesFormulaire> creationZones(int nombreZones)
        {
            List<ZonesFormulaire> listeZones = new List<ZonesFormulaire>();
            int i = 0;
            while (i < nombreZones) 
            {
                ZonesFormulaire zone = new ZonesFormulaire("Zone_" + (i + 1));
                listeZones.Add(zone);
                i++;
            }
            return listeZones;
        }

        public List<ChampsFormulaire> creationChamps(List<ZonesFormulaire> zones)
        {
            List<ChampsFormulaire> listeChamps = new List<ChampsFormulaire>();

            //Pour chaques zones, l'utilisateur ajoute des champs 
            foreach (ZonesFormulaire zone in zones)
            {
                //Récupération du choix utilisateur pour la création des champs
                Console.WriteLine("Pour la " + zone.codeZone +" combien de champs voulez vous ?"); 
                int nombreChamps = Int32.Parse(Console.ReadLine()); 

                //Pour chaques champs souhaités, récupération des choix utilisateur
                int y = 0;
                while (y < nombreChamps) 
                {
                    ChampsFormulaire champs = new ChampsFormulaire();

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

        public string creationFormulaire(Formulaire formulaire)
        {
            //Mise en place du formulaire 
            formulaire.html = $"<h1 style='text-align : center;'> {formulaire.libelle} </h1>";

            //Création au format HTML de chaques zones
            foreach (ZonesFormulaire Unezone in formulaire.zones)  
            {
                formulaire.html += $"<div id='{Unezone.codeZone}'>";

                //Récupération des champs associé à la zone
                List<ChampsFormulaire> champs = formulaire.champs.Where(item => item.codeZone == Unezone.codeZone).ToList();

                //Création au format HTML de chaques champs dans la zone
                foreach (ChampsFormulaire unChamps in champs)
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
            return formulaire.html;
        }
    }  
}
