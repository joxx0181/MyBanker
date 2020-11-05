using System;
using System.Collections.Generic;
using System.Text;

namespace MyBanker
{
    class Maestro : Debit
    { 
        // parametrized constructor declaration!
        public Maestro (string type, string bal, string loca) : base (type, bal, loca)
        {
 
        }

         public override string ToString()
         {
            return base.ToString();
         }
    }
}
