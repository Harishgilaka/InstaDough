using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.Command;
using InstaDough.Repository;

namespace InstaDough.Employee.Handlers.CommandHandler
{
    public class EmployeeCommandHandler : ICommandHandler<EmployeeCommand>
    {
        public void Execute(EmployeeCommand command)
        {
            RepositoryFactory.GetInstance<InstaDough.Repository.Models.Employee>().Create(new Repository.Models.Employee()
            {
              FirstName = command.FirstName,
              ContactNumber = command.ContactNumber,
              EmailId = command.EmailId,
              LastName = command.LastName
            });
        }
    }
}
