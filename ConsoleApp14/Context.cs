using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Context
    {
        private Converter<int, string> _execute { get; set; }
        public Context(IStrategy strategy)
        {
            this._execute = strategy.FB;
        }
        public string FB(int num)
        {
            return _execute(num);
        }
        public void ChangeStrategy(IStrategy strategy)
        {
            this._execute = strategy.FB;
        }
    }
}
