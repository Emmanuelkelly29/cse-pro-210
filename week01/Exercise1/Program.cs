using System;

class Program
{
    static void Main(string[] args)
    {
Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Hello, it is nice to meet you, your name is {lastname}, {firstname} {lastname}.");
    }
}