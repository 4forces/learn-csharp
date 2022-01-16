// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Worlds!");

using System;
using System.Collections.Generic;

class Program
{
    static void Main(String[] args)
    {
        // ===== Search =====
        Action<object> cw = Console.WriteLine;

        var names = new List<string> {"Sophia","Ana","Jayme","Bill"};
        string name = "Ana";
        var index = names.IndexOf(name);
        cw($"Found '{name}' at index '{index}'");

        string name2 = "Sophia";
        var index2 = snames.IndexOf(name2);
        cw($"Found '{name2}' at index '{index2}'");

        string name3 = "Scott";
        var index3 = names.IndexOf(name3);
        cw($"Found '{name3}' at index '{index3}'");


        // ===== What does -1 mean? =====
        Action<object> cw = Console.WriteLine;

        var names = new List<string> {"Sophia", "Ana", "Jayme", "Bill"};
        string name = "Bill";
        var index = names.IndexOf(name);

        if(index == -1){
            cw($"{name} not found in list");
        } else {
            cw($"Index of '{name}' is '{index}'");
        }


        // ===== Sort =====
        Action<object> cw = Console.WriteLine;

        var names = new List<string> { "Sophia", "Ana", "Jayme", "Bill" };
        cw("Pre Sorting: ");
        foreach(var name in names)
        {
            cw(name);
        }

        names.Sort();

        Console.WriteLine();

        cw("Post Sorting");
        foreach(var name in names)
        {
            cw(name);
        }


        // ===== Playground =====
        var groceries = new List<String> { "Kale", "Brocolli", "Carrots", "Potatoes" };
        groceries.Sort();
        Console.WriteLine("Post sorting:\r\n");
        foreach(var grocery in groceries)
        {
            Console.WriteLine(grocery);
        }
        Console.WriteLine($"\r\nThe index of 'Carrots' is {groceries.IndexOf("Carrots")}");

        var nums = new List<Int32> {33,65,84,58};
        Console.WriteLine("\r\nOriginal nums order");
        foreach(var num in nums)
        {
            Console.WriteLine($"{num}");
        }

        nums.Sort();
        Console.WriteLine("\r\nnum as List<Int32> sorts in order");
        foreach(var num in nums)
        {
            Console.WriteLine($"{num}");
        } // List<Int32> sorts numbers list in order

        var numsStr = new List<String> {"33","65","84","58"};
        numsStr.Sort();
        Console.WriteLine("\r\nnum as List<String> also sorts in order");
        foreach(var numStr in numsStr)
        {
            Console.WriteLine($"{numStr}");
        } // List<String> Also sorts numbers list in order

    }
}