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

        System.Console.WriteLine("Please enter E to register as an employee or M as a manager \nor type R to login as an employee or N to login as a manager.");
        RegisterUser reg = new RegisterUser ();
        string isEmpOrMng = Console.ReadLine();
        //Checks if user is an Employee or a manger
       if(isEmpOrMng.Contains("E")||isEmpOrMng.Contains("e")){
        reg.SetUpUser();
       }
         
         if(isEmpOrMng.Contains("R")||isEmpOrMng.Contains("r")){
        reg.LoginEmp();
        System.Console.WriteLine("Please type 1 to view Reimburment claims or 2 make a claim");
        var userInput = Console.ReadLine();
        if(userInput.Contains("1")){
          reg.ViewClaims();
        } else if (userInput.Contains("2"))
        {
          reg.Getimbursement();
        }
       }
        
         if(isEmpOrMng.Contains("M")||isEmpOrMng.Contains("m")){
        reg.SetupManager();
        reg.ViewClaims();
        reg.approveClaim();

       }
        if(isEmpOrMng.Contains("N")||isEmpOrMng.Contains("n")){
        reg.SetupManager();
        reg.ViewClaims();
        reg.approveClaim();
        
       }
       else {
        System.Console.WriteLine("Please enter a valid entry");
       }
       
        }
    }
}

