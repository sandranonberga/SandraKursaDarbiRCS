using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
	class Masivs
	{

		public void IzvaditMasivu()
		{
			/*
			int[] piemeraMasivs = new int[5]; //cik masiivaa var būt vērtības

			piemeraMasivs[0] = 4;
			piemeraMasivs[1] = 10;
			piemeraMasivs[2] = 11;
			piemeraMasivs[3] = 14;
			piemeraMasivs[4] = 1320;

			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine(piemeraMasivs[i]);
			}
			*/

			string[] stringMasivs = new string[5];
			string zvaigznite = "";


			for (int i = 0; i < 5; i++)
			{
				zvaigznite = zvaigznite + "*";
				stringMasivs[i] = zvaigznite;
			}


			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(stringMasivs[i]);
			}

			for (int i = 4; i >= 0; i--)
			{
				Console.WriteLine(stringMasivs[i]);
			}
			


		}

	}
}
