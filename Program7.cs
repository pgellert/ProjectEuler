using System;

namespace ProjectEuler7
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] a = new int[10001];
			int k = 0; 		//array index
			int i = 2; 		//current number
			bool b;
			for (;k<10001;) {
				for (k=0,b=true;b;k++) {
					if (a [k] == 0) {
						a [k] = i;
						b = false;
					} else if (i % a [k] == 0) {
						b = false;
					}
				}
				i++;
			}
			Console.WriteLine (a [10000]);
		}
	}
}
