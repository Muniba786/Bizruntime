using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class Classiei
    {
        public void test1()
        { 
            Console.WriteLine("Enter the marks");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i >= 75)
            {
                Console.WriteLine("A Grade");
            }
            else if (i > 60 && i < 75)
            {
                Console.WriteLine("B Grade");
            }
            else
            {
                Console.WriteLine("C Grade");
            }
           
        }
    }
}
