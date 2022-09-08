using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using ReimModelsLayer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace reimbursemntApilayer.Controllers
{
    [Route("api/[controller]")]
    public class ExpenseReimbursement : Controller
    {
        private readonly ReimbursementbusiLayer _busiLayer;
        public ExpenseReimbursement()
        {
            this._busiLayer = new ReimbursementbusiLayer();
        }
        [HttpGet("Request")]
        [HttpGet("RequestAsync/{type}")]
        public async Task<ActionResult<List<Request>>> GetRequest(string? type,Guid? id)
        {
         List<Request> requestList = await this._busiLayer.RequestAsync(type); // sends to business layer
         return Ok(requestList);// reutrns 200
            
         //return null;
        }
        
    }
}

