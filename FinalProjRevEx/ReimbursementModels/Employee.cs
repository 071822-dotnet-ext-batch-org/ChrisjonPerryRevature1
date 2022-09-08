using System;
namespace ReimbursementModels
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(Guid employeeID, string fristName, object lastName, bool isManager, string email, string password)
        {
            EmployeeID = employeeID;
            FristName = fristName;
            LastName = lastName;
            this.isManager = isManager;
            Email = email;
            Password = password;
        }

        public Guid EmployeeID { get; set; } 
        public string FristName { get; set; }
        public object LastName { get; set; }
        public bool isManager { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

