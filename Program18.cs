using System;

namespace Projecteuler18
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string readString="";
			int[,] table = new int[16,16]; // I use 16*16 array to prevent comparing with a negative array index (thus the first column and row consists of 0s)
			int maxNum = 0;

			for (int i = 1; i < 16; i++) {
				//Reading from the screen and splitting it
				readString = Console.ReadLine ();
				string[] readStringArray = readString.Split (' ');

				//Putting the read numbers to the array diagonally
				for (int j = 0; j < i; j++) {
					table [i - j, j + 1] = Max (table [i - j - 1, j + 1], table [i - j, j]) + Convert.ToInt32 (readStringArray [j]);
				}
			}

			//Searching for max number diagonally
			for (int i = 1; i < 16; i++) {
				maxNum = Max(maxNum,table[16-i,i]);
			}

			Console.WriteLine ();
			Console.WriteLine (maxNum);
		}


		static public int Max(int a, int b){
			return a > b ? a : b;
		}
	}
}
