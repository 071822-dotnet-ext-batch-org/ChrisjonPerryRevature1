using System;
namespace ReimModelsLayer
{
    public class Request
    {
        public Guid RequestID { get; set; }
        public Guid FK_EmployeeID { get; set; }
        public string Details { get; set; }
        public double Amount { get; set; }
        public int Status { get; set; }

        public Request(Guid requestid,Guid fk_employeeid,string details,double amonut,int status)
        {
            RequestID = requestid;
            FK_EmployeeID = fk_employeeid;
            Details = details;
            Amount = amonut;
            Status = status;

            /*insert employees
             * insert into employees () 
             * 
             */

        }
    }
}

