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
      public List<string> ReasonForImbursement = new List<string>();

      
     
      
        
        //gets user credentials and adds it to list
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
      //registers manager
      public void SetupManager(){
        ManagerClass mnger1 = new ManagerClass();
        System.Console.WriteLine("Please enter a Username");
        mnger1.ManagerName=Console.ReadLine();
        ManagerUserName.Add(mnger1.ManagerName);
        System.Console.WriteLine("Please enter a password");
        mnger1.ManagerPassword = Console.ReadLine();
         ManagerPassword.Add( mnger1.ManagerPassword);
      }//endofM

        // logs in a returning employee
        public void LoginEmp(){
        System.Console.WriteLine("Please enter a username returning employee");
        var userName = Console.ReadLine();
       System.Console.WriteLine($"welcome back {userName}");
       }
        

      // logs in a returning manager
      public void loginMAn(){
        System.Console.WriteLine("Please enter a username returning manager");
        var ManagerUserName = Console.ReadLine();
        System.Console.WriteLine($"Welcome back{ManagerUserName}");
      }
      


      public void Getimbursement(){
      Claimsclass claims = new Claimsclass();
      System.Console.WriteLine("Please enter an amount for Reimbursement");
       int MoneyAmount =Console.Read();
       ReimbursmentAmount.Add(MoneyAmount);
        
       System.Console.WriteLine("Please select a reason for Reimbursement");
       var reason =Console.ReadLine();
       System.Console.WriteLine($"The reason for reimbursement is{reason}");
       ReasonForImbursement.Add(reason);

      }
      

        public void ViewClaims(){
      System.Console.WriteLine("Hello welcome too claims");
      
      //display the list of claims claims
     
     for (int i = 0; i < ReimbursmentAmount.Count; i++)
     {
      System.Console.WriteLine(ReimbursmentAmount[i]);
     }
      
        
        }

        // allows manager to approve or deny a claim
        public void approveClaim(){
          //display claims
          for (int i = 0; i < ReimbursmentAmount.Count; i++)
     {
       System.Console.WriteLine("Please review each claim and choose which one you want to approve or deny.");
          System.Console.WriteLine(ReimbursmentAmount[i]);
     }
         
        }
        }
}
