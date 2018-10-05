using System;

namespace Projecteuler6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = 100, diff=0,sumOfSquares=0,squareOfSum=0;

			for (int i = 1; i <= n; i++) {
				squareOfSum += i;
			}
			squareOfSum = squareOfSum * squareOfSum;

			for (int i = 1; i <= n; i++) {
				sumOfSquares += (i * i);
			}

			diff = squareOfSum - sumOfSquares;
			Console.WriteLine (sumOfSquares);
			Console.WriteLine (squareOfSum);
			Console.WriteLine (diff);
		}


	}
}
