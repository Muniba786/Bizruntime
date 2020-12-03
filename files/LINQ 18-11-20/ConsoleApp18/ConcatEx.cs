using System;
using System.Linq;
using System.Collections.Generic;

public class ConcatEx
{
	public void cnt()
	{
		IList<string> collection1 = new List<string>() { "One", "Two", "Three" };
		IList<string> collection2 = new List<string>() { "Five", "Six" };

		var concateResult = collection1.Concat(collection2);

		foreach (string str in concateResult)
			Console.WriteLine(str);

	}
}