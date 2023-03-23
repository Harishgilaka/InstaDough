using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.Query;
using InstaDough.Employee.Handlers.QueryResult;
using InstaDough.Repository;

namespace InstaDough.Employee.Handlers.QueryHandler
{
    public class EmployeeDetailsHandler : IQueryHandler<EmployeeDetails, EmployeeDetailsResult>
    {
        public EmployeeDetailsResult Execute(EmployeeDetails query)
        {
            var obj = RepositoryFactory.GetInstance<InstaDough.Repository.Models.Employee>().GelAllWith(x => x.Id == query.Id).FirstOrDefault();
            return new EmployeeDetailsResult()
            {
                Id = obj.Id,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                ContactNumber = obj.ContactNumber,
                EmailId = obj.EmailId
            };
        }
    }
}
