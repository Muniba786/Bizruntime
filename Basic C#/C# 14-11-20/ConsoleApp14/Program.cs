using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiThreadingEx a = new MultiThreadingEx();
            a.mult();

            ThreadExample b = new ThreadExample();
            b.prio();

            GenricEx c = new GenricEx();
            c.gen();

            //ThreadAbort d = new ThreadAbort();
            //d.abo();

            SyncLock e = new SyncLock();
            e.sync();
        }
    }
}
