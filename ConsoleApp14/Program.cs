using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}:{NumToFB(i)}");
            }
        }
        static string NumToFB(int num)
        {
            int rem3 = num % 3;
            int rem5 = num % 5;
            string numStr = num.ToString();
            return (d3[rem3] + d5[rem5]).Replace("  ", numStr).Replace(" ", "");
        }

        static Dictionary<int, string> d3
            = new Dictionary<int, string>
            {
                {0,"Fizz" },
                {1," " },
                {2," " },
            };
        static Dictionary<int, string> d5
            = new Dictionary<int, string>
            {
                {0,"Buzz" },
                {1," " },
                {2," " },
                {3," " },
                {4," " },
            };
    }
}
