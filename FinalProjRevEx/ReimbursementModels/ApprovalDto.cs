using System;
namespace ReimbursementModels
{
    public class ApprovalDto
    {
        public ApprovalDto()
        {
        }
        public Guid EmployeeID { get; set; }
        public Guid RequestID { get; set; }
        public int Status { get; set; }
    }

}

