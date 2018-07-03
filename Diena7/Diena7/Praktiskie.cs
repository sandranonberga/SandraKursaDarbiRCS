using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena7
{
	class Praktiskie
	{

		public void Pirmais()
		{
			//Izvadit summu skaitlu reizinajumam * 2 (skaitli no 1-9)
			//t.i. (1*2) + (2*2) + (3*2) +...

			int reizinajums = 0;

			for (int i = 1; i <= 9; i++)
			{
				reizinajums = i * 2 + reizinajums;
			}

			Console.WriteLine("Rezultaats ir " + reizinajums);
		}

		public void Otrais()
		{
			//Likt cilvekam meginat uzminet skaitli. Ja skaitlis sakrit ar 11, tad pareizi
			//Max meginajumu skaits - 5.
			//Ja 5 reizes nesanak, tad izvadit pazinojumu.

			Console.WriteLine("Luudzu ievadiet skaitli:");

			for (int i = 0; i < 5; i++)
			{
				
				string input = Console.ReadLine();
				int skaitlis = Convert.ToInt16(input);

				if (skaitlis == 11)
				{
					Console.WriteLine("Yisss, skaitlis ir uzmineets!");
					break;
				}
				else
				{
					if (i == 4)
					{
						Console.WriteLine(":(");
					}
					else
					{
						Console.WriteLine("Skaitlis ir nepareizs, meegjini veel");
					}					
				}

			}

		}


	}
}
