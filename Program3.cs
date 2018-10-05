using System;

namespace Projecteuler3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long n = 600851475143;
			long lpf = 0; // lpf:larges prime factor
			long i=2;

			while (i <= n) {
				if (n % i == 0) {
					lpf = i;
					n /= i;
					i = 2;
				}
				i++;
			}

			Console.WriteLine (lpf);
		}
	}
}
