using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P1Project
{
    public class RegisterUser
    {
      
      public  void SetUpUser(){
        EmployeeClass emp1 = new EmployeeClass();
        System.Console.WriteLine("Please enter a Username");
        emp1.UserAname=Console.ReadLine();
        System.Console.WriteLine("Please enter a password");
        emp1.EmployeePassword = Console.ReadLine();
        
      }
      public void SetupManager(){
        ManagerClass mnger1 = new ManagerClass();
        System.Console.WriteLine("Please enter a Username");
        mnger1.ManagerName=Console.ReadLine();
        System.Console.WriteLine("Please enter a password");
        mnger1.ManagerPassword = Console.ReadLine();
      }




    }
}