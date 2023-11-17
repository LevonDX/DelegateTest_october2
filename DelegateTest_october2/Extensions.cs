using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTest_october2
{
	// Func - returns T
	// Action - returns void
	// Predicate - returns bool

	static class Extensions
	{
		public static IEnumerable<T> GetElementsByCondition<T>(this IEnumerable<T> array, 
			Predicate<T> condition)
		{
			foreach (T element in array)
			{
				if (condition(element))
				{
					yield return element;
				}
			}
		}		

		public static void Show<T>(this IEnumerable<T> array)
		{
			foreach (T element in array)
				Console.WriteLine(element);
		}
	}
}
