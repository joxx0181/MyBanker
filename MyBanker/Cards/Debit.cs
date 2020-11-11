using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    // This class represents debit!
    class Debit : ATMcard
    {
        // parametrized constructor declaration!
        public Debit (string type, string bal, string loca) : base(type, bal)
        {
            // initialization!
            Location = loca;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public string Location { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\nthis card can be use: " + Location;
        }
    }
}
