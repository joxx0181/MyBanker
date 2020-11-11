using System;
using System.Linq;

namespace MyBanker
{
    // factory class!
    public class CardFactory : ICardNumber, IExpire
    {
        // return the required objects!
        public PaymentCard CreateCardSkill(string skill)
        {
            switch (skill)
            {
                case "atm": return new ATMcard("ATM debitcard", "immediately");
                case "maestro": return new Maestro("Maestro debitcard", "immediately", "internationally and online");
                case "electron": return new Electron("Electron debitcard", "immediately", "internationally and online", 10000);
                case "mastercard": return new Mastercard("Mastercard creditcard", "monthly", "withdraw up tp 5000 DKK a day", "need approved for credit", 40000);
                case "visa": return new Visa("Visa creditcard", "daily", "-", "need approved for credit", 25000, 5000);
                default:
                    return null;
            }
        }

        // The body of interface methods is provided here!
        public string GetCardNumber(string prefix)
        {
            Random randNum = new Random();

            string num = "0123456789";

            switch (prefix)
            {
                case "p1":
                    prefix = "2400";
                    break;
                case "p2":
                    Random p2rand = new Random();
                    string[] p2 = new string[] { "5018", "5020", "5038", "5893", "6304", "6759", "6761", "6762", "6763" };
                    for (int i = 0; i < 1; i++)
                    {
                        int rand = p2rand.Next(0, p2.Length);
                        prefix = p2[rand];
                    }
                    break;
                case "p3":
                    Random p3rand = new Random();
                    string[] p3 = new string[] { "4026", "417500", "4508", "4844", "4913", "4917" };
                    for (int i = 0; i < 1; i++)
                    {
                        int rand = p3rand.Next(0, p3.Length);
                        prefix = p3[rand];
                    }
                    break;
                case "p4":
                    Random p4rand = new Random();
                    string[] p4 = new string[] { "51", "52", "53", "54", "55" };
                    for (int i = 0; i < 1; i++)
                    {
                        int rand = p4rand.Next(0, p4.Length);
                        prefix = p4[rand];
                    }
                    break;
                case "p5":
                    prefix = "4";
                    break;
                default:
                    break;
            }
            int cardLenght = 0;
            if (prefix.Length == 1) { cardLenght = 15; }
            if (prefix.Length == 2) { cardLenght = 14; }
            if (prefix.Length == 4) { cardLenght = 12; }
            if (prefix.Length == 6) { cardLenght = 10; }

            string result = prefix + " ";
            string result2 = "3520" + " ";

            for (int i = 0; i < cardLenght; i++)
            {
                int numb = randNum.Next(num.Length);
                result = result + num.ElementAt(numb);
            }
            for (int j = 0; j < 10; j++)
            {
                int numb2 = randNum.Next(num.Length);
                result2 = result2 + num.ElementAt(numb2);
            }
            return "\ncartnumber: " + result + "\naccountnumber: " + result2 + "\n";
        }
        public string GetExpire(string expire)
        {
            switch (expire)
            {
                case "ex1": 
                    expire = "no expire";
                    break;
                case "ex2":
                    expire = "expires in 5 years og 8 months";
                    break;
                case "ex3":
                    expire = "expires before it reaches 5 years";
                    break;
                default:
                    break;
            }
            return "info: " + expire;
        }
    }
}

