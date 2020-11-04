using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Electron : Maestro
    {
        // parametrized constructor declaration!
        public Electron (string type, string bal, string loca, int debit) : base(type, bal, loca)
        {
            // initialization!
            debitLimitMdr = debit;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public int debitLimitMdr { get; set; }
        public override string ToString()
        {
            return base.ToString() + "\nthis card have a debit limit (DKK) pr. mdr.: " + debitLimitMdr;
        }
    }
}
