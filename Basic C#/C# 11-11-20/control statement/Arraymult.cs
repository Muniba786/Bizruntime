using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class Arraymultex
    {
        public void test6()
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine(); 
            }
        }
    }
}
