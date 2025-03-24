using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabish_Radical_Sept_24.Design_Patterns.Creational
{
   interface Ipayment
    {
        void MakePayment();
    }
    class CreditCard : Ipayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment done using Credit Card");
        }
    }
    class DebitCard : Ipayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment done using Debit Card");
        }
    }
    class NetBanking : Ipayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment done using Net Banking");
        }
    }
    class PaymentFactory
    {
        public Ipayment GetPaymentMethod(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "CreditCard":
                    return new CreditCard();
                case "DebitCard":
                    return new DebitCard();
                case "NetBanking":
                    return new NetBanking();
                default:
                    throw new Exception("Invalid Payment Method");
            }
        }
    }
    class FactoryDemo
    {
        public static void Main()
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            Ipayment payment = paymentFactory.GetPaymentMethod("CreditCard");
            payment.MakePayment();
        }
    }   
}
