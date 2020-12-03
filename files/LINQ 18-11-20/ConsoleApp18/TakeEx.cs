using System;
using System.Linq;
using System.Collections.Generic;

public class TakeEx
{
	public void tk()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Four", "Five" };

		var newList = strList.Take(2);

		foreach (var str in newList)
			Console.WriteLine(str);
	}
}