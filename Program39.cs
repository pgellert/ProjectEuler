using System;

namespace Projecteuler39
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;
			double twoPlusSqrtTwo = 2 + Math.Sqrt (2);

			int maxNumberOfSolutions = 0;
			int maxP = -1;

			for (int p = 0; p <= 1000; p++) {
				int numberOfSolutions = 0;
				double maxA = p / twoPlusSqrtTwo;
				for (int a = 0; a < maxA; a++) {
					double maxB = (p - a) / 2;
					for (int b = a; b < maxB; b++) {
						if (Math.Sqrt (a * a + b * b) + a + b == p) {
							Console.WriteLine ("{3} : ({0},{1},{2})",a,b,p-(a+b),p);
							numberOfSolutions++;
						}
					}
				}

				if (numberOfSolutions > maxNumberOfSolutions) {
					maxNumberOfSolutions = numberOfSolutions;
					maxP = p;
				}
			}

			Console.WriteLine ("Best p: {0}",maxP);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}
	}
}
