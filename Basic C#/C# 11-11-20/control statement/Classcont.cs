using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class Classcont
    
        {
        public void test3()
        {
            for (int j = 1; j <= 10; j++)
            {
                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine(j);
            }
        }
    }

}
