using System;

namespace RPSGame
{
    class Program
    {
        static void Main(string[] args)
        {
          
        //Welcome message
        Console.WriteLine("Welome to Rock Paper Scissors! \n Your favorite game");
        //instruction to play ... or game flow
        Console.WriteLine("To play press enter. \n press the number that corresponds to rock paper scissors to make  a call \n the com will make its choice and the winner will be displayed \n press enter to play");
        //Start the game by pressing enter 
         Console.Read();
        //(unseen to user)Create some variables to store the user choice and computer choice.
         Random rand = new Random(); // the Random class gets us a pseudorandom decimal between 0 and 1;
         int comChoice =0 ;
         int userChoice = 0;
         int user1Wins=0; // number of user wins
         int comWins=0;  // number of com wins
         int numOfTies =0; // number og
         string  user1Name = "";
         string comName = ""; 
        string userChoiceStr = "";
         bool istied = true;
         string playAgain = "";
         int numberOfRounds = 0;
         int totalRounds = 0;
         bool isNamevalid =true;
         //get user name
         while(isNamevalid){
         
         Console.WriteLine("what is your name \n Please enter a name with less than 15 characters\n");
        user1Name = Console.ReadLine();
        if(user1Name.Length <=15){
       isNamevalid =false;
       Console.WriteLine("Please enter a name with less than 15 characters ");
       
         }
         
        Console.WriteLine("Welcome to the Rock paper Scissors\n{0}",user1Name);
         
        }
         //com wins, user win, number of tie, username, p1 name, p2 name
         
         // get user choice (Start loop)
       while(true){
        while(istied)
        {
        Console.WriteLine("Please enter...\n 1 for rock \n 2 of paper \n 3 for scissor");
        userChoiceStr = Console.ReadLine();
        try {
            userChoice = Int32.Parse(userChoiceStr);
        }
        catch(ArgumentNullException e){
            Console.WriteLine($"The parse method failed because{e.Message}");
        } 
        catch(FormatException e){
        Console.WriteLine($"The parse method failed because{e.Message}");
        } 
        catch(OverflowException e){
            Console.WriteLine($"The parse method failed because{e.Message}");
        } 
        
        Console.WriteLine($"The number you inputted was {userChoice}");
         // get com choice
         comChoice = rand.Next(3)+1;

         Console.WriteLine(comChoice);
         //evaluate the choices to determine the winner of the round.
        if(userChoice == comChoice){
            // Tie and loop back up to repormt
            Console.WriteLine("There is a tie lets try again");
            //update tally for game session of how many games the com and user have one.
            numOfTies += 1; 
            istied =true; 
        }
        else if(userChoice == 1 && comChoice ==3 || 
                userChoice == 2 && comChoice ==1 ||
                userChoice == 3 && comChoice ==2  )
                { // user won 
                Console.WriteLine($"Congrats, {user1Name}"); 
                //update tally for game session of how many games the com and user have one.
                user1Wins+=1; 
                istied = false;     
                 }
        else { // com won 
        Console.WriteLine("The computer wins. HaHaHaHa ....");
            comWins++;
            istied = false;
        }
     }
        //
        
         // display who won if there's a winner.
         
        
         //ask if user wants to play again(If using rounds)
        
          Console.WriteLine($"{user1Name}Would you like to play again ?\nEnter Y to play again or N to quit"); 
        playAgain = Console.ReadLine();
        if(playAgain=="Y"){
            istied = true;
             numberOfRounds++;
            continue;
        } else { 
           Console.WriteLine("Sorry to see you go \n"); 
           Console.WriteLine("Number of rounds: {0}",numberOfRounds);
           Console.WriteLine($"Computer wins: {comWins}\n");
           Console.WriteLine($"{user1Name} wins: {user1Wins}");
           break; //Breaks out of game loop
        }
        //tell the user the tally results as of now 

         // Ask if they want to play again. 
         
         //quit if user wants to play again... loop to beginning if user wants to play again.
        
       }
        }
    }
}
