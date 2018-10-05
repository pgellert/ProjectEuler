using System;
using System.Text;

namespace Projecteuler43
{
	class MainClass
	{
		static int[] permutation = {1,0,2,3,4,5,6,7,8,9};
		static long[] divisors = { 2, 3, 5, 7, 11, 13, 17 };
		static long[] tenPowers = { 1, 10, 100, 1000, 10000, 100000, 1000000 };
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;
			long sum = 0;

			int counter = 1;
			int numberOfPermutations = 3265920;

			while(counter++ < numberOfPermutations) {
				long value = Value (permutation);
				if (HasRightProperty (value)) {
					sum += value;
					Console.WriteLine (value);
				}

				int i = permutation.Length - 1;
				while (permutation[i - 1] >= permutation[i]) {
					i = i - 1;
				}

				int j = permutation.Length;
				while (permutation[j - 1] <= permutation[i - 1]) {
					j = j - 1;
				}
				SwapPermutation(i-1,j-1);


				i++;
				j = permutation.Length;
				while (i < j) {
					SwapPermutation(i - 1, j - 1);
					i++;
					j--;
				}


			}

			Console.WriteLine ("Solution: {0}",sum);
			Console.WriteLine ("Time: {0}ms",Environment.TickCount-time);
		}

		public static long Value (int[] p){
			StringBuilder s = new StringBuilder ();
			foreach (var item in p) {
				s.Append (item.ToString ());
			}
			return long.Parse (s.ToString ());
		}

		public static void SwapPermutation (int i, int j){
			int temp = permutation [i];
			permutation [i] = permutation[j];
			permutation [j] = temp;
		}

		public static bool HasRightProperty(long num){
			for (int i = 0; i < 7; i++) {
				if (((num / tenPowers [6-i]) % 1000) % divisors [i] != 0) {
					return false;
				}
			}
			return true;
		}
	}
}
