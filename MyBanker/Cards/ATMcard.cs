using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

namespace MyBanker
{
    class ATMcard : PaymentCard
    {
        // parametrized constructor declaration!
        public ATMcard (string type, string bal)
        {
            // initialization!
            cardType = type;
            balance = bal;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public string cardType { get; set; }
        public string balance { get;  set; }

        public override string ToString()
        {
            return "cardtype: " + cardType + "\nbalance calulated: " + balance;
        }
    }
}
ø