using System;

namespace rock_paper_scissor
{
    class Program{
        static void Main(String[] args){
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;

            while(playAgain){
                computer = "";
                player = "";
                while(player != "rock" && player != "paper" && player != "scissor"){
                    Console.WriteLine("Enter rock, paper or scissor: ");
                    player = Console.ReadLine();
                }

                int randomNum = random.Next(1, 4);
                switch(randomNum){
                    case 1:
                        computer = "rock";
                        break;
                    case 2:
                        computer = "paper";
                        break;
                    case 3:
                        computer = "scissor";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch(player){
                    case "rock":
                    if (computer == "rock"){
                        Console.WriteLine("It's a tie!");
                    } else if (computer == "paper"){    
                        Console.WriteLine("Computer wins!");
                    } else {
                        Console.WriteLine("Player wins!");
                    }
                    break;
                    case "paper":
                    if (computer == "paper"){
                        Console.WriteLine("It's a tie!");
                    } else if (computer == "scissor"){    
                        Console.WriteLine("Computer wins!");
                    } else {
                        Console.WriteLine("Player wins!");
                    }
                    break;
                    case "scissor":
                    if (computer == "scissor"){
                        Console.WriteLine("It's a tie!");
                    } else if (computer == "rock"){    
                        Console.WriteLine("Computer wins!");
                    } else {
                        Console.WriteLine("Player wins!");
                    }
                    break;
                }

                Console.WriteLine("Do you want to play again? (y/n)");

                if (Console.ReadLine() != "y"){
                    playAgain = false;
                }
              
            }
            Console.WriteLine("Thanks for playing!");
        }
    }

}