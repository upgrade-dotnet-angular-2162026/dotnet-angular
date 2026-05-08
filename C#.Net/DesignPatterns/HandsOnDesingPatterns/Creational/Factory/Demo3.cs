using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDesingPatterns.Creational.Factory_Demo3
{
    public interface IPaymentGateway
    {
        void ProcessPayment(decimal amount);
    }

    public class PayPalGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} via PayPal");
        }
    }

    public class StripeGateway : IPaymentGateway
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} via Stripe");
        }
    }

    public class PaymentFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string type)
        {
            return type.ToLower() switch
            {
                "paypal" => new PayPalGateway(),
                "stripe" => new StripeGateway(),
                _ => throw new ArgumentException("Invalid payment gateway type")
            };
        }
    }
    class Program
    {
        static void Main()
        {
            IPaymentGateway gateway = PaymentFactory.CreatePaymentGateway("PayPal");
            gateway.ProcessPayment(100.00m);
            gateway = PaymentFactory.CreatePaymentGateway("Stripe");
            gateway.ProcessPayment(200.00m);
        }
    }
}
