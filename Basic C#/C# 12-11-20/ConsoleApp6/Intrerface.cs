using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public interface Drawable
    {
        void draw();
    }
    public class Square : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing Square...");
        }
    }
    public class Pentagon : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing Pentagon...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
            d = new Square();
            d.draw();
            d = new Pentagon();
            d.draw();
        }
    }
}
