using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena6
{
	class Cikli
	{
		public void Faktorialis() 
		{
			Console.WriteLine("Ievadiet skaitli:");
			string input = Console.ReadLine();
			int robeza = Convert.ToInt16(input);

			int summa = 0; //deklarējam mainīgo ārpus cikla, lai saglabātu

			for(int i = 1; i < robeza+1; i++)
			{
				summa = summa + i;
			}

			Console.WriteLine("Faktorialis ir " + summa);

		}

		public void Reste()
		{
			Console.WriteLine("Ievadiet skaitli:");
			string input = Console.ReadLine();
			int robeza = Convert.ToInt16(input);

			string hashtag = "";

			for (int h = 0; h < robeza; h++)
			{
				hashtag = hashtag + "#";
			}

			Console.WriteLine(hashtag);
		}



		public void Piemers()
		{
			//ciklu veidi - for, while, do..while

			for (int i = 0; i < 6; i++) //for ciklā ir tikai int tips
			{
				/*i = 0 -> norāda skaitli, ar kuru sāksies skaitīšana
				 * 1 < 6 -> līdz kurai vērtībai ies loop
				 * i++ == i = i+1; i-- == i = i-1
				 */
				 
				Console.WriteLine("Sandra");

				if (i == 3) 
				{
					Console.WriteLine("Triiiiiis!!");
				}
			}

			for (int skaititajs = 7; skaititajs > 0; skaititajs--)
			{
				Console.WriteLine("Skaitam uz otru pusi");
			}

			Console.WriteLine("Ievadiet skaitli:");
			string input = Console.ReadLine();
			int robeza = Convert.ToInt16(input);


			for (int i = 0; i < robeza; i++)
			{
				Console.WriteLine(i);
			} 

		}
	

	}
}
