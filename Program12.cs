using System;
using System.Collections.Generic;

namespace Projecteuler12
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int divisors=0;
			int sum = 0;

			for (int i = 1; divisors <= 500; i++) {
				divisors = 0;
				sum += i;
				double sqroot = Math.Sqrt (sum);
				for (int j = 1; j < sqroot; j++) {
					if (sum % j == 0) {
						divisors += 2;
					}

				}

				if (sqroot * sqroot == sum) {
					divisors--;
				}
			}
			Console.WriteLine (sum);
		}
	}
}
