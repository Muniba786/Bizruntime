using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class UncheckedEx
    {
        public void test4()
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
        }
    }
}
