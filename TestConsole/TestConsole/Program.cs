using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
	class MergeNames
	{
		public static string[] UniqueNames(string[] names1, string[] names2)
		{
			Dictionary<string,bool> valuePairs=new Dictionary<string, bool>();
			foreach (var item in names1)
			{
				valuePairs.Add(item,true);
			}

			foreach (var item in names2)
			{
				if(!valuePairs.ContainsKey(item))
					valuePairs.Add(item, true);
			}

			return valuePairs.Keys.ToArray();
		}
		static void Main(string[] args)
		{
			string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
			string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
			Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
		}
	}
}
