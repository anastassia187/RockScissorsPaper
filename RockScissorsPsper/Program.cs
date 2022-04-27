using System;

namespace RockScissorsPsper
{
    class Program
    {
        static void Main(string[] args)
        {

            string cpuChoice;
            string userChoice;
            int RandomInt;
            bool LoopActive = true;
            
              Random rnd = new Random();

            while (LoopActive == true)
            {
                 int cpuScore = 0;
                 int userScore = 0;

                while(userScore < 3 && cpuScore < 3)
                {
                    Console.WriteLine("Rock, paper or scissors:");
                    userChoice = Console.ReadLine();
                   

                    RandomInt = rnd.Next(1, 4);

                    switch (RandomInt)
                    {
                        case 1:

                           cpuChoice = "Paper";
                            Console.WriteLine("Computer chose Paper");
                            if (userChoice == "Paper")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (userChoice == "Scissors")
                            {
                                Console.WriteLine("User Wins!");
                                userScore++;
                                Console.WriteLine("User score is :" + userScore);
                            }
                            else if (userChoice == "Rock")
                            {
                                Console.WriteLine("Computer Wins!");
                                cpuScore++;
                                Console.WriteLine("Computer score is: " + cpuScore);
                            }
                            else
                            {
                                Console.WriteLine("Invalid enty! Computer Wins!");
                            }
                            
                            
                            
                            break;

                        case 2:
                            cpuChoice = "Rock";
                            Console.WriteLine("Computer chose Rock");
                            if (userChoice == "Paper")
                            {
                                Console.WriteLine("User Win!");
                                userScore++;
                                Console.WriteLine("User score is :" + userScore);
                            }
                            else if (userChoice == "Rock")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (userChoice == "Scissors")
                            {
                                Console.WriteLine("Computer Wins!");
                                cpuScore++;
                                Console.WriteLine("Computer score is: " + cpuScore);
                            }
                            break;

                        case 3:
                            cpuChoice = "Scissors";
                            Console.WriteLine("Computer chose Scissors");
                            if(userChoice == "Scissors")
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if(userChoice == "Rock")
                            {
                                Console.WriteLine("User Win!");
                                userScore++;
                                Console.WriteLine("User score is :" + userScore);
                            }
                            else if(userChoice == "Paper")
                            {
                                Console.WriteLine("Computer Wins!");
                                cpuScore++;
                                Console.WriteLine("Computer score is: " + cpuScore);
                            }
                                
                            break;

                               default:
                               Console.WriteLine("Invalid enty!");
                            break;

                    }
                    
                    if(userScore == 3)
                    {
                        Console.WriteLine("User won the game!");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to play Again? Answer Yes or No!");
                    }
                    else if(cpuScore == 3)
                    {
                        Console.WriteLine("Computer won the game!");
                        Console.WriteLine();
                        Console.WriteLine("Do you want to play Again? Answer Yes or No!");

                    }
                    else
                    {
                        Console.WriteLine("Try agayn! Press enter!");
                        
                    }

                    
                    string answer = Console.ReadLine();

                    if (answer == "Yes")
                    {
                        LoopActive = true;

                    }
                    else if ( answer == "No")
                    {
                        LoopActive = false;
                        Console.WriteLine("Have a nice day!");
                    }
                    else
                    {
                        
                    }
        }
                }
            }
            
    }
}
