using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    // This class represents credit!
    class Credit : ATMcard
    {
        // parametrized constructor declaration!
        public Credit (string type, string bal, string maxD, string rating, int credit) : base(type, bal)
        {
            // initialization!
            MaxDay = maxD;
            CreditRating = rating;
            CreditLimitMdr = credit;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public string MaxDay { get; set; }
        public string CreditRating { get; set; }
        public int CreditLimitMdr { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\ncredit rating: " + CreditRating + "\nmax amount: " + MaxDay + "\ncredit limit (DKK) pr. mdr: " + CreditLimitMdr;
        }
    }
}
