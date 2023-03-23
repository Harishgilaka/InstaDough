using InstaDough.Core.BusinessManager;
using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.Command;
using InstaDough.Employee.Handlers.CommandHandler;
using InstaDough.Employee.Handlers.Query;
using InstaDough.Employee.Handlers.QueryHandler;
using InstaDough.Employee.Handlers.QueryResult;

namespace InstaDough.Employee.Web.API.App_Start
{
    public static class DispatcherConfig
    {
        public static IDispatcher RegisterComponents()
        {
            var dispatcher = new Dispatcher();
            dispatcher.Register<EmployeeCommand>(new EmployeeCommandHandler());
            dispatcher.Register<EmployeeQuery, IEnumerable<EmployeeResult>>(new EmployeeQueryHandler());
            dispatcher.Register<EmployeeDetails, EmployeeDetailsResult>(new EmployeeDetailsHandler());
            return dispatcher;
        }
    }
}
