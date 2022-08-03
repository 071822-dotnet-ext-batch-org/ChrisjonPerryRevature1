using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPSGame
{
    public class Players
    {
       // class has properties, attributes, constructors and methods mainly
       private int Myage =0; 
        // access modifiers controls what part pf the code can access a specific class or field (or property or method)
        // An attribute is a single piece of data like age DoB name etc

        //A property is a special c# abstraction that is copmbo of getters and setters.
        public DateTime myDoB { get; set; } = new DateTime(10/07/1998);
        public string Fname { get; set; }
        public string Lname { get; set; }
        public bool Gender { get; set; } // true == female false== male
        //Constructors are the methods called to instantiate a Class object. can be overloaded
        // you are given a default constructor when you dont create one you 

        //methods sets of consecutive steps that a program completes they can be called individually
        public int getMyAge(){
            return Myage;
        }

       /* public setMyAge(int Myage){
            if(Myage>110 || Myage <18){
                throw new FieldAccessException($"Age cant be set to this age");

            }
            this.Myage = Myage; */
        

    
    
    
    }

}