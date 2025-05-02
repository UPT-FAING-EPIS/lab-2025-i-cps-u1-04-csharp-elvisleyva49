namespace Payment.Domain
{
    /// <summary>
    /// Defines the contract for payment strategies.
    /// Any payment method must implement this interface to define its specific payment behavior.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Executes the payment process.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns>Returns <c>true</c> if the payment was successful, otherwise <c>false</c>.</returns>
        bool Pay(double amount);
    }
}
