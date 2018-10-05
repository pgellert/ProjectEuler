using System;

namespace Projecteuler41
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;

			//It cannot be an 8 or 9 digit number as if they are pandigital, they are divisible by 3 (1+2+...+8+9=45)
			long i = 9999999;

			while (true) {
				if (IsPrime (i)) {
					if (IsPandigital (i.ToString ())) {
						Console.WriteLine (i);
						break;
					}
				}
				i-=2;
			}

			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static bool IsPrime(long num){
			if (num % 2 == 0) {
				return false;
			}

			for (int i = 3; i <= Math.Sqrt (num); i += 2) {
				if (num % i == 0) {
					return false;
				}
			}
			return true;
		}

		public static bool IsPandigital(string s){
			bool[] digits = new bool[s.Length];

			for (int i = 0; i < s.Length;i++) {
				if (s [i] == 48) {
					return false;
				} else if (s [i]-48 > s.Length) {
					return false;
				} else if (!digits[s [i]-49]) {
					digits[s [i]-49] = true;
				} else {
					return false;
				}
			}
			return true;
		}
	}
}
