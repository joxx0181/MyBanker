using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Electron : Debit
    {
        // parametrized constructor declaration!
        public Electron (string type, string bal, string loca, int debit) : base(type, bal, loca)
        {
            // initialization!
            DebitLimitMdr = debit;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public int DebitLimitMdr { get; set; }
        public override string ToString()
        {
            return base.ToString() + "\nthis card have a debit limit (DKK) pr. mdr.: " + DebitLimitMdr;
        }
}
