using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena7
{
	class Piemeri
	{
		public void Kamer()
		{
			//while		do..while
			string ievade = "";
			int skaititajs = 0;

			while (ievade != "") //while laikā, nosacījumu pārbauda cikla sākumā
			{
				Console.WriteLine("Uzraksti kaut ko:");
				ievade = Console.ReadLine();
				Console.WriteLine("Mees esam iteraacijaa " + skaititajs);
				skaititajs++;
				Console.WriteLine("Veel esam ciklaa");
			
			}
			Console.WriteLine("Jau izgajam aaraa");
		}

		public void Darit()
		{
			string ievade = "";
			int skaititajs = 0;

			do
			{
				Console.WriteLine("Uzraksti kaut ko:");
				ievade = Console.ReadLine();
				Console.WriteLine("Mees esam iteraacijaa " + skaititajs);
				skaititajs++;
				Console.WriteLine("Veel esam ciklaa");
			}
			while (ievade != "");
		}

	}
}
