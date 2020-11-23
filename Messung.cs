using System;
using System.Collections.Generic;
using System.Text;

namespace Blutdruck_Loesung
{
    public class Messung
    {
        public int ObererWert { get; set; }

        public int UntererWert { get; set; }

        public Messung(int untererWert, int obererwert)
        {
            this.UntererWert = obererwert;
            this.ObererWert = untererWert;
        }

    }
}
