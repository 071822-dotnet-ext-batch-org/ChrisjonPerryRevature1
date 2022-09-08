using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reflect
{
    public class FirstClass
    {
        public FirstClass()
        {
        }

        public FirstClass(int age, string Name) 
        {
            this.Age = age;
            this.Name=Name;
   
        }
    public int Age { get; set; }
      public string Name { get; set; }
    public int GetAge()
    {
        return Age;
    }
    public string GetName()
    {
        return Name;
    }
      
    }
}