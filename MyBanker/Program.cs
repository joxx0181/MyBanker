using System;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentCard atmc = new CardFactory().CreateCardSkill("atm");
            PaymentCard elec = new CardFactory().CreateCardSkill("electron");
            PaymentCard maes = new CardFactory().CreateCardSkill("maestro");
            PaymentCard mast = new CardFactory().CreateCardSkill("mastercard");
            PaymentCard visa = new CardFactory().CreateCardSkill("visa");

            string newCard1 = new CardFactory().GetCardNumber("p1");
            string newCard2 = new CardFactory().GetCardNumber("p2");
            string newCard3 = new CardFactory().GetCardNumber("p3");
            string newCard4 = new CardFactory().GetCardNumber("p4");
            string newCard5 = new CardFactory().GetCardNumber("p5");

            string cardExpire1 = new CardFactory().GetExpire("ex1");
            string cardExpire2 = new CardFactory().GetExpire("ex2");
            string cardExpire3 = new CardFactory().GetExpire("ex3");

            Console.WriteLine("Reply for a paymentcard by enter your:");

            Console.Write("fullname: ");
            string userFullName = Console.ReadLine();

            Console.Write("age: ");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);

            Console.WriteLine("\nthe following paymentcard can be issued to you: \n");

            Console.WriteLine(atmc.ToString() + "\n" + "\ncart owner: " + userFullName + newCard1 + "\n" + cardExpire1 + "\n....................................................\n");
            if (age >= 15)
            {
                Console.WriteLine(elec.ToString() + "\n" + "\ncart owner: " + userFullName + newCard3 + cardExpire1 + "\n....................................................\n");
                if (age > 18)
                {
                    Console.WriteLine(maes.ToString() + "\n" + "\ncart owner: " + userFullName + newCard2 + cardExpire2 + "\n....................................................\n");
                    Console.WriteLine(mast.ToString() + "\n" + "\ncart owner: " + userFullName + newCard4 + cardExpire3 + "\n....................................................\n");
                    Console.WriteLine(visa.ToString() + "\n" + "\ncart owner: " + userFullName + newCard5 + cardExpire3 + "\n....................................................\n");
                }
            }
            Console.ReadKey();
        }
    }
}
