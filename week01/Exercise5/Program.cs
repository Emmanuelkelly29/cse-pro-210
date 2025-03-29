using System;

class Program
{
    static void Main(string[] args)
    {
  DisplayWelcomeMessage();

        string  name = promptUserName();
        int number = promptUserNumber();

        int squared=SquareNumber(number);

        DisplayResult(name, squared);
    }
    static void DisplayWelcomeMessage(){
        Console.Write("Welcome dear user!");
    }
    static string promptUserName(){
        Console.Write("Please enter your fullname: ");
        string name = Console.ReadLine();
        return name;
    }
    static int promptUserNumber(){
        Console.Write("Please enter your day of birth as your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
        int square = number * number;
        return square;
    }
    static void DisplayResult( string name, int square){
        Console.Write($"Dear, {name}, the square of number is {square}");
    }
}