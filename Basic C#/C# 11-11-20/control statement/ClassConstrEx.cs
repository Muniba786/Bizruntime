using System;
using System.Collections.Generic;
using System.Text;

namespace controlst
{
    class ClassConstrEx
    {
        public int id;
        public String name;
        public float salary;
        public ClassConstrEx(int i, String n, float s)
        {
            id = i;
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee
    {
        public void test7()
        {
            ClassConstrEx e1 = new ClassConstrEx(10, "Sonu", 890000f);
            ClassConstrEx e2 = new ClassConstrEx(12, "Mona", 490000f);
            e1.display();
            e2.display();

        }
    }
}
