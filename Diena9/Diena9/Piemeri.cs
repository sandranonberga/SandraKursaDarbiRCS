using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena9
{
	class Piemeri
	{
		string[] masivs = new string[12];

		public void Klase()
		{
			//12 vietas, Ar ConsoleReadLine - vai vieta ir brīva vai tukša. Tukšā - 0, pilnā - 1; 

			int robeza = masivs.Length;

			Console.WriteLine("Ievadiet, vai solaa kaads seezh:");
			string vards = "";

			for (int i = 0; i < 12; i++)
			{
				vards = Console.ReadLine();
				masivs[i] = vards;
			}

			Console.WriteLine("");

			for (int i = 0; i < 12; i++)
			{
				if (masivs[i] != "0")
				{
					Console.WriteLine("Pie galda sez " + masivs[i]);
				}
				else
				{
					Console.WriteLine("Galds ir tukshs!");
				}
				if(i == robeza-1)
				{
					Console.WriteLine("____________________");
				}
			}




		}

	}
}
