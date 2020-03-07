using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class NumStrategy : IStrategy
    {
        public string FB(int num)
        {
            return num.ToString();
        }
    }
}
