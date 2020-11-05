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
            CardType = type;
            Balance = bal;
        }

        // auto implemented properties with get & set accessor  -  Encapsulation!
        public string CardType { get; set; }
        public string Balance { get;  set; }

        public override string ToString()
        {
            return "cardtype: " + CardType + "\nbalance calulated: " + Balance;
        }
    }
}
