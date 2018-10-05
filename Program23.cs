using System;
using System.Collections.Generic;

namespace Projecteuler23
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> l = new List<int>();
			long sum = 0;
			bool existsTwoAbundantNums = false;


			for (int i = 0; i <= 28123; i++) {
				if (SumOfDivisors (i) > i) {
					l.Add (i);
				}
				existsTwoAbundantNums = false;

				for (int j = 0; j < l.Count/2 && !existsTwoAbundantNums; j++) {
					if (l.Contains (i - l [j])) {
						existsTwoAbundantNums = true;
					}
				}

				if (!existsTwoAbundantNums) {
					sum += i;
				}
			}

			Console.WriteLine (sum);
		}

		static public int SumOfDivisors(int a){
			int sqroot = (int)Math.Sqrt (a);
			int sum = 0;

			for (int i = 1; i <= sqroot; i++) {
				if (a % i == 0) {
					sum += i + a / i;
				}
			}

			if (sqroot * sqroot == a) {
				sum-=sqroot;
			}

			sum -= a;

			return sum;
		}
	}
}
