using System;

namespace ATM.Domain
{
    /// <summary>
    /// Represents a bank account within the ATM system.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// The maximum amount allowed for a single deposit.
        /// </summary>
        public const decimal MAX_INPUT_AMOUNT = 10000;

        /// <summary>
        /// Gets or sets the unique number identifying the account.
        /// </summary>
        public int AccountNumber { get; set; }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public decimal AccountBalance { get; set; }

        /// <summary>
        /// Withdraws a specified amount from the account balance.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        /// <exception cref="ArgumentException">Thrown when the amount exceeds the current balance.</exception>
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance) 
                throw new ArgumentException("The input amount is greater than balance.");
            AccountBalance -= amount;            
        }

        /// <summary>
        /// Deposits a specified amount into the account balance.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        /// <exception cref="ArgumentException">Thrown when the amount exceeds the maximum allowed deposit.</exception>
        public void Deposit(decimal amount)
        {
            if (amount > MAX_INPUT_AMOUNT) 
                throw new ArgumentException("The input amount is greater than maximum allowed.");
            AccountBalance += amount;            
        }
    }
}
