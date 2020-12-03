using System;
using System.Threading;
class MultiThreadingEx
    {  
        static void Test1()
        {
            for(int i=1;i<50;i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread 1 is exiting");
        }
        static void Test2()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread is going to sleep.");
                    Thread.Sleep(15000);
                    Console.WriteLine("Thread 2 woke up.");
                }
            }
            Console.WriteLine("Thread 2 is exiting");
        }
        static void Test3()
        {
            for (int i = 1; i < 50; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread 3 is exiting");
        }
       public void mult()
        {
            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start(); T2.Start(); T3.Start();
            T1.Join(); T2.Join(); T3.Join();
        Console.WriteLine("Thread Main is exiting");
        }

    }



