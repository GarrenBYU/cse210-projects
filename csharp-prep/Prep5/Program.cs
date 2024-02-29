using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage ()
        {
        Console.WriteLine("Welcome to the program!");
        }
        static void PromptUserName ()
        {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        }
        static void PromptUserNumber ()
        {
        Console.Write("Please enter your favorite number: ");
        string number = Console.ReadLine();
        }
        static void SquareNumber ()
        {
        int square = int.Parse(number) * int.Parse(number);
        }
        static void DisplayResult ()
        {
        Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}