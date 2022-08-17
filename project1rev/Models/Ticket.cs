using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int TicketAmount { get; set; }
        public string descript { get; set; }
        public int status { get; set; }
      public Guid  FK_employeeId {get; set;}
        public Userclass user  {get; set;} = new Userclass(); 
     public rersolver resolver {get; set;}= new rersolver();

     public Ticket(){}

     public Ticket(int amount){
     this.TicketAmount=amount;
     }  
    }
}