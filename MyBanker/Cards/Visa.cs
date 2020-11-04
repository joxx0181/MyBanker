using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Visa : Mastercard
    {
        // parametrized constructor declaration!
        public Visa (string type, string bal, string maxD, string rating, int credit, int overD) : base(type, bal, maxD, rating, credit)
        {
            // initialization!
            overDraw = overD;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public int overDraw { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nallowed overdraw: " + overDraw;
        }
    }
}
