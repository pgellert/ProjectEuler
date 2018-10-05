using System;

namespace ProjectEuler10
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[500000];
			long sumOfPrimes = 0;
			int k = 0; 		//array index
			int i = 2; 		//current number
			bool b;
			for (;i<2000000;) {
				for (k=0,b=true;b;k++) {
					if (a [k] == 0) {
						a [k] = i;
						sumOfPrimes += i;
						b = false;
					} else if (i % a [k] == 0) {
						b = false;
					}
				}
				i++;
			}
			Console.WriteLine (sumOfPrimes);
		}
	}
}