using System;

namespace Projecteuler31
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = 1;
			int temp = 0;
			int i, j, k, l, m, n, o;

			for (i = 0; i < 201; i++) {
				for (j = 0; j < 101; j++) {
					for (k = 0; k < 41; k++) {
						for (l = 0; l < 21; l++) {
							for (m = 0; m < 11; m++) {
								for (n = 0; n < 5; n++) {
									for (o = 0; o < 3; o++) {
										temp = getValue (i, j, k, l, m, n, o);
										if (temp > 200) {
											break;
										} else if (temp == 200) {
											num++;
											break;
										}
									}
								}
							}
						}
					}
				}
			}

			Console.WriteLine (num);
		}

		public static int getValue (int i,int j,int k,int l,int m,int n,int o){
			return (i * 1) + (j * 2) + (k * 5) + (l * 10) + (m * 20) + (n * 50) + (o * 100);
		}
	}
}
