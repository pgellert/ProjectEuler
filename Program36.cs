using System;
using System.Text;

namespace Projecteuler36
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;

			long sum = 0;
			const int maxNum = 1000000;

			//Console.WriteLine (ToBinary(21));
			//Console.WriteLine (IsPalindrome(ToBinary(21)));

			for (int i = 0; i < maxNum; i++) {
				if (IsPalindrome (i.ToString ()) && IsPalindrome (ToBinary (i))) {
					Console.WriteLine (i);
					sum += i;
				}
			}

			Console.WriteLine ("Sum: {0}",sum);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static bool IsPalindrome(string s){
			for (int i = 0; i < s.Length/2; i++) {
				//Console.WriteLine ("{2}: {0} {1}",s[i],s[s.Length-1-i],i);
				if (s [i] != s [s.Length - 1 - i]) {
					return false;
				}
			}
			return true;
		}

		public static string ToBinary(int num){
			StringBuilder sb = new StringBuilder ();

			do {
				sb.Insert(0,num%2);
				//sb.Append(num%2);
			} while((num/=2) > 0);

			return sb.ToString();
		}
	}
}
