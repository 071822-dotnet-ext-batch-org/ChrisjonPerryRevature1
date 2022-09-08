namespace ReimModelsLayer;
public class Employee
{
    public Guid EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool isManager { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Employee()
    {

    }
    public Employee(Guid emplpoyeeID,string firstname, string lastname, bool manager,string email, string passw)
    {
        EmployeeID = emplpoyeeID;
        FirstName = firstname;
        LastName = lastname;
        isManager = manager;
        Email = email;
        Password = passw;
    }
}

