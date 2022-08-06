using System;

namespace P1Project
{
    class Program
    {
        static void Main(string[] args)
        {
/////////////////////////Welcome Message ///////////////////////////////////////////
        System.Console.WriteLine("Welcome to The expense reimbursement system");

/// /////Prompts user to enter a E for new user or P for returning user must type valid input ////////////// 

        System.Console.WriteLine("Please enter E for employee or M for manager");
        string isEmpOrMng = Console.ReadLine();
        //Checks if user is an Employee or a manger
        if (isEmpOrMng.Contains("E" )||isEmpOrMng.Contains("e")){
            System.Console.WriteLine("Welcome valued new employee!");
            RegisterUser newEmp = new RegisterUser();
            newEmp.SetUpUser();
            newEmp.Getimbursement(); 
            }
        
        if (isEmpOrMng.Contains("m")||isEmpOrMng.Contains("M")){
        
        System.Console.WriteLine("Welcome new manger");
       RegisterUser newmng = new RegisterUser();
        newmng.SetupManager();
        }
       
        }
    }
}