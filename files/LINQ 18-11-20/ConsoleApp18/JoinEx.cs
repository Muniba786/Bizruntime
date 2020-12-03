using System;
using System.Linq;
using System.Collections.Generic;


public class JoinEx
{
	public void jon()
	{
		
		IList<string> strList1 = new List<string>() {
			"One",
			"Two",
			"Three",
			"Four"
			};

		IList<string> strList2 = new List<string>() {
			"One",
			"Two",
			"Five",
			"Six"
			};

		var innerJoinResult = strList1.Join(
					  strList2,  
					  str1 => str1,    
					  str2 => str2, 
					  (str1, str2) => str1);

		foreach (var str in innerJoinResult)
		{
			Console.WriteLine("{0} ", str);
		}

	}
}
