namespace Payment.Domain
{
    /// <summary>
    /// Defines the service for processing payments. 
    /// This class utilizes the Strategy pattern to select a payment method 
    /// based on the selected payment type at runtime.
    /// </summary>
    public class PaymentService
    {
        /// <summary>
        /// Processes the payment based on the selected payment type.
        /// It delegates the payment execution to the corresponding strategy 
        /// (CreditCard, DebitCard, or Cash).
        /// </summary>
        /// <param name="SelectedPaymentType">The payment method selected by the user.</param>
        /// <param name="Amount">The amount to be paid.</param>
        /// <returns><c>true</c> if the payment was successfully processed, otherwise <c>false</c>.</returns>
        /// <exception cref="ArgumentException">Thrown when an invalid payment type is selected.</exception>
        public bool ProcessPayment(int SelectedPaymentType, double Amount)
        {
            // Create an Instance of the PaymentContext class
            PaymentContext context = new PaymentContext();
            if (SelectedPaymentType == (int)PaymentType.CreditCard)
            {
                context.SetPaymentStrategy(new CreditCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.DebitCard)
            {
                context.SetPaymentStrategy(new DebitCardPaymentStrategy());
            }
            else if (SelectedPaymentType == (int)PaymentType.Cash)
            {
                context.SetPaymentStrategy(new CashPaymentStrategy());
            }
            else
            {
                throw new ArgumentException("You Select an Invalid Payment Option");
            }
            // Finally, call the Pay Method
            return context.Pay(Amount);
        }
    }

    /// <summary>
    /// Defines the payment types available for processing.
    /// </summary>
    public enum PaymentType
    {
        /// <summary>
        /// CreditCard payment method.
        /// </summary>
        CreditCard = 1,  // 1 for CreditCard

        /// <summary>
        /// DebitCard payment method.
        /// </summary>
        DebitCard = 2,   // 2 for DebitCard

        /// <summary>
        /// Cash payment method.
        /// </summary>
        Cash = 3, // 3 for Cash
    }
}
