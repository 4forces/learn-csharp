// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Worlds!");

using System;

namespace myApp
{
    class Program
    {
        static void Main(String[] args)
        {
            for (int ct = 10; ct >= 0; ct--)
            {
                Console.WriteLine($"Hello! Counter is {ct}");
            }
            Console.WriteLine("End of part 1. \r\n");

            for (int ct = 0; ct <= 10; ct=ct+2)
            {
                Console.WriteLine($"Hello! Counter is {ct}");
            }
            Console.WriteLine("End of part 2. \r\n");

            for (int ct = 7; ct <= 22; ct++)
            {
                Console.WriteLine($"Hello! Counter is {ct}");
            }
            Console.WriteLine("End of part 3. \r\n");
        }
    }
}