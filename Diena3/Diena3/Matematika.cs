using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
	class Matematika
	{
		public void Matem()
		{
			Console.WriteLine("Ievadiet pirmo skaitli:");
			string SkaitlisViens = Console.ReadLine();
			int pirmais = Convert.ToInt16(SkaitlisViens);

			Console.WriteLine("Ievadiet otro skaitli:");
			string SkaitlisDivi = Console.ReadLine();
			int otrais = Convert.ToInt16(SkaitlisDivi);

			Console.WriteLine("Rezultaats:");
			Saskaita(pirmais, otrais);
			Atnem(pirmais, otrais);

			Console.ReadLine();
		}

		public void Saskaita(int a, int b)
		{
			int result = a + b;
			Console.WriteLine(result);
		}

		public void Atnem(int a, int b)
		{
			int result = a - b;
			Console.WriteLine(result);
		}


	}
}
