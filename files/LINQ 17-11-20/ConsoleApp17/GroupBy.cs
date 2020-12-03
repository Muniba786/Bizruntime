using System;
using System.Linq;
using System.Collections.Generic;


public class GroupBy
{
	public void group()
	{
		
		IList<Stu> studentList = new List<Stu>() {
				new Stu() { StudentID = 1, StudentName = "John", Age = 18 } ,
				new Stu() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
				new Stu() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Stu() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
				new Stu() { StudentID = 5, StudentName = "Ron" , Age = 21 }
			};

		var groupedResult = from s in studentList
							group s by s.Age;

		    
		foreach (var ageGroup in groupedResult)
		{
			Console.WriteLine("Age Group: {0}", ageGroup.Key); 

			foreach (Stu s in ageGroup) 
				Console.WriteLine("Student Name: {0}", s.StudentName);
		}

	}

}

public class Stu
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}