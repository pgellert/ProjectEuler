using System;

namespace Projecteuler34
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;

			int[] digitFactorials = new int[10];
			digitFactorials [0] = 1;
			for (int i = 1; i < 10; i++) {
				digitFactorials [i] = digitFactorials [i - 1] * i;
			}

			int sum = 0;

			for (int i = 3; i < 100000; i++) {
				int factorialValue = 0;

				string number = i.ToString ();
				for (int j = 0; j < number.Length; j++) {
					factorialValue += digitFactorials [((int)number [j])-48];
				}
				if (factorialValue == i) {
					sum += i;
					//Console.WriteLine ("{0}", i);
				}
			}

			Console.WriteLine ("Sum: {0}",sum);

			Console.WriteLine ("Time needed: {0}ms",Environment.TickCount - time);
		}
	}
}
