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
                Console.WriteLine(NumToFB(i));
            }
        }
        static string NumToFB(int num)
        {
            int rem3 = num % 3;
            int rem5 = num % 5;
            return d[(rem3, rem5)].Replace(" ", num.ToString());
        }
        static Dictionary<(int, int), string> d
            = new Dictionary<(int, int), string>
            {
                {(0,0),"FizzBuzz"},
                {(0,1),"Fizz"},
                {(0,2),"Fizz"},
                {(0,3),"Fizz"},
                {(0,4),"Fizz"},
                {(1,0),"Buzz"},
                {(1,1)," "},
                {(1,2)," "},
                {(1,3)," "},
                {(1,4)," "},
                {(2,0),"Buzz"},
                {(2,1)," "},
                {(2,2)," "},
                {(2,3)," "},
                {(2,4)," "},
            };
    }
}
