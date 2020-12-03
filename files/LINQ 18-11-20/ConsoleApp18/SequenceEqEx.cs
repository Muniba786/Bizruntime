using System;
using System.Linq;
using System.Collections.Generic;

public class SequenceEqEx
{
	public void seq()
	{
		IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

		IList<string> strList2 = new List<string>() { "One", "Two", "Three", "Four", "Three" };

		bool isEqual = strList1.SequenceEqual(strList2);

		Console.WriteLine(isEqual);

	}
}