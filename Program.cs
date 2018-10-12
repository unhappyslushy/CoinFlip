using System;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
           int coin;
           string userGuess;
           string coinDescription;
           Random rng = new Random();

           // Query the user
           Console.Write("Enter Your Guess Heads Or Tails?");
           userGuess = Console.ReadLine();

           // get a random number for the coin flip
           coin = rng.Next(0, 2);
           if (coin == 1) 
            {   
                coinDescription = "Heads";
            }
           else 
           {
               coinDescription = "Tails";
           }
           if ((coin == 0 && userGuess == "Tails") || (coin == 1 && userGuess == "Heads"))
            {  
                 Console.WriteLine("The coin flip was {0}, you win!", coinDescription);
            }
            
                else 
                { 
                 
                    Console.WriteLine("the coin flip was {0}, you lose!", coinDescription);
            
                }

          Console.ReadLine(); 
    }   
}
}
