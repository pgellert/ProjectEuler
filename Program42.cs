using System;
using System.IO;
using System.Collections.Generic;

namespace Projecteuler42
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int time = Environment.TickCount;
			List<int> triangleNumbers = new List<int> ();
			triangleNumbers.Add (1);
			int lastN = 1;
			string data;
			using (StreamReader input = new StreamReader("p042_words.txt")) {
				data = input.ReadToEnd ();
			}

			char[] separators = {',','\"'};
			string[] words = data.Split (separators,StringSplitOptions.RemoveEmptyEntries);

			int count = 0;

			foreach (var item in words) {
				int value = GetValue (item);
				if (triangleNumbers [triangleNumbers.Count - 1] < value) {
					do {
						lastN++;
						triangleNumbers.Add(lastN*(lastN+1)/2);
					} while(triangleNumbers [triangleNumbers.Count - 1] < value);
				}
				if (triangleNumbers.Contains (value)) {
					Console.WriteLine ("Word:{0} Value:{1}",item,value);
					count++;
				}
			}

			Console.WriteLine ("Solution: {0}",count);
			Console.WriteLine ("Time: {0}",Environment.TickCount-time);
		}

		public static int GetValue(string word){
			int value = 0;
			foreach (var item in word) {
				value += ((int)item) - 64;
			}
			return value;
		}
	}
}
