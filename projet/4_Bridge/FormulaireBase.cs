using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Bridge
{
    public class FormulaireBase
    {
        private DataObject dataObject;

        public DataObject Data
        {
            set { dataObject = value; }
            get { return dataObject; }
        }
        
        public virtual List<Zones> CreeZones(int nombreZones)
        {
            return dataObject.CreeZonesData(nombreZones);
        }
        
        public virtual List<Champs> CreeChamps(List<Zones> listeZones)
        {
            return dataObject.CreeChampsData(listeZones);
        }
        
        public virtual string CreeHTML(Formulaire formulaire)
        {
            return dataObject.CreeHTMLData(formulaire);
        }

        public virtual void Afficher(Formulaire formulaire)
        {
            dataObject.AfficherData(formulaire);
        }
    }
}

