using System;
using System.Collections.Generic;
using System.Linq;

namespace BA1E
{
	class Program
	{
		static void Main(string[] args)
		{
			//string[] planets = { };
			//planets.Distinct()
			Console.WriteLine("Unesite vrijednost za k");
			int k = int.Parse(Console.ReadLine());
			Console.WriteLine("Unesite vrijednost za L");
			int L = int.Parse(Console.ReadLine());
			Console.WriteLine("Unesite vrijednost za t");
			int t = int.Parse(Console.ReadLine());
			//Console.WriteLine("Unesite genom");
			string g = "CGGACTCGACAGATGTGAAGAAATGTGAAGACTGAGTGAAGAGAAGAGGAAACACGACACGACATTGCGACATAATGTACGAATGTAATGTGCCTATGGC";
			List<string> lista = new List<string>();
			//clumps.Append()
			for (int i = 0; i < g.Length - L; i++)
			{
				for (int j = i; j < i + L-k; j++)
				{
					string s = g.Substring(j, k);
					int count = 0;
					for (int m = i; m < i + L - k; m++)
					{
						if (g.Substring(m, k) == s)
							count++;
					}
					if (count >= t)
						lista.Add(s);
				}
			}
			Console.WriteLine("Rjesenja su iduci patterni:");
			foreach (string cl in lista.Distinct())
			{
				Console.WriteLine(cl);
			}
			Console.ReadLine();

		}
	}
}
