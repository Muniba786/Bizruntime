using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    
        public delegate string GreetingsDelegate(string name);
    class Anonymous
    {

        public void test1()
            {
                GreetingsDelegate obj = delegate (string name)
                {
                    return "Hello " + name + "a very good Morning";
                };
                string str = obj.Invoke("Mona ");
                Console.WriteLine(str);
            }
            
        
    }
}
