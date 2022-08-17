using System;
using System.Data.SqlClient;
using System.Net;
using Models;
namespace repolayer
{
    public class adodotnetaccess
    {
     private static readonly SqlConnection conn = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
     
     public Userclass GetUsername(string username){
        if(username == null)
        {
            return null;
        }
        SqlCommand command = new SqlCommand("SELECT * FROM Employees WHERE UserName = @username", conn);
        {
         command.Parameters.AddWithValue("@username",username); 
         conn.Open();
         SqlDataReader ? ret = command.ExecuteReader();
         if(ret.Read())
         {
            Userclass u = new Userclass
            (
            ret.GetString(1),
            ret.GetString(2),
            ret.GetString(3),
            ret.GetGuid(4)    
            );
            conn.Close();
            return u;
            
         }  
         else {
            conn.Close();
            return null;
         }
        }
     }
     public bool Addemployee(Userclass u){
        {

            using(SqlCommand command = new SqlCommand("INSERT INTO Employees (EmployeeID, UserName,empPassword,EmployeeName ) VALUES (@EmployeeID, @UserName, @empPassword, @EmployeeName)",conn))
            {
            if(this.GetUsername(u.Myusername) !=null) return false;
             command.Parameters.AddWithValue("@EmployeeID", u.id );
             command.Parameters.AddWithValue("@UserName", u.Myusername ); 
             command.Parameters.AddWithValue("@empPassword", u.Mypasseord);
             command.Parameters.AddWithValue("@EmployeeName", u.Myname );  
             conn.Open();
             bool ret = (command.ExecuteNonQuery())==1;
             conn.Close();
             return ret;
             }
            }

        }
        public bool AddTicket(Ticket I)
        {
            using(SqlCommand command = new SqlCommand("INSERT INTO Claims(ClaimID, ClaimStatus, Amount) VALUES(@ClaimID, @claimstatus,@Amount)",conn))
            {
            command.Parameters.AddWithValue("@ClaimID", I.TicketID);
            command.Parameters.AddWithValue("@claimstatus", I.TicketAmount);
            command.Parameters.AddWithValue("@Amount", I.TicketAmount);
             bool ret = command.ExecuteNonQuery() ==1;
             conn.Close();
             return ret;
            }

           
        }
       
    //public Userclass Employeecheck(string username, string password)
     //   {
            //string query = "SELECT FirstName, LastName, Wins, Losses FROM Players WHERE FirstName = @x AND Lname = @y";
           // using (SqlCommand command = new SqlCommand($"SELECT Top 1 EmployeeID, UserName, empPassword, EmployeeName FROM Employees WHERE UserName = @UN AND empPassword = @pass", conn))
          //  {
              //  command.Parameters.AddWithValue("@UN", username);
              // command.Parameters.AddWithValue("@pass", password);
               // conn.Open();
               // SqlDataReader? ret = command.ExecuteReader();

              //  if (ret.Read())
              //  {
               //     Userclass emp = new Userclass();
             //       emp.id = ret.GetGuid(0);
               //     emp.Myusername = ret.GetString(1);
               //     emp.Mypasseord = ret.GetString(2);
                //   emp.Myname = ret.GetString(3);
                    
                //    conn.Close();
                //    return emp;
              //  }
              //  else
               // {
               //     conn.Close();
               //     return null;
              //  }

            }
        }
        
