using System;
using NUnit.Framework;
using Payment.Domain;

namespace Payment.Domain.Tests
{
    /// <summary>
    /// Unit tests for the <see cref="PaymentService"/> class.
    /// The tests validate the functionality of processing payments using different payment methods.
    /// </summary>
    public class PaymentTests
    {
        /// <summary>
        /// Tests if a valid payment type and amount result in a successful payment process.
        /// </summary>
        /// <param name="paymentType">The payment type to be used (1 for CreditCard, 2 for DebitCard, 3 for Cash).</param>
        /// <param name="amount">The amount to be processed.</param>
        [TestCase(1, 1000)]
        [TestCase(2, 2000)]
        [TestCase(3, 3000)]
        public void GivenAValidPaymentTypeAndAmount_WhenProcessPayment_ResultIsSuccesful(int paymentType, double amount)
        {
            bool PaymentResult = new PaymentService().ProcessPayment(paymentType, amount);
            Assert.That(PaymentResult, Is.True);
        }

        /// <summary>
        /// Tests if an invalid payment type results in an error.
        /// </summary>
        /// <param name="paymentType">The invalid payment type.</param>
        /// <param name="amount">The amount to be processed.</param>
        [TestCase(4, 4000)]
        public void GivenAnUnknownPaymentTypeAndAmount_WhenProcessPayment_ResultIsError(int paymentType, double amount)
        {
            var ex = Assert.Throws<ArgumentException>(
                () => new PaymentService().ProcessPayment(paymentType, amount));
            Assert.That(ex.Message, Is.EqualTo("You Select an Invalid Payment Option"));
        }
    }
}
