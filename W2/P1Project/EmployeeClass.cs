using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Project
{
    public class EmployeeClass
    {
///////////Employee fields or properties/////////////////////////////////////////////////////
        //Employee Name
        public string EmployeeName { get; set; }

      

        //Employee Password
        private string _employeePassword;
       
        public string EmployeePassword
        {
            get { return  _employeePassword; }
            set {  _employeePassword = value; }
        }
        
        //Employee Address
        
        
        //Employee Email
        public string  EmployeeEmail { get; set; }
        //Employee Birthday 
        public int EmployeeBirthday { get; set; }
        //Employee phone # 
       
        
        //EmployeeId #
        private int _employeeId;
       public int EmployeeId 
        {
            get { return  _employeeId; }
            set {  _employeeId = value; }
        }  

        //UserName
        public string UserAname { get; set; }
        // AmountToReimburse(Requested)
        public int AmountToReimburse { get; set; }

        
    }
}