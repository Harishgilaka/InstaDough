using InstaDough.Repository.Models;
using InstaDough.Repository.Repository;

namespace InstaDough.Repository
{
    public class RepositoryConfig
    {
        public static void RegisterCompnents()
        {
            RepositoryFactory.Register<Employee>(new EmployeeRepository());
        }
    }
}
