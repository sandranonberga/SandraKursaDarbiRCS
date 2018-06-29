using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
	class pd1_3
	{

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
				Console.WriteLine("Trijsturis nesanaaks");
			}
		}


	}
}
