using NUnit.Framework;

namespace ATM.Domain.Tests
{
    /// <summary>
    /// Contains unit tests for the <see cref="ATM"/> operations using deposit and withdraw commands.
    /// </summary>
    public class ATMTests
    {
        /// <summary>
        /// Tests that withdrawing from an account updates the balance correctly.
        /// </summary>
        [Test]
        public void GivenAccountAndWithdraw_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 300 };
            decimal amount = 100;
            var withdraw = new WithdrawCommand(account, amount);
            new ATM(withdraw).Action();
            Assert.That(account.AccountBalance.Equals(200));
        }

        /// <summary>
        /// Tests that depositing into an account updates the balance correctly.
        /// </summary>
        [Test]
        public void GivenAccountAndDeposit_ThenExecute_ReturnsCorrectAmount()
        {
            var account = new Account() { AccountBalance = 200 };
            decimal amount = 100;
            var deposit = new DepositCommand(account, amount);
            new ATM(deposit).Action();
            Assert.That(account.AccountBalance.Equals(300));
        }
    }
}
