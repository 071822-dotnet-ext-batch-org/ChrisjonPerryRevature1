using System;

namespace EX
{
    
        
 public static bool isOdd(int x)
            {
            	if (x % 2 != 0)
                {
                	return true;
                }
                
                return false;
            }
           
        public static void Main(String[] args)  
        {  	
			List<int> myList = new List<int>();
            
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);       
            
            int calculate = 1;
            
            for (int i=0; i < myList.Count; i++)
            {
            	if (isOdd(myList[i]))
                {
                	myList[i] = 0;
                }
                calculate = calculate * myList[i];
            }
             
            Console.WriteLine(calculate);   
            }
}