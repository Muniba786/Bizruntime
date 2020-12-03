using System;
using System.Threading;
class Printer
{
    public void PrintTable()
    {
        lock (this)
        {
            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
        }
    }
}
class SyncLock
{
    public void sync()
    {
        Printer p = new Printer();
        Thread t1 = new Thread(new ThreadStart(p.PrintTable));
        Thread t2 = new Thread(new ThreadStart(p.PrintTable));
        t1.Start();
        t2.Start();
    }
}
