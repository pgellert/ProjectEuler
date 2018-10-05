using System;
using System.Text;

namespace Projecteuler40
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;

			StringBuilder sb = new StringBuilder ();
			int i = 1;
			do {
				sb.Append(i);
				i++;
			} while (sb.Length < 1000000);

			string s = sb.ToString ();
			int value = 1;

			for (i = 0; i < 7; i++) {
				value *= s [(int)Math.Pow (10, i) - 1] - 48;
			}

			Console.WriteLine ("Product: {0}",value);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}
	}
}
