using System;

namespace NumberGuessingGame2
{
    class Program
    {
        static void Main(string[] args){
            Random random  = new Random();
            int min = 1;
            int max = 100;
            int guess;
            int guesses;
            int number;

            bool playAgain = true;
            while(playAgain){

                guess = 0;
                guesses =0;
                number = random.Next(min, max+1);

                while (guess != number){
                    Console.WriteLine("Guess a number between " + min + " and " + max + ": ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: "+guess);

                    if(guess > number){
                        Console.WriteLine(guess + " is to high");
                    }
                    else if(guess < number){
                        Console.WriteLine(guess + " is to low");
                    }
                    guesses++;

                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Congratulations! You guessed the number!");
                Console.WriteLine("Guesses:" + guesses);
                Console.WriteLine("Would you like to play again? (y/n)");
                string response = Console.ReadLine();
                response = response.ToLower();
                if(response != "y"){
                    playAgain = false;
                }


            }
            Console.WriteLine("Thank you for playing!");
        }
    }
}