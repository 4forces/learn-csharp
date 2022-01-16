// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Worlds!");

using System;

namespace myApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Action <object> cw = Console.WriteLine;
            /*
            1.Make a list of groceries you need called `groceries`.
            2.Can you print out "buy \<grocery\>!" for every item?
            3.What's the 3rd item of the list? Is that the same as `groceries[3]?`
            4.Make sure to add "toothpaste".
            5.Remove your least favorite item.
            6.Now what's third on the list?
            */


            // 1 & 2
            cw("\r\n === 1 & 2 ===");
            var groceries = new List<string> {"kale","tissue","shampoo"};
            foreach (var grocery in groceries)
            {
                cw($"buy <{grocery}>");
            }

            // 3
            cw("\r\n === 3 ===");
            cw($"3rd item of list is: {groceries[2]}");
            //cw($"groceries[3] gives: {groceries[3]}");

            // 4
            cw("\r\n === 4 ===");
            groceries.Add("toothpaste");
            for (int i = 0; i < groceries.Count; i++)
            {
                cw($"{i}: {groceries[i]}");
            }

            // 5
            cw("\r\n === 5 ===");
            groceries.Remove("kale");
            for (int i = 0; i < groceries.Count; i++)
            {
                cw($"{i}: {groceries[i]}");
            }

            // 6
            cw("\r\n === 6 ===");
            cw($"3rd item of list is now: {groceries[2]}");
        }
    }
}