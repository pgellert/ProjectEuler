using System;

namespace Projecteuler28
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sum = 1;
			for (int i = 1; i <= 500; i++) {
				sum += 4 * (2*i-1) * (2*i-1) + 20 * i;
			}
			Console.WriteLine (sum);
		}
	}
}
