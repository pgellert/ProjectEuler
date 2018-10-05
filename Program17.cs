using System;

namespace Projecteuler17
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int sum = 0;

			int[] l1 = { 3, 3, 5, 4, 4, 3, 5, 5, 4, 3, 6, 6, 8, 8, 7, 7, 9, 8, 8 };
			int[] l2 = { 6, 6, 5, 5, 5, 7, 6, 6 };

			for (int i = 1; i < 1000; i++) {
				if (i >= 100) {
					sum += 7; // hundred : 7
					sum += l1[((i-(i%100))/100) - 1]; // ie.: three hundred -> three : 5
					if (i % 100 != 0) {
						sum += 3; // and : 3
					}
				}
				if(i%100!=0){
					if (i % 100 < 20) {
						sum += l1 [(i % 100) -1]; // length of last two numbers if it is less than 20
					} else {
						sum += l2 [(((i % 100) - (i % 10)))/10 - 2]; // the number on the second place
						if (i % 10 != 0) {
							sum += l1 [(i % 10) - 1]; // the last number
						}
					}
				}
			}
			sum += 11; // one thousand : 11
			Console.WriteLine (sum);
		}
	}
}