using System;
using System.Linq;
using System.Collections.Generic;


public class ThenBy
{ 
	public void then()
	{

		IList<S> studentList = new List<S>() {
				new S() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new S() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
				new S() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
				new S() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new S() { StudentID = 5, StudentName = "Ron" , Age = 19 }
			};

		var thenByResult = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);

		var thenByDescResult = studentList.OrderBy(s => s.StudentName).ThenByDescending(s => s.Age);

		Console.WriteLine("ThenBy:");

		foreach (var std in thenByResult)
			Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

		Console.WriteLine("ThenByDescending:");

		foreach (var std in thenByDescResult)
			Console.WriteLine("Name: {0}, Age:{1}", std.StudentName, std.Age);

	}

}

public class S
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}