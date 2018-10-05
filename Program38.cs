using System;
using System.Text;
using System.Collections.Generic;

namespace Projecteuler38
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;
			long max = 0;
			StringBuilder sb = new StringBuilder ();

			//Console.WriteLine (IsPandigital(123456789.ToString()));

			for (long i = 1; i < 10000; i++) {
				sb.Clear ();
				long j = 1;
				do {
					sb.Append (j * i);
					j++;
					//Console.WriteLine (sb.ToString() + " - " + sb.Length);
				} while (sb.Length < 9);
				//Console.WriteLine ("-----");
				if (IsPandigital (sb.ToString ())) {
					Console.WriteLine ("{0} (1,...,{1}) : {2}",i,j-1,sb.ToString());
					if (long.Parse(sb.ToString ()) > max) {
						max = long.Parse (sb.ToString ());
					}
				}
			}
			Console.WriteLine ("Max: {0}",max);

			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static bool IsPandigital(string s){
			bool[] digits = new bool[9];

			for (int i = 0; i < s.Length;i++) {
				if (s [i] == 48) {
					return false;
				} else if (!digits[s [i]-49]) {
					digits[s [i]-49] = true;
				} else {
					return false;
				}
			}
			return true;
		}
	}
}
