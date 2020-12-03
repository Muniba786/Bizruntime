using System;
using System.Linq;
using System.Collections.Generic;

public class SkipWhileEx
{
	public void skw()
	{
		IList<string> strList = new List<string>() {
											"One",
											"Two",
											"Three",
											"Four",
											"Five",
											"Six"  };

		var result = strList.SkipWhile(s => s.Length < 4);

		foreach (string str in result)
			Console.WriteLine(str);

	}
}