namespace ATM.Domain
{
    /// <summary>
    /// Defines a command interface with an execution method.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Executes the command's action.
        /// </summary>
        void Execute();
    }
}
