using System;
using System.Linq;


public class EmptyEx
{
	public void empt()
	{
		var emptyCollection1 = Enumerable.Empty<string>();
		var emptyCollection2 = Enumerable.Empty<Student>();

		Console.WriteLine("Type: {0}", emptyCollection1.GetType().Name);
		Console.WriteLine("Count: {0}", emptyCollection1.Count());

		Console.WriteLine("Type: {0}", emptyCollection2.GetType().Name);
		Console.WriteLine("Count: {0}", emptyCollection2.Count());

	}
}

public class Stud
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }

}