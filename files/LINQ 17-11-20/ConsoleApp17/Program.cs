using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryVMethodSyntax a = new QueryVMethodSyntax();
            a.quermeth();

            LamdaEx b = new LamdaEx();
            b.lmd();

            OrderBy  c = new OrderBy();
            c.ord();

            ThenBy d = new ThenBy();
            d.then();

            GroupBy e = new GroupBy();
            e.group();

            Distinct f = new Distinct();
            f.dist();

            Except g = new Except();
            g.exe();

            Union h= new Union();
            h.uni();

            Intersect i = new Intersect();
            i.inter();

            OfType j = new OfType();
            j.ofty();

            Where k = new Where();
            k.wher();


        }
    }
}
