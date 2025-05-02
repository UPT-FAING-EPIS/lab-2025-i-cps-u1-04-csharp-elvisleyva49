namespace Payment.Domain
{
    /// <summary>
    /// Represents a payment strategy that handles credit card payments.
    /// Implements the <see cref="IPaymentStrategy"/> interface.
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Executes the payment process for credit card payment.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns>Returns <c>true</c> to indicate the payment was successful.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Credit Card");
            return true;
        }
    }
}
