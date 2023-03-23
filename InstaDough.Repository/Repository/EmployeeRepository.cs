using InstaDough.Core.Repository;
using InstaDough.Repository.Models;
using System.Linq.Expressions;

namespace InstaDough.Repository.Repository
{
    public class EmployeeRepository : DBContext, IRepository<Employee>
    {
        public bool Create(Employee entity)
        {
            using (var connection = new EmployeeInstaDoughContext(_ActiveConnection.Options))
            {
                connection.Employees.Add(entity);
                return connection.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GelAllWith(object param)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GelAllWith(Expression<Func<Employee, bool>> Expression)
        {
            using (var connection = new EmployeeInstaDoughContext(_ActiveConnection.Options))
            {
                return connection.Employees.Where(Expression).ToList();
            }
        }

        public IEnumerable<Employee> GetAll()
        {
            using (var connection = new EmployeeInstaDoughContext(_ActiveConnection.Options))
            {
                return connection.Employees.ToList();
            }
        }

        public bool Update(Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
