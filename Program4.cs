using System;

namespace Projecteuler4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i, j, max = 0;
			for (i = 999; i > 99; i--) {
				for (j = 999; j > 99; j--) {
					if (i * j > max) {
						if (IsPalindrome (i * j)) {
							max = i * j;
						}
					} else {
						j=99;
					}
				}
			}

			Console.WriteLine (max);


		}

		static bool IsPalindrome(int number){
			bool b = true;

			if ((number - (number % 100000))/100000 == number % 10) {
			} else {
				b = false;
			}

			if (((number % 100000) - (number % 10000))/10000 == ((number % 100) - (number % 10))/10) {
			} else {
				b = false;
			}

			if (((number % 10000) - (number % 100)) % 11 == 0) {
			} else {
				b = false;
			}

			return b;
		}
	}
}
