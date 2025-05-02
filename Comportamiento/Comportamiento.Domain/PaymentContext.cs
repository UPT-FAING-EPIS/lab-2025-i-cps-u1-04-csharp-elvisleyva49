namespace Comportamiento.Domain
{
    /// <summary>
    /// Clase que representa el contexto en el que se utilizará una estrategia de pago.
    /// Esta clase delega el procesamiento del pago a la estrategia de pago proporcionada.
    /// </summary>
    public class PaymentContext
    {
        // Referencia a la estrategia de pago seleccionada
        private IPaymentStrategy _paymentStrategy;

        /// <summary>
        /// Establece la estrategia de pago a utilizar en el contexto.
        /// Este método permite cambiar la estrategia en tiempo de ejecución.
        /// </summary>
        /// <param name="paymentStrategy">La estrategia de pago a usar.</param>
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        /// <summary>
        /// Procesa el pago utilizando la estrategia de pago previamente seleccionada.
        /// Si no se ha establecido una estrategia de pago, se lanza una excepción.
        /// </summary>
        /// <param name="amount">El monto que se desea pagar.</param>
        /// <exception cref="ArgumentException">Se lanza si la estrategia de pago es nula.</exception>
        public void ProcessPayment(double amount)
        {
            // Verifica si la estrategia de pago es nula
            if (_paymentStrategy == null)
            {
                throw new ArgumentException("Invalid payment strategy.");
            }

            // Delegar el pago a la estrategia seleccionada
            _paymentStrategy.Pay(amount);
        }
    }
}
