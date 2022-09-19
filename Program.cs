using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerAsks("Guess today's secret number!");
        }

        
        static void ComputerAsks(string question)
        {
            // int SecretNumber = 42;
            // int SecretNumber = new Random().Next(1, 100);
            int SecretNumber = 42;
            int guessCount;
            int iCounter;

                        
            Console.Write($"{question}(between 1-100)");
            Console.WriteLine("");
            Console.WriteLine($"Choose your difficulty; Easy, Medium, Hard or Cheater...");
            
            string difficulty = Console.ReadLine();
            if(difficulty == "Easy")
                {
                    iCounter = 8;
                    guessCount = 8;
                }
            else if(difficulty =="Medium")
                {
                    iCounter = 6;
                    guessCount = 6;
                }
            else if(difficulty == "Hard")
                {
                   iCounter =4;
                   guessCount =4;
                }
            else
                {
                    iCounter =100;
                    guessCount =100;
                }

           
            for(int i =0; i < iCounter; i++){
            string answer = Console.ReadLine();
            // {
            //     Console.WriteLine(answer); //display the answer from the console
            // }  
            int IntAnswer = int.Parse(answer);// change answer from console into an integer to compare with the secret number
            guessCount--; //make the count number decrement
            if(SecretNumber == IntAnswer)
                {
                    Console.WriteLine($"Success!");
                    break;
                }
            
                
                    // Console.WriteLine($"I'm sorry, that is not the Secret Number!");
                    // Console.WriteLine($"Your guess({IntAnswer}) You have {count} guesses left"); //display the users answer, let them know how many guesses are left
            else if(SecretNumber > IntAnswer)
                        {
                           Console.WriteLine($"Your guess is too low!  You have {guessCount} guesses left."); 
                        }
            else
                        {
                            Console.WriteLine($"Your guess is too high! You have {guessCount} guesses left.");
                        }
                
            }
        }
    }
}
