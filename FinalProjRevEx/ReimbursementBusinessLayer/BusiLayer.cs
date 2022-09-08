using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using Microsoft.IdentityModel.Logging;
using ReimbursementModels;
using ReimbursementRepo;
namespace ReimbursementBusinessLayer
{
    public class BusiLayer
    {
        private readonly RepoLayer _repo;
        public Employee logged;

        public BusiLayer()
        {
            _repo = new RepoLayer();
        }

        

        public async Task<List<Request>> RequestAsync(int type)
        {
           List<Request> list = await this._repo.RequstAsync(type);
            return list;
        }

        public async Task<UpdatedRequestDto?> UpdateRequestAsync(ApprovalDto approval)
        {
            if (await this._repo.IsManagerAsync(approval.EmployeeID))
            { 
           UpdatedRequestDto approvedRequest = await this._repo.UpdateRequestAsyc(approval.RequestID, approval.Status);
                return approvedRequest;
          
            }
             return null;
        }

      

        public async Task<int?> RegisterAsync(Guid employeeID, string firstname,string lastname, string email,string password)
        {
            
            int? reg = await this._repo.RegisterAsync(employeeID,firstname, lastname,email,password);
            return reg;
        }

        public async Task<int?> SubmitATicket(Guid fK_EmployeeID, int amount, string details)
        {
           Guid RequestID = Guid.NewGuid();
            int? logger = await this._repo.SubmitATicket(fK_EmployeeID, RequestID, amount, details);
            return logger;
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            LoginDto? request = await this._repo.doesUserExist(email);
            if (request == null)
            {
                return false;
            }
            if(request.Password==password)
            {
                return true;
            }
            return false;
            
        }
    }
    }


