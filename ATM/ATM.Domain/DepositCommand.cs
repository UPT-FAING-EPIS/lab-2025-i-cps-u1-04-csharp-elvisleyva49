namespace ATM.Domain
{
    /// <summary>
    /// Represents a deposit operation command for an account.
    /// </summary>
    public class DepositCommand : ICommand
    {
        private Account _account;
        private decimal _amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="DepositCommand"/> class.
        /// </summary>
        /// <param name="account">The account where the deposit will be made.</param>
        /// <param name="amount">The amount to deposit.</param>
        public DepositCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Executes the deposit operation on the associated account.
        /// </summary>
        public void Execute()
        {
            _account.Deposit(_amount);
        }        
    }
}
