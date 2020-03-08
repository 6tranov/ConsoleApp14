using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Program
    {
        static Context context = new Context(new NumStrategy());

        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"{i}:{NumToFB(i)}");
            }
        }
        static string NumToFB(int num)
        {
            bool b3 = num % 3 == 0;
            bool b5 = num % 5 == 0;
            context.ChangeStrategy(d[(b3, b5)]);
            return d[(b3, b5)].FB(num);
        }

        static Dictionary<(bool, bool), IStrategy> d
            = new Dictionary<(bool, bool), IStrategy>
            {
                 { (true,true),new FizzBuzzStrategy()},
                 {(true,false),new FizzStrategy() },
                 {(false,true),new BuzzStrategy() },
                 {(false,false),new NumStrategy() }
            };

    }
}
