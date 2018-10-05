using System;
using System.Numerics;

namespace Projecteuler25
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			BigInteger a = 1, a1 = 1, temp = 0;

			BigInteger bigNumber = Power (10, 999);

			int i;

			for (i = 2; a<bigNumber; i++) {
				temp=a+a1;
				a1 = a;
				a = temp;

			}
			Console.WriteLine (i);
		}

		static public BigInteger Power(BigInteger x, int y){
			BigInteger value = 1;
			for (int i = 0; i < y; i++) {
				value *= x;
			}
			return value;
		}
	}
}
