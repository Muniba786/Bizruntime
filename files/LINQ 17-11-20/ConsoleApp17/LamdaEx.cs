using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class LamdaEx
    {

		delegate bool IsTeenAger(Student stud);

		public void lmd()
       {

			
				IsTeenAger isTeenAger = s => s.Age > 12 && s.Age < 20;

				Student stud = new Student() { Age = 25 };

				Console.WriteLine(isTeenAger(stud));


       }
    }

		public class Student
		{

			public int Id { get; set; }
			public string Name { get; set; }
			public int Age { get; set; }

		}

}
