using System;
using Models;
using businessLayer;
namespace Pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppLib appliclib = new AppLib();
           System.Console.WriteLine("Welcome to the reimbursement system ");
           System.Console.WriteLine("Please enter a username and password");
           bool doesUserexist =  appliclib.login(Console.ReadLine(),Console.ReadLine());
           if(doesUserexist){
            System.Console.WriteLine($"welcome back{appliclib.user.Myname}");
           }
            else{
                System.Console.WriteLine("Hello you must be new let's get you set up \nplease enter a username password and your name");
            appliclib.registeruser(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
            System.Console.WriteLine("you are now registered");
            }
            System.Console.WriteLine("Please type an amount to submit a claim");
            Ticket t = new Ticket();
             t.TicketAmount = Console.Read();
            appliclib.maketicket(t);
        }
    }
}
