using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Userclass
    {
     public string Myusername { get; set; }
     public string Mypasseord { get; set; }    
     public string Myname { get; set; } 
     public Guid id {get; set;}=Guid.NewGuid();

     public Userclass(){}
     public Userclass (string usernameu, string passwordu ){
        this.Myusername = usernameu;
        this.Mypasseord = passwordu;
     }
     public Userclass(string username, string password, string name, Guid id){
        this.Myusername = username;
        this.Mypasseord = password;
        this.Myname = name;
        this.id = id;
     }
        public Userclass(string username, string password, string name){
        this.Myusername = username;
        this.Mypasseord = password;
        this.Myname = name;
        
     }
    }
}