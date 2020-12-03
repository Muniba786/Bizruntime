using System;
namespace ConsoleApp14
{
    class GenericClass
    {
        public void Show<T>(T messg)
        {
            Console.WriteLine(messg);
        }
    }
    public class GenricEx
    {
        public void gen()
        {
            GenericClass genC = new GenericClass();
            genC.Show("This is generic method");
            genC.Show(10);
            genC.Show('I');
        }
    }
}
