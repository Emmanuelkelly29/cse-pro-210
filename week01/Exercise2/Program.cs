using System;

class Program
{
    static void Main(string[] args)
    {
 Console.Write("Hello dear student, tell me your name? ");
        string firstname = Console.ReadLine();

        Console.Write("kindly enter your grade your grade? ");
        string x = Console.ReadLine();
        int percent = int.Parse(x);
        string letter = "";

        int a = 97;
        int b = 93;
        int n = 90;
        int e = 80;
        int d = 70;
        int c = 60;
       if ( percent>= a)
       {
        letter = "A+";
       }
        else if ( percent>= b)
       {
        letter = "A-";
       }
      else if ( percent>= n)
       {
        letter = "A";
       }
       else if ( percent>= e)
       {
        letter = "B";
       }
       else if ( percent>= d)
       {
        letter = "C";
       }
       else if ( percent>= c)
       {
        letter = "D";
       }
       else if (percent<c)
       {
        letter = "F";
       }
       Console.WriteLine($"Your grade is: {letter}");
       if (percent >= 70)
       {
        Console.WriteLine("Congratulations, you have passed the grades!");
       }
       else
       {
        Console.WriteLine("You tried your best, strive harder next time!");
       }    }
}