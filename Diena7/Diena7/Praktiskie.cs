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
				int reizes = 5 - i;
				Console.WriteLine("Palika " + reizes + " meeginaajumi");

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

		public void Tresais()
		{
			int reizinajums = 0;
			int i = 0;
			
			while (i <= 9)
			{
				reizinajums = i * 2 + reizinajums;
				i++;
			}

			Console.WriteLine("Rezultaats ir " + reizinajums);
		}

		public void Ceturtais()
		{
			//Likt cilvekam meginat uzminet skaitli. Ja skaitlis sakrit ar 11, tad pareizi
			//Max meginajumu skaits - 5.
			//Ja 5 reizes nesanak, tad izvadit pazinojumu.

			Console.WriteLine("Luudzu ievadiet skaitli:");
		
			int i = 0;

			do
			{
				string input = Console.ReadLine();
				int skaitlis = Convert.ToInt16(input);

				i++;

				if (skaitlis == 11)
				{
					Console.WriteLine("Yisss, skaitlis ir uzmineets!");
					break;
				}
				else
				{
					if (i == 5)
					{
						Console.WriteLine(":(");
					}
					else
					{
						Console.WriteLine("Skaitlis ir nepareizs, meegjini veel");
					}
				}

			}
			while (i < 5);

			

		}


	}
}
