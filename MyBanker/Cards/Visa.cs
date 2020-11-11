using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    // This class represents visa!
    class Visa : Credit
    {
        // parametrized constructor declaration!
        public Visa (string type, string bal, string maxD, string rating, int credit, int overD) : base(type, bal, maxD, rating, credit)
        {
            // initialization!
            OverDraw = overD;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public int OverDraw { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nallowed overdraw: " + OverDraw;
        }
    }
}
