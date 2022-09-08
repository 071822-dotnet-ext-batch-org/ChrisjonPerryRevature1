using System;
namespace ReimbursementModels
{
    public class RegisterationDto
    {
        public RegisterationDto()
        {

        }

        public RegisterationDto(Guid employeeIDstring, string fristName, object lastName, string email, string password)
        {

            EmployeeIDstring=employeeIDstring;
            FristName = fristName;
            LastName = lastName;
            Email = email;
            Password = password;
        }
        public Guid EmployeeIDstring { get; set; } =Guid.NewGuid();
        public string FristName { get; set; }
        public object LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

}

