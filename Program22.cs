using System;
using System.IO;
using System.Collections.Generic;

namespace Projecteuler22
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StreamReader f = new StreamReader("p022_names.txt");

			string[] s = f.ReadToEnd ().Split (',');

			f.Dispose ();

			for (int i = 0; i < s.Length; i++) {
				s [i] = s [i].Trim ('\"');
			}

			s = Sorter (s);

			long sumOfScores = 0;

			for (int i = 0; i < s.Length; i++) {
				sumOfScores += NameScore(s[i]) * (i + 1);
			}

			Console.WriteLine (sumOfScores);
		}

		static int NameScore(string s){
			int score = 0; 
			for (int i = 0; i < s.Length; i++) {
				score += (int)s [i] - 64;
			}
			return score;
		}

		static public string [] Sorter(string[] s){
			for (int i = s.Length-1; i > 2; i--) {
				for (int j = 0; j < i; j++) {
					if (CompareStrings(s[j],s[j+1])) {
						string temp = s [j];
						s [j] = s [j + 1];
						s [j + 1] = temp;
					}
				}
			}
			return s;
		}
		static public bool CompareStrings(string s1, string s2){
			int i = 0;
			while (true) {
				if (i == s1.Length) {
					return false;
				}
				else if (i == s2.Length) {
					return true;
				}
				else if (s1 [i] > s2 [i]) {
					return true;
				}
				else if (s1 [i] < s2 [i]) {
					return false;
				}
				i++;
			}
		}
	}
}
