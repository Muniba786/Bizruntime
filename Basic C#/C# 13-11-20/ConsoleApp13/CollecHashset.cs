using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class CollecHashset
    {
        public void test12()
        {
            
            var names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
