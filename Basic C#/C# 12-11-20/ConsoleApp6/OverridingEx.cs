using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
        public class Animal
        {
            public virtual void eat()
            {
                Console.WriteLine("Eating...");
            }
        }
        public class Dog : Animal
        {
            public override void eat()
            {
                Console.WriteLine("Eating bread...");
            }
        }
        public class TestOverriding
        {
            public static void Main()
            {
                Dog d = new Dog();
                d.eat();
            }
        }
    
}
