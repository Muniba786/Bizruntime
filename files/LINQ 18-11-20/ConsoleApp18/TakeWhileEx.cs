using System;
using System.Linq;
using System.Collections.Generic;

public class TakeWhileEx
{
	public void tkw()
	{
		IList<string> strList = new List<string>() { "Three", "Four", "Five", "Hundred" };

		var newList = strList.TakeWhile(s => s.Length > 4);

		foreach (var str in newList)
			Console.WriteLine(str);

	}
}