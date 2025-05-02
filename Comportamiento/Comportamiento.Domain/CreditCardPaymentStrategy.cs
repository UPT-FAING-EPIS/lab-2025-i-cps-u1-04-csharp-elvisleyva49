namespace Comportamiento.Domain
{
    /// <summary>
    /// Implementación de la estrategia de pago con tarjeta de crédito.
    /// Esta clase concreta realiza el pago utilizando el método de pago con tarjeta de crédito.
    /// </summary>
    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando tarjeta de crédito.
        /// Este método imprime en la consola el monto del pago realizado con tarjeta de crédito.
        /// </summary>
        /// <param name="amount">El monto que el cliente desea pagar.</param>
        public void Pay(double amount)
        {
            // Imprime el detalle del pago realizado con tarjeta de crédito.
            Console.WriteLine("Payment made using credit card: " + amount);
        }
    }
}
