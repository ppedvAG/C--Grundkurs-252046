using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag2
{
	public static class MathematischeMethoden
	{
		public static int SummeBerechnen(int z1, int z2)
		{
			return z1 + z2;
		}
		public static double SummeBerechnen(out double z1, double z2)
		{
			z1 = 0;
			return z1 + z2;
		}
	

		public static int SummeBerechnen(params int[] zahlen)
		{
			int summe = 0;
			foreach (int zahl in zahlen)
			{
				summe += zahl;
			}
			return summe;
		}

		public static int ZahlHochX(int z1, int z2 = 2)
		{
			return (int)Math.Pow(z1, z2);
		}
	}
}
