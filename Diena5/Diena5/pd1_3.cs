using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
	class pd1_3
	{
		public void izsaukt()
		{
			Console.WriteLine("Izveelieties kaadu no uzdevumiem:");
			Console.WriteLine("1 - kalendars");
			Console.WriteLine("2 - trijsturis");
			Console.WriteLine("3 - pelnja vai zaudejums");
			string izvele = Console.ReadLine();

			switch (izvele)
			{
				case "1":
					kalendars();
					break;
				case "2":
					trijsturis();
					break;
				case "3":
					profits();
					break;
			}
		}

		private void kalendars()
		{
			Console.WriteLine("Ievadiet meenesi skaitlja formaataa (1-12):");
			string izvele = Console.ReadLine();
			int m = Convert.ToInt16(izvele);

			if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
			{
				Console.WriteLine("Shajaa meenesii ir 31 diena");
			}
			else
			{
				if (m == 2)
				{
					Console.WriteLine("Shajaa meenesii ir 28 vai 29 dienas");
				}
				else
				{
					if (m == 4 || m == 6 || m == 9 || m == 11)
					{
						Console.WriteLine("Shajaa meenesii ir 30 dienas");
					}
					else
					{
						Console.WriteLine("Wut?");
					}
				}
			}
		}


		private void trijsturis()
		{
			Console.WriteLine("Ievadiet trijstuura malu garumus:");
			Console.Write("Pirmaa mala: ");
			string pirmamala = Console.ReadLine();
			double a = Convert.ToDouble(pirmamala);
			Console.Write("Otraa mala: ");
			string otramala = Console.ReadLine();
			double b = Convert.ToDouble(otramala);
			Console.Write("Treshaa mala: ");
			string tresamala = Console.ReadLine();
			double c = Convert.ToDouble(tresamala);


			if (a + b > c || a + c > b || b + c > a)
			{
				Console.WriteLine("Trijstuuris ir ok");
			}
			else
			{
				Console.WriteLine("Nebuus!");
			}
		}

		private void profits()
		{
			Console.WriteLine("Ievadiet iepirkuma cenu:");
			string iepirkumacena = Console.ReadLine();
			double iepirkums = Convert.ToDouble(iepirkumacena);
			Console.WriteLine("Ievadiet paardosanas cenu:");
			string pardosanascena = Console.ReadLine();
			double pardosana = Convert.ToDouble(pardosanascena);

			double pelna = pardosana - iepirkums;
			double zaudejumi = iepirkums - pardosana;

			if (iepirkums < pardosana)
			{
				Console.WriteLine("Pelnja: " + pelna);
			}
			else
			{
				if (iepirkums == pardosana)
				{
					Console.WriteLine("Nebus pelnja");
				}
				else
				{
					Console.WriteLine("Zaudejumi: " + zaudejumi);
				}
			}
		}


	}
}
