using System;

namespace controlst
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the no to test");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.WriteLine("Even");


            }
            Classifel obj = new Classifel();
            obj.test();

            //Classiei a = new Classiei();
           // a.test1();

           // Classfor b = new Classfor();
           // b.test2();

           // Classcont c = new Classcont();
            //c.test3();

            //Classsw d = new Classsw();
           // d.test4();

           // Arrayex e = new Arrayex();
           // e.test5();

           // Arraymultex f = new Arraymultex();
           // f.test6();

           // TestEmployee g = new TestEmployee();
            //g.test7();

           MethodOlEx h = new MethodOlEx();
            h.test8();



        }
    }
}
