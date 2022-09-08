using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReimbursementBusinessLayer;
using ReimbursementModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FinalProject1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReimbursmentApi : Controller
    {
        private readonly BusiLayer _busiLayer;
        public ReimbursmentApi()
        {
        this._busiLayer = new BusiLayer();
        }

        [HttpGet("Request/type")]
    public async Task<ActionResult<List<Request>>>GetRequest(int type,Guid? id)
        {
            
                List<Request>requestList = await this._busiLayer.RequestAsync(type);
                return Ok(requestList);
            
                //return null;
        }
        [HttpPut("UpdateRequestAsync")]
        public async Task<ActionResult<UpdatedRequestDto>> UpdateRequest(ApprovalDto approval)
        {
           if (ModelState.IsValid) { 
           UpdatedRequestDto approvalRequest = await this._busiLayer.UpdateRequestAsync(approval);
            return Ok(approvalRequest);
         }
        else return Conflict(approval);//StatusCode(StatusCodes.Status409Conflict);
        }

        [HttpGet("Register")]//Http Post
        public async Task<ActionResult<int?>> RegisterAsync(string firstname, string lastname, string email,string password )//(RegisterationDto log)
        {
            if (ModelState.IsValid)
            {
                Guid employeeID = new Guid();//business logic should be in the business layer
              int? logger = await this._busiLayer.RegisterAsync(employeeID,firstname,  lastname,  email,  password);
                    return Ok(logger);
            }
            else return Conflict();
        }
        [HttpGet("SubmitATicket")]
        public async Task<ActionResult<int?>> SubmitATicket(Guid FK_EmployeeID, int amount, string details)
        {
            if (ModelState.IsValid) {
                
            int? logger = await this._busiLayer.SubmitATicket(FK_EmployeeID, amount, details);
                return Ok(logger);
            }
           else return Conflict();
        }
         [HttpPost("Login")]
         public async Task<ActionResult<bool>> loginAsync(LoginDto request)
        {
           bool response = await this._busiLayer.LoginAsync(request.Email,request.Password);
            if (ModelState.IsValid) {
                if (response) { 
                return Ok(response);
                }
                else return Unauthorized();
            }
            else return BadRequest();

         }
         
        
            



    } }
         
    

   


