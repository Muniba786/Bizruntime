using System;
using System.Linq;
using System.Collections.Generic;


public class AnyEx
{
	public void any()
	{
		IList<St> studentList = new List<St>() {
			new St() { StudentID = 1, StudentName = "John", Age = 13 } ,
			new St() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
			new St() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
			new St() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
			new St() { StudentID = 5, StudentName = "Ron" , Age = 15 }
		};

		  
		bool isAnyStudentTeenAger = studentList.Any(s => s.Age > 12 && s.Age < 20);


		Console.WriteLine(isAnyStudentTeenAger);
	}
}

public class St
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }
}
