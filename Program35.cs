using System;
using System.Collections.Generic;
using System.Text;

namespace Projecteuler35
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			const int maxNumber = 1000000;
			long count = 1;
			int time = Environment.TickCount;
			for (int i = 3; i < maxNumber; i+=2) {
				
				if(IsPrime(i)){
					bool goodNumber = true;
				string s = i.ToString ();
				for (int j = 0; j < s.Length; j++) {
					if(!IsPrime(int.Parse (s.Substring (j) + s.Substring (0, j)))){
						goodNumber = false;
						break;
					}
				}
					if(goodNumber){
						count++;
						Console.WriteLine (i);
					}
				}


			}

			Console.WriteLine ("Count: {0}",count);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static bool IsPrime(int num){
			if (num % 2 == 0) {
				return false;
			}

			for (int i = 3; i <= Math.Sqrt (num); i += 2) {
				if (num % i == 0) {
					return false;
				}
			}
			return true;
		}
	}
}
