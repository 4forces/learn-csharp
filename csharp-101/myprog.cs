// ===== C#101 Video 09/19: "Hello World" Explained =====

using System; // 'using' imports 'System' library for 'Console' from 'Console.Writeline'

namespace myApp1 // namespaces are used to group and organise code, usually to group
//multiple different classes that are very related.
{
    class Program
    {
        static void Main(string[] args) // 'Main' means the Main place to start the program
        // 'Static' means the 'Main' program will be static (unchanging) and not change dynamically when prog executes
        // 'void' means "returns nothing" in result. Something can also be returned in result,
        // for eg. 'static int' - retrns integer, 'static string' returns string
        // '(string[array] of args)': Refers to a string array with any number of arguments
        // for eg. "Hello World" is an argument
        {
            Action <object> cw = Console.WriteLine;
            // int a = 5;
            // int b = 3;
            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10.");
            // }
            cw("Hello world");
        }
    }
}

