using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using businessLayer;
using Models;

namespace ReimbursementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseSystemController : ControllerBase
    {
        private readonly AppLib _al;

        public ExpenseSystemController()
        {
            _al = new AppLib();
        }

        [HttpGet("Ticket")]
        public async Task<ActionResult<List<Ticket>>> pendingTicket( string type, Guid? id)
        {
            if (type.Equals("Pending"))
            {
                List<Ticket> TicketsList = await this._al.TicketAsync();
                return Ok(TicketsList);
            }
            return null; 
         }
        }
    }

