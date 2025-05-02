namespace Comportamiento.Domain
{
    /// <summary>
    /// Implementación de la estrategia de pago en efectivo.
    /// Esta clase concreta realiza el pago utilizando el método de pago en efectivo.
    /// </summary>
    public class CashPaymentStrategy : IPaymentStrategy
    {
        /// <summary>
        /// Realiza el pago utilizando efectivo.
        /// Este método imprime en la consola el monto del pago realizado en efectivo.
        /// </summary>
        /// <param name="amount">El monto que el cliente desea pagar.</param>
        public void Pay(double amount)
        {
            // Imprime el detalle del pago realizado en efectivo.
            Console.WriteLine("Payment made using cash: " + amount);
        }
    }
}
