using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using repolayer;
namespace businessLayer
{
    public class AppLib
    {
      public Userclass user;
      private rersolver res;
      private Registered registered;
      private Ticket tickfield;
      private adodotnetaccess _reoplayer = new adodotnetaccess();
      
   public bool login(string username, string password){
    Userclass ? u = _reoplayer.GetUsername(username);
    if(u != null &&  u.Mypasseord ==password)
    {
    user = u;
    return true;
    }
    else return false;
   }

   public Userclass registeruser(string username, string password, string name)
   {
    Userclass u = new Userclass(username, password,name);
    if(_reoplayer.Addemployee(u)){
        return _reoplayer.GetUsername(u.Myusername);
    }
    else
    {
        return null;
    }
   }
    public Ticket maketicket(Ticket t){
        if(_reoplayer.AddTicket(t))
        {
            return t; 
        }
        else
        {
            return null;
        }
    }

        public async Task<List<Ticket>> TicketAsync()
        {
            throw new NotImplementedException();
        }
    }
    }

