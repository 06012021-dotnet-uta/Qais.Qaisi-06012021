using System;

namespace RockPaperScissors1
{
    partial class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name ");
            String playerName = Console.ReadLine();
            
            bool playAgainBoolean= false;
            String playAgain="Y";
         do {
            Console.WriteLine("Hello "+playerName+" Welcome to Rock-Paper-Scissors!\n\nPlease make a choice.");
         int playerScore=0;
         int computerScore=0;
         for (int i=1; i<=3; i++){

            
            bool successfulConversion = false;
            int playerChoiceInt;
            do
            {
                Console.WriteLine("1. Rock\n2. Paper\n3. Scissors");
                string playerChoice = Console.ReadLine();

                //create a int variable to catch the converted choice.
                successfulConversion = Int32.TryParse(playerChoice, out playerChoiceInt);

                //check if the user inputted a number but the numebr is out of bounds.
                if (playerChoiceInt > 3 || playerChoiceInt < 1)
                {
                    Console.WriteLine($"You inputted {playerChoiceInt}. That is not a valid choice.");
                }
                else if (!successfulConversion)
                {
                    Console.WriteLine($"You inputted {playerChoice}. That is not a valid choice.");
                }

            } //while (!successfulConversion || (playerChoiceInt < 1 || playerChoiceInt > 3));
            while (!successfulConversion || !(playerChoiceInt > 0 && playerChoiceInt < 4));//both of hte above are valid.

            //you can omit the {} if the body of hte statement is only 1 line
            if (successfulConversion == true) Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");
            else
                Console.WriteLine($"the conversion returned {successfulConversion} and the player chose {playerChoiceInt}");

            //kget a random number generator object
            Random rand = new Random();
            //get a random number 1,2, or 3.
            int computerChoice = rand.Next(1, Enum.GetNames(typeof(RpsChoice)).Length + 1);

            //print the choices.
            Console.WriteLine($"{playerName} choice is {playerChoiceInt}");
            Console.WriteLine($"the computers choice is {computerChoice}");

            //check who won.
            if ((playerChoiceInt == 1 && computerChoice == 2)
                || (playerChoiceInt == 2 && computerChoice == 3)
                || (playerChoiceInt == 3 && computerChoice == 1)) 
                {computerScore=computerScore+1;
                Console.WriteLine("Computer Wins");}
            else if (playerChoiceInt == computerChoice) Console.WriteLine("Tie Game!!");
            else 
            {
            playerScore=playerScore+1;
            Console.WriteLine(playerName+" Wins!!!");
            }
            //you can get typeDef the number to the equivalent RpsChoice Enum.
            Console.WriteLine((RpsChoice)playerChoiceInt);
            Console.WriteLine((RpsChoice)computerChoice);
         }
            if (playerScore>computerScore)
            Console.WriteLine("Three Round Result "+playerName+" Wins!!!");
            else if (playerScore==computerScore) Console.WriteLine("Tie Game!!");
            else Console.WriteLine("Three Round Result Computer Wins!!!");
          
          



            playAgainBoolean = false;

            do
            {
                Console.WriteLine("Hey "+playerName+ " Would you like to play again ? [Y/N]");
                playAgain=Console.ReadLine();
                //create a int variable to catch the converted choice.
                
                //check if the user inputted a number but the numebr is out of bounds.
                if (playAgain=="Y" || playAgain=="y"|| playAgain=="N" || playAgain=="n" )
                {
                    playAgainBoolean=true;
                    
                }
                else 
                {
                    Console.WriteLine($"You Entered Wrong Choice");
                }

            } 
            while (!playAgainBoolean);



          
         
         
         
         }
         while(playAgain=="Y" || playAgain=="y");
            /*Coding challenge
            1. implement a loop to play again if the player chooses to.
            2. get the players name to print out the winners
            3. implement the code to play 3 rounds.
            */

        }//end of main
    }//end of class
}//end of namespace
