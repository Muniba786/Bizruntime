using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class Classsw
    {
        public void test4()
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 10: Console.WriteLine("It is 10");
                    break;
                case 20: Console.WriteLine("It is 20");
                    break;
                case 30: Console.WriteLine("It is 30");
                    break;
                default: Console.WriteLine("Not 10, 20 or 30");
                    break;
            }
        }
    }
}
