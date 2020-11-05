using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;

namespace MyBanker
{
   class Mastercard : Credit
    {
        // parametrized constructor declaration!
        public Mastercard (string type, string bal, string maxD, string rating, int credit) : base (type, bal, maxD, rating, credit)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    }
}
