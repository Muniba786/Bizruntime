using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Parent
    {
        public void speak() { Console.WriteLine("speaking"); }
    }
    public class Child : Parent
    {
        public void listen() { Console.WriteLine("listening..."); }
    }
    class TestInheritance2
    {
        public static void Main(string[] args)
        {
            Child d1 = new Child();
            d1.speak();
            d1.listen();
        }
    }
}
