
namespace InstaDough.Core.BusinessManager.Interface
{
    public interface IDispatcher
    {
        void Execute<TCommand>(TCommand command)
            where TCommand : ICommand;

        TResult Execute<TQuery, TResult>(TQuery query)
            where TQuery : IQuery<TResult>;

        void Register<TCommand>(ICommandHandler<TCommand> command)
            where TCommand : ICommand;

        void Register<TQuery, TResult>(IQueryHandler<TQuery, TResult> query)
            where TQuery : IQuery<TResult>;

    }
}
