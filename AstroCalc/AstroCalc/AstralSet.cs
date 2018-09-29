using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroCalc
{
    public class AstralSet
    {
        public Dictionary<string, Planet> Planets;
        public Dictionary<string, House> Houses;
        public Dictionary<string, Aspect> Aspects;

        public AstralSet()
        {
            Planets = new Dictionary<string, Planet>();
            Houses = new Dictionary<string, House>();
            Aspects = new Dictionary<string, Aspect>();
        }
    }
}
