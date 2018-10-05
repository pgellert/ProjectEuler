using System;

namespace Projecteuler5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 20, number = 1;
			int[] primes = new int[8];


			for (int i = 2; i <= n; i++) {
				int[] currentNumberPrimes = new int[8];
				int j = i;
				while (j > 1) {
					if (j % 2 == 0) {
						currentNumberPrimes [0]++;
						j /= 2;
					} else if (j % 3 == 0) {
						currentNumberPrimes [1]++;
						j /= 3;
					} else if (j % 5 == 0) {
						currentNumberPrimes [2]++;
						j /= 5;
					} else if (j % 7 == 0) {
						currentNumberPrimes [3]++;
						j /= 7;
					} else if (j % 11 == 0) {
						currentNumberPrimes [4]++;
						j /= 11;
					} else if (j % 13 == 0) {
						currentNumberPrimes [5]++;
						j /= 13;
					} else if (j % 17 == 0) {
						currentNumberPrimes [6]++;
						j /= 17;
					} else {
						currentNumberPrimes [7]++;
						j /= 19;
					}
				}
				for (int k = 0; k < 8; k++) {
					primes[k]=primes[k]>currentNumberPrimes[k] ? primes[k] : currentNumberPrimes[k];
				}
			}
			for (int i = 0; i < 8; i++) {
				for (int j = 0; j < primes[i]; j++) {
					switch (i) {
					case 0:
						number *= 2;
						break;
					case 1:
						number *= 3;
						break;
					case 2:
						number *= 5;
						break;
					case 3:
						number *= 7;
						break;
					case 4:
						number *= 11;
						break;
					case 5:
						number *= 13;
						break;
					case 6:
						number *= 17;
						break;
					case 7:
						number *= 19;
						break;

					}

				}
			}
			Console.WriteLine (number);
		}
	}
}
