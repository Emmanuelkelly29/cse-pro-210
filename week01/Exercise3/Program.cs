using System;
using System.Net;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    { Console.Write("Hello User, guess the magic number. 😊");
        Random randomGuess = new Random();
        int magicNumber = randomGuess.Next(1,10);
        int guess = -1;
        while(guess != magicNumber){
            Console.WriteLine("Guess the magic number ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess>magicNumber)
            {
                Console.WriteLine("You are wrong! your guess is higher");
            }else if(guess<magicNumber){
                Console.WriteLine("sorry! this is wrong! your guess is lower");
            }else{
                Console.WriteLine("You are so lucky, Your guess is correct!");   
            }
             }
    }
}