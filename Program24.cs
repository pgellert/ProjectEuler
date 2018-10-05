using System;
using System.Collections.Generic;

namespace Projecteuler24
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbersList = new List<int> ();
			for (int i = 0; i < 10; i++) {
				numbersList.Add (i);
			}

			int index;
			int place = 999999;
			int currentFactorial = 9;
			int sum=0;

			for (int i = 0; i < 10; i++) {
				index = 0;
				while(sum + Factorial (currentFactorial) <= place){
					sum += Factorial (currentFactorial);
					index++;
				}
				Console.Write (numbersList[index]);
				numbersList.RemoveAt (index);
				currentFactorial--;
			}
		}

		static public int Factorial(int n){
			int i = 1;
			while (n > 1) {
				i *= n--;
			}
			return i;
		}
	}
}
