using System;

namespace Projecteuler15
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 20;
			long[,] table = new long[n+2, n+2];

			table [1, 1] = 1;
			for (int i = 1; i < n+2; i++) {
				for (int j = 1; j < n+2; j++) {
					table [i, j] += table [i - 1, j] + table [i, j - 1];
				}
			}

			Console.WriteLine (table [n + 1, n + 1]);
		}
	}
}
