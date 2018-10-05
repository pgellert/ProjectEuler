using System;
using System.Globalization;
using System.Numerics;

namespace Projecteuler20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			BigInteger myNumber = new BigInteger (1);
			int sumOfDigits = 0;

			for (int i = 2; i < 100; i++) {
				myNumber *= i;
			}

			while (myNumber > 0) {
				sumOfDigits += (int)(myNumber % 10);
				myNumber = (myNumber - myNumber % 10) / 10;
			}

			Console.WriteLine (sumOfDigits);
		}
	}
}
