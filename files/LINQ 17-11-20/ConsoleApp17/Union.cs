using System;
using System.Linq;
using System.Collections.Generic;

public class Union
{
	public void uni()
	{
		IList<string> strList1 = new List<string>() { "One", "Two", "three", "Four" };
		IList<string> strList2 = new List<string>() { "Two", "THREE", "Four", "Five" };

		var result = strList1.Union(strList2);

		foreach (string str in result)
			Console.WriteLine(str);
	}
}