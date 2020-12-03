using System;
using System.Linq;
using System.Collections.Generic;

public class Except
{ 
	public void exe()
	{
		IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four", "Five" };
		IList<string> strList2 = new List<string>() { "Four", "Five", "Six", "Seven", "Eight" };

		var result = strList1.Except(strList2);

		foreach (string str in result)
			Console.WriteLine(str);
	}
}