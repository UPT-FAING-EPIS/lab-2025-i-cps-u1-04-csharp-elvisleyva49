namespace Payment.Domain
{
    /// <summary>
    /// Defines the payment context that uses a strategy for processing payments.
    /// The context allows the client to choose a payment strategy at runtime and delegates 
    /// the payment process to the selected strategy.
    /// </summary>
    public class PaymentContext
    {
        // The Context has a reference to the Strategy object.
        // The Context does not know the concrete class of a strategy. 
        // It should work with all strategies via the Strategy interface.
        
        private IPaymentStrategy PaymentStrategy;

        /// <summary>
        /// Sets the payment strategy at runtime.
        /// The client can choose which payment method to use by calling this method.
        /// </summary>
        /// <param name="strategy">The payment strategy to use.</param>
        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            PaymentStrategy = strategy;
        }

        /// <summary>
        /// Executes the payment process by delegating the work to the strategy object.
        /// The context does not implement the payment algorithms itself.
        /// </summary>
        /// <param name="amount">The amount to be paid.</param>
        /// <returns><c>true</c> if the payment was successful, otherwise <c>false</c>.</returns>
        public bool Pay(double amount)
        {
            return PaymentStrategy.Pay(amount);
        }
    }
}
