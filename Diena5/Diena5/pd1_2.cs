using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
	class pd1_2
	{



		private void matematika()
		{
			Console.WriteLine("Ierakstiet pirmo skaitli:");
			string pirmaisskaitlis = Console.ReadLine();
			double a = Convert.ToDouble(pirmaisskaitlis);
			Console.WriteLine("Ierakstiet otro skaitli:");
			string otraisskaitlis = Console.ReadLine();
			double b = Convert.ToDouble(pirmaisskaitlis);
			Console.WriteLine("Izveelieties darbiibu:");
			Console.WriteLine("1 - saskaitiishana:");
			Console.WriteLine("2 - atnjemshana:");
			Console.WriteLine("3 - reizinaashana:");
			Console.WriteLine("4 - daliishana:");
			string izvele = Console.ReadLine();

			if (izvele == "1")
			{
				double rez1 = a + b;
				Console.WriteLine(rez1);
			}
			else
			{
				if (izvele == "2") {
					double rez2 = a - b;
					Console.WriteLine(rez2);
				}
				else
				{
					if (izvele == "3")
					{
						double rez3 = a * b;
						Console.WriteLine(rez3);
					}
					else
					{
						if (izvele == "4")
						{
							double rez4 = a / b;
							Console.WriteLine(rez4);
						}
						else
						{
							Console.WriteLine("Nepareiza veertiiba!");
						}
					}
				}
			}
		}


		private void LetterGrade()
		{
			Console.WriteLine("Ievadiet kaadu no shiim GPA veertiibaam:");
			Console.WriteLine("0, 1, 2, 2.5, 3, 3.5, 4, 4.5, 5");
			string atzime = Console.ReadLine();
			double atz = Convert.ToDouble(atzime);

			switch (atz)
			{
				case 0:
					Console.WriteLine("Atzime - F"); 
					break;
				case 1:
					Console.WriteLine("Atzime - D");
					break;
				case 2:
					Console.WriteLine("Atzime - C");
					break;
				case 2.5:
					Console.WriteLine("Atzime - C+");
					break;
				case 3:
					Console.WriteLine("Atzime - B");
					break;
				case 3.5:
					Console.WriteLine("Atzime - B+");
					break;
				case 4:
					Console.WriteLine("Atzime - A");
					break;
				case 4.5:
					Console.WriteLine("Atzime - A+");
					break;
				default:
					Console.WriteLine("Nepareizs veerteejums");
					break;
			}

		}


	}
}
