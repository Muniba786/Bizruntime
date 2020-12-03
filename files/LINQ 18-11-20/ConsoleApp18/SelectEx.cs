using System;
using System.Linq;
using System.Collections.Generic;


public class SelectEx
{
	public void sel()
	{
		
		IList<Stu> studentList = new List<Stu>() {
				new Stu() { StudentID = 1, StudentName = "John" } ,
				new Stu() { StudentID = 2, StudentName = "Moin" } ,
				new Stu() { StudentID = 3, StudentName = "Bill" } ,
				new Stu() { StudentID = 4, StudentName = "Ram" } ,
				new Stu() { StudentID = 5, StudentName = "Ron"  }
			};

		var selectResult = from s in studentList
						   select s.StudentName;

		foreach (var name in selectResult)
		{
			Console.WriteLine(name);
		}
	}
}

public class Stu
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
}