using System;
using ReimbursementModels;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Net.NetworkInformation;
using System.Security.Cryptography;



namespace ReimbursementRepo
{
    public class RepoLayer
    {
        public RepoLayer()
        {
        }

        
        

        public async Task<bool> IsManagerAsync(Guid employeeID)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT IsManager FROM [dbo].[Employees] WHERE EmployeeID =@id", connect))
            {
                command.Parameters.AddWithValue("@id", employeeID);
                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                if (ret.Read()&& ret.GetBoolean(0))
                {
                   connect.Close();
                    return true;
                }
                connect.Close();
                return false;
            }

        }
        public async Task<List<Request>> RequstAsync(int type)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"Select * FROM Requests WHERE Status = @status", connect))
            {
                command.Parameters.AddWithValue("@status", type);
                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                List<Request> rList = new List<Request>();
                while (ret.Read())
                {
                    Request r = new Request(ret.GetGuid(0), ret.GetGuid(1), ret.GetString(2), ret.GetDecimal(3), ret.GetInt32(4));
                    rList.Add(r);
                }
                connect.Close();
                return rList;
            }
        }


            

       

        public async Task<UpdatedRequestDto?> UpdateRequestAsyc(Guid requestId, int status) 
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"Update Requests SET Status = @status WHERE RequestId = @id", connect))
            {
                command.Parameters.AddWithValue("@id", requestId);
                command.Parameters.AddWithValue("@status", status);
                connect.Open();
                int ret = await command.ExecuteNonQueryAsync();
                if (ret ==1 )
                {
                   connect.Close();
                   UpdatedRequestDto urbi =await this.UpdatedRequestByIdAsync(requestId);
                   return urbi;  
                }
                }
                connect.Close();
                return null;
                }

        private async Task<UpdatedRequestDto?> UpdatedRequestByIdAsync(Guid requestId)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT RequestID, FirstName, LastName, Status FROM Employees LEFT JOIN Requests ON EmployeeID = FK_EmployeeId WHERE RequestID =@requestid", connect))
            {
                command.Parameters.AddWithValue("@requestid", requestId);
                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                if (ret.Read())
                {
                    UpdatedRequestDto r = new UpdatedRequestDto(ret.GetGuid(0),ret.GetString(1),ret.GetString(2),ret.GetInt32(3));
                    connect.Close();
                    return r;
                }
            }
            connect.Close();
            return null;
        }
/// <summary>
/// adds a user to the database
/// </summary>
/// <param name="email"></param>
/// <param name="employeeID"></param>
/// <param name="fristName"></param>
/// <param name="lastName"></param>
/// <param name="password"></param>
/// <param name="isManager"></param>
/// <returns></returns>

        public async Task<int?> RegisterAsync(Guid employeeID, string  fristName,  string lastName, string email, string password)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[Employees] (EmployeeID,FirstName,LastName,IsManager,Email,Password) VALUES (@employeeId,@firstname,@lastname,1,@email,@ps) ", connect))
            {
                employeeID = Guid.NewGuid();
                command.Parameters.AddWithValue("@employeeId",employeeID);
                command.Parameters.AddWithValue("@firstname",fristName);
                command.Parameters.AddWithValue("@lastname", lastName);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@ps", password);
                connect.Open();
                int ret = await command.ExecuteNonQueryAsync();

               
                 //RegisterationDto rg = new RegisterationDto(ret.GetGuid(0),ret.GetString(1), ret.GetString(2),ret.GetString(4),ret.GetString(5));
                connect.Close();
                  return ret; 
                }
               
            }


        /// <summary>
        /// Add ticket to the database
        /// </summary>
        /// <param name="fK_EmployeeID"></param>
        /// <param name="requestID"></param>
        /// <param name="amount"></param>
        /// <param name="details"></param>
        /// <returns></returns>
        public async Task<int?> SubmitATicket(Guid fK_EmployeeID, Guid requestID, int amount, string details)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"INSERT INTO [dbo].[Requests](RequestId,FK_EmployeeID,Details,Amount,Status) VALUES (@requestID,@FK_employee,@details,@amount,0) ", connect))
            {
                command.Parameters.AddWithValue("@requestID", requestID);
                command.Parameters.AddWithValue("@FK_employee", fK_EmployeeID);
                command.Parameters.AddWithValue("@details", details);
                command.Parameters.AddWithValue("@amount", amount);
                connect.Open();
                int ret = await command.ExecuteNonQueryAsync();

                
                connect.Close();
                return ret;
            }
        }

        /// <summary>
        /// checks to see if the employee exist in the db
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<LoginDto?> doesUserExist(string email)
        {
            SqlConnection connect = new SqlConnection("Server=tcp:ponechrisjon.database.windows.net,1433;Initial Catalog=Project1Database;Persist Security Info=False;User ID=Chrisjonperry;Password=Perry909;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            using (SqlCommand command = new SqlCommand($"SELECT Email, Password FROM Employees WHERE Email=@email", connect))
            {
                command.Parameters.AddWithValue("@email", email);
                connect.Open();
                SqlDataReader? ret = await command.ExecuteReaderAsync();
                if (ret.Read())
                {
                    LoginDto r = new LoginDto(ret.GetString(0), ret.GetString(1));
                    connect.Close();
                    return r;
                }
            }
            connect.Close();
            return null;
        }
    }
    }
    
    


