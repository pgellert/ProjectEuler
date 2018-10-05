using System;

namespace Projecteuler9
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a=0, b=0, c=0;
			for (a = 1; a < 334; a++) {
				for (b = a+1; b < (1000-a)/2; b++) {
					c = 1000 - (a + b);
					if (a * a + b * b == c * c) {
						Console.WriteLine(a*b*c);
					}
				}
			}
		}
	}
}
