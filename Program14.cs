using System;

namespace Projecteuler14
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 1000000;
			long length = 0;
			long mlength = 0;
			int maxNum = 0;
			for (int i = 0; i < n; i++) {
				long x = i;
				length = 0;
				while (x > 1) {
					if (x % 2 == 0) {
						x /= 2;
						length++;

					} else {
						x = 3 * x + 1;
						length++;
					}
				}
				if (length >= mlength) {
					mlength = length;
					maxNum = i;
				}

			}

			Console.WriteLine ("Length:{0}  Number:{1}",mlength,maxNum);
		}
	}
}
