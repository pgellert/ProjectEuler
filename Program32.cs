using System;
using System.Collections.Generic;

namespace Projecteuler32
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> unusualNumbers = new List<int> ();
			int sum = 0;

			for (int i = 2; i < 10000; i++) {
				List<int> digits = new List<int> ();
				for (int j = 1; j < 10; j++) {
					digits.Add (j);
				}

				int num = i;
				bool iIsGood = true;

				do {
					if(!digits.Contains(num % 10)){
						iIsGood = false;
					}
					digits.Remove (num % 10);
				} while((num = (num - (num % 10)) / 10) > 0);

				if (iIsGood) {
					
				

					for (int j = 2; j < 1000; j++) {
						//Console.WriteLine ("{0} * {1} = {1}", i, j, i * j);

						List<int> currentDigits = new List<int> ();
						foreach (var item in digits) {
							currentDigits.Add (item);
							//Console.Write (item + " ");
						}
						//Console.WriteLine ();

						num = j;
						bool productIsGood = true;
						bool jIsGood = true;

						do {
							if (!currentDigits.Contains (num % 10)) {
								jIsGood = false;
							}
							currentDigits.Remove (num % 10);
						} while((num = (num - (num % 10)) / 10) > 0);

						if (!jIsGood) {
							//Console.WriteLine ("Bad number because of j");
							continue;
						}

						num = i * j;

						do {
							if (currentDigits.Contains (num % 10)) {
								currentDigits.Remove (num % 10);
							} else {
								productIsGood = false;
							}
						} while((num = (num - (num % 10)) / 10) > 0);

						if (currentDigits.Count == 0 && productIsGood && !unusualNumbers.Contains (i * j)) {
							//Console.WriteLine ("Added to the list");
							Console.WriteLine ("{0} * {1} = {2}", i, j, i * j);
							unusualNumbers.Add (i * j);
						} else {
							//Console.WriteLine ("Bad number because of the product");
						}

					}
				}
			}

			foreach (var item in unusualNumbers) {
				sum += item;
			}
			Console.WriteLine (sum);
		}
	}
}
