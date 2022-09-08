using System;
namespace ReimbursementModels
{
    public class Request
    {
        public Request()
        {
        }

        public Request(Guid requestID, Guid fK_EmployeeID, string details, decimal amount, int status)
        {
            RequestID = requestID;
            FK_EmployeeID = fK_EmployeeID;
            Details = details;
            Amount = amount;
            Status = status;
        }

        public Guid RequestID { get; set; }
        public Guid FK_EmployeeID { get; set; }
        public string Details { get; set; }
        public decimal Amount { get; set; }
        public int Status { get; set; }
    }

}

