﻿using System;
using System.Linq;
using System.Collections.Generic;


public class Distinct
{ 
	public void dist()
	{
		IList<string> strList = new List<string>() { "One", "Two", "Three", "Two", "Three" };

		IList<int> intList = new List<int>() { 1, 2, 3, 2, 4, 4, 3, 5 };

		var distinctList1 = strList.Distinct();

		foreach (var str in distinctList1)
			Console.WriteLine(str);

		var distinctList2 = intList.Distinct();

		foreach (var i in distinctList2)
			Console.WriteLine(i);

	}
}
