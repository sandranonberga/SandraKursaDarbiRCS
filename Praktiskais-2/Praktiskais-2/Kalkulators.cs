using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiskais_2
{
	class Kalkulators
	{
		
		public void funkcizv()
		{
			Console.WriteLine("Ievadiet pirmo ciparu:");
			string pirmaissk = Console.ReadLine();
			double a = Convert.ToDouble(pirmaissk);
			Console.WriteLine("Ievadiet otro ciparu:");
			string otraissk = Console.ReadLine();
			double b = Convert.ToDouble(otraissk);

			Console.WriteLine("Izveelieties uzdevumu:");
			Console.WriteLine("1 - saskaitishana, 2 - atnemshana, 3 - reizinashana, 4 - dalishana");
			string input = Console.ReadLine();

			Console.WriteLine("Rezultats ir:");

			switch (input)
			{
				case "1":
					Saskaitit(a,b);
					break;
				case "2":
					Atnemt(a, b);
					break;
				case "3":
					Reizinat(a, b);
					break;
				case "4":
					Dalit(a, b);
					break;
				case "5":
					Kapinat(a, b);
					break;
				default:
					Console.WriteLine("Nepareiza ievade");
					break;

			}

			Console.WriteLine();
		}


		private double Saskaitit(double a, double b)
		{
			double rezultats = a + b;

			return rezultats;
		}


		private double Atnemt(double a, double b)
		{
			double rezultats = a - b;

			return rezultats;
		}


		private double Reizinat(double a, double b)
		{
			double rezultats = a * b;

			return rezultats;
		}


		private double Dalit(double a, double b)
		{
			double rezultats = a / b;

			return rezultats;
		}


		private double Kapinat(double a, double b)
		{
			double rezultats = a;

			for (int i = 0; i <= a-1; i++)
			{
				rezultats = rezultats * a;
			}

			return rezultats;
		}

	}
}
