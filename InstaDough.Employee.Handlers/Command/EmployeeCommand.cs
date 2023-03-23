using InstaDough.Core.BusinessManager.Interface;

namespace InstaDough.Employee.Handlers.Command
{
    public class EmployeeCommand : ICommand
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int? ContactNumber { get; set; }

        public string? EmailId { get; set; }
    }
}
