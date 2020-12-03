using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class CollecList
    {
        public void test13()
        {
              
            var names = new List<string>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");

           
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
