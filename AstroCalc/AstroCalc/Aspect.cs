using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroCalc
{
    public class Aspect
    {
        public string sKey; // As String
        public long Pointer; // As Long
        public int PLId; // As Integer
        public int PlAsp; // As Integer
        public string see; // As String      '* 3
        public int kind; // As Integer
        public float dev; // As Integer
        public string planet1;
        public string planet2;
        public string SRotulo; // As String
        public long SPointer; // As Long
        public string SResult; // As String

        public Aspect(int PL1, int PL2, string see, int kind, float dev)
        {
            this.PLId = PL1;
            this.PlAsp = PL2;
            this.see = see;
            this.kind = kind;
            this.dev = dev;
            this.sKey = "_" + PL1.ToString() + "_" + PL2.ToString();

        }

    }
}
