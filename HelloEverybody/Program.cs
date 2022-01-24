using System;

namespace HelloEverybody
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello everyone!");
            Console.Write("Please enter your name");
            string myVar = Console.ReadLine();
            Console.WriteLine($"Hi {myVar}!");
        }
    }
}
