using InstaDough.Repository.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InstaDough.Repository
{
    public class DBContext : IDBContext
    {
        SqlConnection? _sqlConnection;
        public static DbContextOptionsBuilder<EmployeeInstaDoughContext>? _ActiveConnection;
        public void LoadGlobalConnection()
        {
            var configuation = GetConfiguration();
            _sqlConnection = new SqlConnection(configuation.GetSection("ConnectionStrings").GetSection("EmployeeInstaDoughContext").Value);
            var optionsBuilder = new DbContextOptionsBuilder<EmployeeInstaDoughContext>();
            optionsBuilder.UseSqlServer(_sqlConnection.ConnectionString);
            _ActiveConnection = optionsBuilder;
        }

        public IConfigurationRoot GetConfiguration()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            return configuration.Build();
        }
    }
}
