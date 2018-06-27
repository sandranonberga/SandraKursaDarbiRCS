using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
	class RinkaLinija
	{
		//rl garums = 2 * r * 3.14
		//rl laukums = pi * r ^ 2

		public void rinkis()
		{
			Console.WriteLine("Ievadiet rinkja radiusu:");
			string rad = Console.ReadLine();
			double radiuss = Convert.ToDouble(rad);

			Console.WriteLine("Rinkja liinijas garums ir:");
			rlgarums(radiuss);

			Console.WriteLine("Rinkja liinijas laukums ir:");
			rllaukums(radiuss);

		}

		public void rlgarums(double r)
		{
			double radius = r;
			double rezultats = 2 * r * 3.14;
			Console.WriteLine(rezultats);
		}

		public void rllaukums(double r)
		{
			double radius = r;
			double rezultats = 3.14 * (r * r);
			Console.WriteLine(rezultats);
		}

	}
}
