using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp17
{
    class QueryVMethodSyntax
    {
        public void quermeth()
        {
            List<int> integerList = new List<int>()
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100
            };
           
           var Syntax = from obj in integerList where obj > 50 select obj;

            //var Syntax = integerList.Where(obj => obj > 70).ToList();

            foreach (var item in Syntax)
            {
                Console.Write(item + " ");
            }
           
        }
    

               }
}
    