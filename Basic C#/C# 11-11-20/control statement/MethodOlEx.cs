using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class MethodOlEx
    { 
        public void Test()
        {
            Console.WriteLine("Ist Method");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Test(int i,string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Test(string s,int i)
        {
            Console.WriteLine("5th Method");
        }
        public void test8()
        {
            MethodOlEx p = new MethodOlEx();
            p.Test(10);
            
        }
    }
}
