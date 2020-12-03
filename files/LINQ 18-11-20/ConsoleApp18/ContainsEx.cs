using System;
using System.Collections.Generic;

public class ContainsEx
{
	public void con()
	{
		IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };

		bool result = intList.Contains(10);

		Console.WriteLine(result);

	}
}