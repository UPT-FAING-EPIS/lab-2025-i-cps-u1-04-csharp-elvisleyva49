namespace ATM.Domain
{
    /// <summary>
    /// Command that performs a withdrawal operation on an account.
    /// </summary>
    public class WithdrawCommand : ICommand
    {
        private Account _account;
        private decimal _amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="WithdrawCommand"/> class.
        /// </summary>
        /// <param name="account">The account from which to withdraw.</param>
        /// <param name="amount">The amount to withdraw.</param>
        public WithdrawCommand(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        /// <summary>
        /// Executes the withdrawal command.
        /// </summary>
        public void Execute()
        {
            _account.Withdraw(_amount);
        }
    }
}
