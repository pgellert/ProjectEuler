using System;
using System.Collections.Generic;

namespace Projecteuler27
{
	class MainClass
	{
		const int maxNumber = 1000; 
		static bool[] listOfPrimes = new bool[maxNumber];

		public static void Main (string[] args)
		{
			int maxNumberOfPrimes = 0;
			int maxNumberOfPrimesProduct = 0;
			int a = 0, b = 0, n = 0;
			int numberOfPrimes = 0;

			int time = Environment.TickCount;

			for (int i = 2; i < maxNumber/2; i++) {
				for (int j = i; j < 1000; j+=i) {
					listOfPrimes [j] = true;
				}
			}

			for (int index = 0; index < 1000; index++) {
				if (!listOfPrimes [index]) {
					b = index;
					for (a = 2 - b; a < 1000; a += 2) {
						numberOfPrimes = 0;
						n = 0;
						while (true) {
							if (isPrime (n * (n + a) + b)) {
								numberOfPrimes++;
								n++;
							} else {
								break;
							}
						}
						if (numberOfPrimes > maxNumberOfPrimes) {

							maxNumberOfPrimes = numberOfPrimes;
							maxNumberOfPrimesProduct = a * b;
						}
					}
				}
			}

			//Console.WriteLine ("Total time: {0}ms",Environment.TickCount - time);
			Console.WriteLine (maxNumberOfPrimesProduct);

		}

		public static bool isPrime(int num){
			if (num < 0) {
				return false;
			}
			if (num < 1000) {
				if (!listOfPrimes [num]) {
					return true;
				} else {
					return true;
				}
			} else {
				for (int i = 2; i <= Math.Sqrt(num); i++) {
					if (num % i == 0) {
						return false;
					}
				}
				return true;
			}
		}
	}
}
