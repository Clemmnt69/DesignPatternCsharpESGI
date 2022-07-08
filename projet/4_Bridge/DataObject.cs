using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Bridge
{
    public abstract class DataObject
    {
		public abstract List<Zones> CreeZonesData(int nombreZones);
		public abstract List<Champs> CreeChampsData(List<Zones> listeZones);
		public abstract string CreeHTMLData(Formulaire formulaire);
        public abstract void AfficherData(Formulaire formulaire);
    }
}