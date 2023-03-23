namespace InstaDough.Core.BusinessManager.Interface
{
    public interface ICommandDispatcher
    {
        void Dispatch<TCommand>(TCommand command)
            where TCommand : ICommand;
    }
}
