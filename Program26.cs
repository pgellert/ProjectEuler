using System;
using System.Collections.Generic;

namespace Projecteuler26
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int num = 0;
			List<int> cNumber = new List<int> ();
			bool found = false , b = false;
			int longestIndex=0, longestLength=0;

			for (int i = 2; i < 1000; i++) {
				num = 10;
				cNumber.Clear ();
				found = false;
				while (num != 0 && !found) {
					cNumber.Add(num % i);
					for (int j = 0; j < cNumber.Count; j++) {
						for (int k = 1; j + 2*k+1<cNumber.Count; k++) {
							b = true;
							for (int m = j; m < j+k; m++) {
								if (cNumber [m] != cNumber [m+k]) { b = false; break; }
							}
							if (b) {
								/*Console.Write("-- 1/{0} j:{1} length:{2} - ", i, j, k);
								foreach (var item in cNumber) {
									Console.Write(item+" ");
								}
								Console.WriteLine ();*/
								if (k > longestLength) {
									longestIndex = i;
									longestLength = k;
								}
								found = true;
							} /*else {
								foreach (var item in cNumber.GetRange(j,k)) {
									Console.Write (item);
								}
								Console.Write (" -- ");
								foreach (var item in cNumber.GetRange(j+k+1,k)) {
									Console.Write (item);
								}
								Console.WriteLine ();
							}*/

						}
					}
					num = (num % i) * 10;	
					//Console.WriteLine ("index:{0} num:{1}",i,num);
				}

			}
			Console.WriteLine (longestIndex);
		}
	}
}
