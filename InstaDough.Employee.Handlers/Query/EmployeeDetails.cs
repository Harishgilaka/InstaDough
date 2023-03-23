using InstaDough.Core.BusinessManager.Interface;
using InstaDough.Employee.Handlers.QueryResult;

namespace InstaDough.Employee.Handlers.Query
{
    public class EmployeeDetails : IQuery<EmployeeDetailsResult>
    {
        public int Id { get; set; }
    }
}
