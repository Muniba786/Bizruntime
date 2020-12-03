
using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReaderEx a = new StreamReaderEx();
            a.stre();

            StreamWriteEx b = new StreamWriteEx();
            b.stwr();

            StringReaderEx c = new StringReaderEx();
            c.sire();

            StringWriterEx d = new StringWriterEx();
            d.siwr();

            TextReaderEx e = new TextReaderEx();
            e.txre();

            TextWriterEx f = new TextWriterEx();
            f.txwr();
        }
    }
}
