using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPSGame.obj
{
    public class Game
    {
        //Array list of rounds
        int[] listOfRounds = new  int[3]{1,2,3};

        //The overAllWinner
       bool OverAllWinner;

       int numOfTies= 0;

       DateTime DateAndTimePlayed = new DateTime();  
    }
}