using System;
using System.Collections.Generic;

namespace Projecteuler21
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sumOfAllAmicableNumbers = 0;

			for (int i = 1; i < 10000; i++) {
				if (i != SumOfDivisors (i) && SumOfDivisors (SumOfDivisors (i)) == i) {
					sumOfAllAmicableNumbers += i;
				}
			}

			Console.WriteLine (sumOfAllAmicableNumbers);
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
