using System;
using System.Collections.Generic;

namespace Projecteuler19
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> l1 = new List<int>();
			List<int> l2 = new List<int> ();
			InitializeLists (l1, l2);

			int counter = 0;
			int day = 1;
			for (int i = 1; i <= 1200; i++) {
				if (day % 7 == 6) {
					counter++;
				}
				if (l1.Contains (i % 12)) {
					day += 30;
				} else if (l2.Contains (i % 12)) {
					day += 31;
				} else {
					if ((i - 2) % 4 == 0) {
						day += 29;
					} else {
						day += 28;
					}
				}
			}

			Console.WriteLine (counter);
		}

		static void InitializeLists(List<int> l1,List<int> l2){
			l1.Add(4);
			l1.Add(6);
			l1.Add(9);
			l1.Add(11);
			l2.Add(1);
			l2.Add(3);
			l2.Add(5);
			l2.Add(7);
			l2.Add(8);
			l2.Add(10);
			l2.Add(12);
		}
	}
}
