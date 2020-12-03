using System;
using System.Linq;
using System.Collections.Generic;


public class Where
{
	public void where()
	{
		
		IList<Stut> studentList = new List<Stut>() {
				new Stut() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Stut() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
				new Stut() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
				new Stut() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Stut() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};

		
		var teenAgerStudent = from s in studentList
							  where s.Age > 12 && s.Age < 20
							  select s;
		Console.WriteLine("Teen age Students:");

		foreach (Stut std in teenAgerStudent)
		{
			Console.WriteLine(std.StudentName);
		}
	}
}

public class Stut
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}