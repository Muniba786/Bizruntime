using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryReadWriteEx a = new BinaryReadWriteEx();
            a.brw();

            DirectoryEx b = new DirectoryEx();
            b.dir();

            DirectoryInfoEx c = new DirectoryInfoEx();
            c.dirin();

            DriveInfoEx d = new DriveInfoEx();
            d.dri();

          //  ErrorEventArgEx e = new ErrorEventArgEx();
           // e.eea();

           // Fileexam f = new Fileexam();
           // f.fiex();

            FileInfoEx g = new FileInfoEx();
            g.fiin();



        }
    }
}
