using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesses = 0;
            int wins = 0;
            int losses = 0;
             Random random = new Random();
        
       bool playAgain= true;

       while(playAgain){
         
          int randomNumber = random.Next(1, 100);
        Console.WriteLine("Guess a number between 1 and 100");
       int guess =Convert.ToInt32(Console.ReadLine());
         guesses++;

       if(guess > randomNumber) {
         losses++;
        Console.WriteLine("Too high! The number was " + randomNumber + " Guesses: " + guesses + " Wins: " + wins + " Losses: " + losses);
       

       }
       else if(guess < randomNumber) {  
         losses++;
        Console.WriteLine("Too low! The number was " + randomNumber + " Guesses: " + guesses + " Wins: " + wins + " Losses: " + losses);
       
            }
            else{
                wins++;
                Console.WriteLine("You guessed right! The number was " + randomNumber + " Guesses: " + guesses + " Wins: " + wins + " Losses: " + losses);
                
            }
             Console.WriteLine("Do you want to play again? (y/n)");
         String answer = Console.ReadLine();
         if(answer == "y"){
            playAgain = true;
         }
         else{
            playAgain = false;
            Console.WriteLine("Thanks for playing! Your total wins: " + wins + " Total losses: " + losses);
         }
       }
        
         
        }
    }
}