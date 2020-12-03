using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
     public class TryCatchFinally
    {

        
            public void test2()
            {
                try
                {
                    int a = 10;
                    int b = 0;
                    int x = a / b;
                }
                catch (Exception e) { Console.WriteLine(e); }
            finally { Console.WriteLine("Finally block is executed"); }

            Console.WriteLine("Rest of the code");
            }
        
    }
}
