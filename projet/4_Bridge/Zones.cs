using System;
using System.Collections.Generic;
using System.Linq;

namespace _4_Bridge
{
    public class Zones
	{
		public string codeZone;
		public List<Champs> champs;

		public Zones(string codeZone)
		{
			this.codeZone = codeZone;
		}
	}
}