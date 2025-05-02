using NUnit.Framework;
using Comportamiento.Domain;

namespace Comportamiento.Tests
{
    public class PaymentTests
    {
        // Prueba para el pago usando Efectivo (PaymentType = 1)
        [TestCase(1, 1000)]
        public void GivenCashPayment_WhenProcessPayment_ThenPaymentIsProcessed(int paymentType, double amount)
        {
            var context = new PaymentContext();

            if (paymentType == 1)
                context.SetPaymentStrategy(new CashPaymentStrategy());

            Assert.DoesNotThrow(() => context.ProcessPayment(amount));
        }

        // Prueba para el pago usando Tarjeta de Crédito (PaymentType = 2)
        [TestCase(2, 2000)]
        public void GivenCreditCardPayment_WhenProcessPayment_ThenPaymentIsProcessed(int paymentType, double amount)
        {
            var context = new PaymentContext();

            if (paymentType == 2)
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());

            Assert.DoesNotThrow(() => context.ProcessPayment(amount));
        }

        // Prueba para el pago usando Tarjeta de Débito (PaymentType = 3)
        [TestCase(3, 3000)]
        public void GivenDebitCardPayment_WhenProcessPayment_ThenPaymentIsProcessed(int paymentType, double amount)
        {
            var context = new PaymentContext();

            if (paymentType == 3)
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());

            Assert.DoesNotThrow(() => context.ProcessPayment(amount));
        }

        // Prueba para un tipo de pago inválido
        [TestCase(4, 4000)]
        public void GivenAnInvalidPaymentType_WhenProcessPayment_ThrowsArgumentException(int paymentType, double amount)
        {
            var context = new PaymentContext();

            Assert.Throws<ArgumentException>(() => context.ProcessPayment(amount));
        }
    }
}
