using System;
using System.Linq;
using System.Collections;

public class OfType
{
	public void ofty()
	{
		IList mixedList = new ArrayList();
		mixedList.Add(0);
		mixedList.Add("One");
		mixedList.Add("Two");
		mixedList.Add(3);
		mixedList.Add(new Std() { StudentID = 1, StudentName = "Bill" });

		var stringResult = from s in mixedList.OfType<string>()
						   select s;

		var intResult = from s in mixedList.OfType<int>()
						select s;

		var stdResult = from s in mixedList.OfType<Student>()
						select s;

		foreach (var str in stringResult)
			Console.WriteLine(str);

		foreach (var integer in intResult)
			Console.WriteLine(integer);

		foreach (var std in stdResult)
			Console.WriteLine(std.StudentName);

	}
}

public class Std
{

	public int StudentID { get; set; }
	public string StudentName { get; set; }
	public int Age { get; set; }

}