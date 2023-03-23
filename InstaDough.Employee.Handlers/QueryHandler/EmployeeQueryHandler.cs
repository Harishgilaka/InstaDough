using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.Query;
using InstaDough.Employee.Handlers.QueryResult;
using InstaDough.Repository;

namespace InstaDough.Employee.Handlers.QueryHandler
{
    public class EmployeeQueryHandler : IQueryHandler<EmployeeQuery, IEnumerable<EmployeeResult>>
    {
        public IEnumerable<EmployeeResult> Execute(EmployeeQuery query)
        {
            var resp = RepositoryFactory.GetInstance<InstaDough.Repository.Models.Employee>().GetAll();
            return (from rep in resp
                    select new EmployeeResult()
                    {
                        Id = rep.Id,
                        FirstName = rep.FirstName,
                        LastName = rep.LastName,
                        ContactNumber = rep.ContactNumber,
                        EmailId = rep.EmailId,
                    }).ToList();
        }
    }
}
