using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Maestro : ATMcard 
    { 
        // parametrized constructor declaration!
        public Maestro (string type, string bal, string loca) : base (type, bal)
        {
        // initialization!
        location = loca;
        }

         // auto implemented properties with get & set accessor  -  Encapsulation!
         public string location { get; set; }

         public override string ToString()
         {
            return base.ToString() + "\nthis card can be use: " + location;
         }
    }
}
