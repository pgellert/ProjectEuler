using System;

namespace Projecteuler33
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double numerator = 1;
			double denominator = 1;


			for (double i = 11; i < 100; i++) {

				if (i % 10 == 0) {
					continue;
				}

				for (double j = 10; j < i; j++) {
					double iFirstDigit = (i - (i % 10)) / 10;
					double iSecondDigit = i % 10;
					double jFirstDigit = (j - (j % 10)) / 10;
					double jSecondDigit = j % 10;

					if (jSecondDigit == 0) {
						continue;
					}

					if (jSecondDigit == iFirstDigit) {
						if (jFirstDigit / iSecondDigit == j / i) {
							//Console.WriteLine ("{0}/{1} = {2}/{3}", jFirstDigit, iSecondDigit, j, i);
							numerator *= jFirstDigit;
							denominator *= iSecondDigit;
						}
					}
				}
			}

			Console.WriteLine (denominator / (GCD(numerator,denominator)));
		}

		public static double GCD(double Number1,double Number2){
			double a = 0, b = 0;
			if (Number1 > Number2) {
				a = Number2;
				b = Number1;
			} else {
				b = Number2;
				a = Number1;
			}

			double remainder = b % a;

			if (remainder != 0) {
				while (remainder != 0) {
					remainder = b % a;
					b = a;
					a = remainder;
				}
			} else {
				b = a;
			}

			return b;
		}
	}
}
