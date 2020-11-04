using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace MyBanker
{
    class Mastercard : ATMcard
    {
        // parametrized constructor declaration!
        public Mastercard (string type, string bal, string maxD, string rating, int credit) : base (type, bal)
        {
            // initialization!
            maxDay = maxD;
            creditRating = rating;
            creditLimitMdr = credit;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public string maxDay { get; set; }
        public string creditRating { get; set; }
        public int creditLimitMdr { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\ncredit rating: " + creditRating + "\nmax amount: " + maxDay + "\ncredit limit (DKK) pr. mdr: " + creditLimitMdr;
        }
    }
}
