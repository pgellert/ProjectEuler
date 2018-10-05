using System;
using System.Collections.Generic;
using System.Numerics;

namespace ProjectEuler29
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 100;
			int b = 100;

			List<BigInteger> numbers = new List<BigInteger> ();

			for (int i = 2; i <= a; i++) {
				for (int j = 2; j <= b; j++) {
					BigInteger num = Power (i, j);
					if (!numbers.Contains (num)) {
						numbers.Add (num);
					}
				}
			}
			Console.WriteLine (numbers.Count);
		}

		public static BigInteger Power(int a, int b){
			BigInteger number = 1;
			for (int i = 0; i < b; i++) {
				number *= a;
			}
			return number;
		}
	}
}
