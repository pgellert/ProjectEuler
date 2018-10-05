using System;
using System.Globalization;
using System.Numerics;

namespace Projecteuler16
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			BigInteger powerNumber = new BigInteger ();
			int sumOfDigits = 0;

			powerNumber = ToThePowerOfThousand(2);

			while (powerNumber > 0) {
				sumOfDigits += (int)(powerNumber % 10);
				powerNumber = (powerNumber - powerNumber % 10) / 10;
			}

			Console.WriteLine (sumOfDigits);
		}

		static public BigInteger ToThePowerOfTwo(BigInteger a){
			return a * a;
		}

		static public BigInteger ToThePowerOfFive(BigInteger a){
			return a * a * a * a * a;
		}

		static public BigInteger ToThePowerOfThousand(BigInteger a){
			return ToThePowerOfTwo (ToThePowerOfTwo (ToThePowerOfTwo (ToThePowerOfFive (ToThePowerOfFive (ToThePowerOfFive (a))))));
		}
	}
}
