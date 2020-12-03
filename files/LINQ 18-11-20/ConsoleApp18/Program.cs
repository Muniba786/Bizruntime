using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            AllEx a = new AllEx();
            a.all();

            AnyEx b = new AnyEx();
            b.any();

            ContainsEx c = new ContainsEx();
            c.con();

            SelectEx d = new SelectEx();
            d.sel();

            SkipEx e = new SkipEx();
            e.sk();

            SkipWhileEx f = new SkipWhileEx();
            f.skw();

            TakeEx g = new TakeEx();
            g.tk();

            TakeWhileEx h = new TakeWhileEx();
            h.tkw();

            JoinEx i = new JoinEx();
            i.jon();

            GroupJoinEx j = new GroupJoinEx();
            j.grpjon();

            SequenceEqEx k = new SequenceEqEx();
            k.seq();

            ConcatEx l = new ConcatEx();
            l.cnt();

            DefaltEmptyEx m = new DefaltEmptyEx();
            m.defemp();

            EmptyEx n = new EmptyEx();
            n.empt();

            RangeEx o = new RangeEx();
            o.rng();

            RepeatEx p = new RepeatEx();
            p.rpt();
        }
    }
}
