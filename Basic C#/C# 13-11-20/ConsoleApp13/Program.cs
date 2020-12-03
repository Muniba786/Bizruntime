using System;

namespace ConsoleApp13
{
    
        public delegate void AddDelegate(int x, int y);
        public delegate string SayDelegate(string str);
    class Program

    {
        public void AddNums(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.AddNums);
            ad(100, 50);

            SayDelegate sd = new SayDelegate(Program.SayHello);
            string str = sd("Mona");


            Console.WriteLine(str);


            Anonymous a = new Anonymous();
            a.test1();

            TryCatchFinally b = new TryCatchFinally();
            b.test2();

           //CheckedEx c = new CheckedEx();
            //c.test3();

            UncheckedEx d = new UncheckedEx();
            d.test4();

            SortedSet e = new SortedSet();
            e.test5();

            StackEx f = new StackEx();
            f.test6();

            QueueEx g = new QueueEx();
            g.test7();

            LinkedListEx h = new LinkedListEx();
            h.test8();

            Dictionary i = new Dictionary();
            i.test9();

           // SortedDictionaryEx j = SortedDictionaryEx();
            //j.test10();

            SortedList k = new SortedList();
            k.test11();

            CollecHashset l = new CollecHashset();
            l.test12();

            CollecList m = new CollecList();
            m.test13();
        }

        
        
    }
}
