using System;
using System.Linq;
using System.Collections.Generic;

public class SkipEx
{
	public void sk()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

		var result = strList.Skip(2);

		foreach (var str in result)
			Console.WriteLine(str);

	}
}