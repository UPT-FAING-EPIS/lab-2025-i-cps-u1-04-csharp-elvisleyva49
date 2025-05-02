namespace Comportamiento.Domain
{
    /// <summary>
    /// Interfaz que define el contrato para las estrategias de pago.
    /// Cualquier clase que implemente esta interfaz debe proporcionar una implementación
    /// para el método <see cref="Pay"/> que permite realizar un pago.
    /// </summary>
    public interface IPaymentStrategy
    {
        /// <summary>
        /// Método que define cómo se realiza un pago utilizando una estrategia concreta.
        /// Este método debe ser implementado por todas las clases que implementen
        /// la interfaz <see cref="IPaymentStrategy"/>.
        /// </summary>
        /// <param name="amount">El monto que el cliente desea pagar.</param>
        void Pay(double amount);
    }
}
