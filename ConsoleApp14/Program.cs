﻿using System;
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
            bool b3 = IsNumDivisibleBy(3);
            bool b5 = IsNumDivisibleBy(5);
            return d[(b3, b5)](num);

            bool IsNumDivisibleBy(int n)
            {
                return num % n == 0;
            }
        }
        static Dictionary<(bool, bool), Converter<int, string>> d = new Dictionary<(bool, bool), Converter<int, string>>
        {
            { (true,true),(n)=> {return "FizzBuzz"; }},
            { (true,false),(n)=> { return "Fizz";}},
            { (false,true),(n)=> { return "Buzz"; }},
            { (false,false),(n)=> {return n.ToString(); }},
        };
    }
}
