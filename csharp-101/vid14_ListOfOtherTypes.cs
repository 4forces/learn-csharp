using System;

namespace myApp1
{
    class Program{
        static void Main (string[] args)
        {
            // === Fibonacci -- 1 ===
            var fibonnaciNumbers = new List<int> {1,1};

            foreach (var item in fibonnaciNumbers)
            {
                Console.WriteLine($"{item}");
            }


            // === Fibonacci -- 2 & Count -1 ===
            var fibonnaciNumbers = new List<int> {1,1};

            var previous = fibonnaciNumbers[fibonnaciNumbers.Count - 1]; // last item due to [0] index
            var previous2 = fibonnaciNumbers[fibonnaciNumbers.Count - 2]; // 2nd last item

            fibonnaciNumbers.Add(previous + previous2);

            Console.WriteLine("\r\nPrevious: " + previous);
            Console.WriteLine("Previous2: " + previous2 + "\r\n");

            Console.WriteLine("fibonnaciNumbers:\r\n");
            foreach (var item in fibonnaciNumbers)
            {
                Console.WriteLine(item);
            }


            // Challenge: Fibonacci to 20th
            var fibonnaciNumbers = new List<int> {1,1};

            for(int i = 0; i < 18; i++) //ans: while(fibonnaciNumbers.Count < 20)
            {
                var previous = fibonnaciNumbers[fibonnaciNumbers.Count-1]; // last item due to [0] index
                var previous2 = fibonnaciNumbers[fibonnaciNumbers.Count-2]; // 2nd last item

                fibonnaciNumbers.Add(previous + previous2);
                Console.WriteLine($"i: {i}"); //ans omits line
            }

            Console.WriteLine("\r\n");

            int n = 1; //ans omits line
            foreach (var item in fibonnaciNumbers)
            {
                Console.WriteLine($"item in fn[{n}]: {item}"); // ans omits {n}
                n = n + 1; //ans omits line
            }
        }
    }
}