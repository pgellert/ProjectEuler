using System;
using System.Text;

namespace Projecteuler37
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;

			long sum = 0;
			const UInt16 maxCount = 11;
			UInt16 count = 0;

			long i = 9;

			while (count < maxCount) {
				if (IsPrime (i)) {
					if (IsGoodNumberFromLeft (i) && IsGoodNumberFromRight (i)) {
						count++;
						Console.WriteLine ("{0}. Good Number: {1}",count,i);
						sum += i;
					}
				}

				i+=2;
			}

			Console.WriteLine ("Sum: {0}",sum);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static bool IsGoodNumberFromRight (long num){
			while (num > 9) {
				num = (num - num % 10) / 10;
				if (!IsPrime (num)) {
					return false;
				}
			}
			return true;
		}

		public static bool IsGoodNumberFromLeft (long num){
			for (int i = 1; i < Math.Log10 (num); i++) {
				if (!IsPrime (num % (long)Math.Pow (10, i))) {
					return false;
				}
			}
			return true;
		}

		public static bool IsPrime(long num){
			if (num == 1) {
				return false;
			} else if (num == 2) {
				return true;
			} else if (num % 2 == 0) {
				return false;
			}

			for (int i = 3; i <= Math.Sqrt (num); i += 2) {
				if (num % i == 0) {
					return false;
				}
			}
			return true;
		}
	}
}
