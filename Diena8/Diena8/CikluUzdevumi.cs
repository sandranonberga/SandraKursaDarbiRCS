using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
	class CikluUzdevumi
	{
		public void Zvaigznite()
		{
			//Lai cilveeks ievada, cik reizes ciklam iet cauri, uztaisiit zvaigzniites trepiitee
			//Kludas pazinojums, ja ievaditais skaitlis = 0 vai negatiivs.
			Console.WriteLine("Ievadiet zvaigzniishu skaitu:");

			string input = Console.ReadLine();
			int reizes = Convert.ToInt16(input);

			string zvaigznite = "";

			if (reizes > 0)
			{
				for (int i = 0; i < reizes; i++)
				{
					zvaigznite = zvaigznite + "*";
					Console.WriteLine(zvaigznite);
				}

			}
			else
			{
				Console.WriteLine("Nepareiza ievade");
			}

		}

		
	}
}
