using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class Classifel
    {
        public void test()
        {
            Console.WriteLine("Enter the no to test");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Even");
                
            }
            else
            {
                Console.WriteLine("odd");
                
            }
        }
      
            
        
    }
}
