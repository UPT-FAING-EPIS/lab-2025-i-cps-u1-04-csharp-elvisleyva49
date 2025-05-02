namespace Comportamiento.Domain
{
    /// <summary>
    /// Implementación de la estrategia de pago con tarjeta de débito.
    /// Esta clase concreta realiza el pago utilizando el método de pago con tarjeta de débito.
    /// </summary>
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando tarjeta de débito.
        /// Este método imprime en la consola el monto del pago realizado con tarjeta de débito.
        /// </summary>
        /// <param name="amount">El monto que el cliente desea pagar.</param>
        public void Pay(double amount)
        {
            // Imprime el detalle del pago realizado con tarjeta de débito.
            Console.WriteLine("Payment made using debit card: " + amount);
        }
    }
}
