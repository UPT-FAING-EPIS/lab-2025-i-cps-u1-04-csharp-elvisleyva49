namespace ATM.Domain
{
    /// <summary>
    /// Represents an Automated Teller Machine (ATM) that executes commands.
    /// </summary>
    public class ATM
    {
        private ICommand _command;

        /// <summary>
        /// Initializes a new instance of the <see cref="ATM"/> class with a specified command.
        /// </summary>
        /// <param name="command">The command to be executed by the ATM.</param>
        public ATM(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Executes the assigned command.
        /// </summary>
        public void Action()
        {
            _command.Execute();
        }
    }
}
