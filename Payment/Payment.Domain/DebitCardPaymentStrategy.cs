namespace Payment.Domain
{
    /// <summary>
    /// Represents a payment strategy that handles debit card payments.
    /// Implements the <see cref="IPaymentStrategy"/> interface.
    /// </summary>
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Executes the payment process for debit card payment.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns>Returns <c>true</c> to indicate the payment was successful.</returns>
        public bool Pay(double amount)
        {
            Console.WriteLine("Customer pays Rs " + amount + " using Debit Card");
            return true;
        }
    }
}
