using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Project
{

        

    public class RegisterUser
    {
      public List<string> EmpUserName = new List<string>();
        public List<string> EmpPassword= new List<string>();
        public List<string> EmpEmail= new List<string>();
         public List<string> ManagerUserName = new List<string>();
          public List<string> ManagerPassword = new List<string>();
          public List<int> ReimbursmentAmount = new List<int>();
        

        public  void SetUpUser(){
        EmployeeClass emp1 = new EmployeeClass();
        System.Console.WriteLine("Please enter a Username");
        emp1.UserAname=Console.ReadLine();
        EmpUserName.Add(emp1.UserAname);
        System.Console.WriteLine("Please enter email");
        emp1.EmployeeEmail =Console.ReadLine();
        EmpEmail.Add(emp1.EmployeeEmail);
        System.Console.WriteLine("Please enter a password");
        emp1.EmployeePassword = Console.ReadLine();
        EmpPassword.Add( emp1.EmployeePassword);
        
      }
      public void SetupManager(){
        ManagerClass mnger1 = new ManagerClass();
        System.Console.WriteLine("Please enter a Username");
        mnger1.ManagerName=Console.ReadLine();
        ManagerUserName.Add(mnger1.ManagerName);
        System.Console.WriteLine("Please enter a password");
        mnger1.ManagerPassword = Console.ReadLine();
         ManagerPassword.Add( mnger1.ManagerPassword);
      }//endofM

      public void Getimbursement(){
      System.Console.WriteLine("Please enter an amount for Reimbursement");
       int MoneyAmount =Console.Read();
       ReimbursmentAmount.Add(MoneyAmount);
        
       System.Console.WriteLine("Please select a reason for Reimbursement type Traval for travel expenses \nSoftware/hardware for Software/hardware cost \nor therapy for therapy cost");
       
       var reason =Console.ReadLine();
      
        if(string.IsNullOrEmpty(reason)){
          System.Console.WriteLine("Please enter valid reason");
        } 
        else {System.Console.WriteLine($"Your reson is{reason}");}
        }

        public void ViewClaims(){
      System.Console.WriteLine("Hello welcome too claims");
      //display the list of claims claims 
        
        }

        public void approveClaim(){
          //prompt 
        }
        }
}//endofnamespace
