using System;

namespace Projecteuler2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int co,ce,lo=1,le=2; // co: current odd // ce: current even // lo: last odd // le: last even
			int sum = 0; // the sum of the even fibonacchi numbers

			while(le <= 4000000){
				sum += le;
				co = 2 * le + lo;
				ce = 3 * le + 2 * lo;
				le = ce;
				lo = co;

			}

			Console.WriteLine (sum);
		}
	}
}
