using System;
using System.Linq;
using System.Collections.Generic;


public class AllEx
{
	public void all()
	{
		IList<S> studentList = new List<S>() {
			new S() { StudentID = 1, StudentName = "John", Age = 13 } ,
			new S() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new S() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new S() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new S() { StudentID = 5, StudentName = "Ron" , Age = 15 }
		};

		 
		bool areAllStudentsTeenAger = studentList.All(s => s.Age > 12 && s.Age < 20);


		Console.WriteLine(areAllStudentsTeenAger);
	}
}
public class S
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
}