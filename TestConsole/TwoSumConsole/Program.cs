using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
	class Program
	{
		public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
		{
			var newList = list.Where(x => x < sum + 1).ToList();
			for (int i = 0; i < newList.Count; i++)
			{
				for (int j = 1; j < newList.Count; j++)
				{
					if (newList[i] + newList[j] == sum)
					{
						return new Tuple<int, int>(newList[i], newList[j]);
					}
				}
			}

			return null;
		}

		public static void Main(string[] args)
		{
			Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
			
			if (indices != null)
			{
				Console.WriteLine(indices.Item1 + " " + indices.Item2);
			}
		}
    }
}
