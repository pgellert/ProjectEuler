using System;

namespace Projecteuler30
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = 0, value = 0;
			int sum = 0;
			const int power = 5;
			for (int i = 2; i < 354294; i++) {
				num = i;
				value = 0;
				while (num > 0) {
					value += (int)Math.Pow (num % 10, power);
					num /= 10;
				}
				if(i == value){
					sum += i;
				}
			}
			Console.WriteLine (sum);
		}
	}
}
