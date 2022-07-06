using System;
using System.Collections.Generic;

namespace _2_Factory
{
    public class ZonesFormulaire
    {
        public string codeZone;
        public List<ChampsFormulaire> champs;

        public ZonesFormulaire(string codeZone)
        {
            this.codeZone = codeZone;
        }
    }  
}
