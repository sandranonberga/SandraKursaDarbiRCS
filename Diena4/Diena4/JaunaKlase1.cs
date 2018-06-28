using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
	class JaunaKlase1
	{

		public void Rezultats()
		{
			Izvade();
			Saskaitisana();
		}

		private void Izvade()
		{
			Console.WriteLine("Sis ir");
			Console.WriteLine("viegls uzdevums");
		}

		private int Saskaitisana()
		{
			Console.WriteLine("Ievadiet pirmo skaitli:");
			string a = Console.ReadLine();
			int askaitlis = Convert.ToInt16(a);

			Console.WriteLine("Ievadiet otro skaitli:");
			string b = Console.ReadLine();
			int bskaitlis = Convert.ToInt16(b);

			int result = askaitlis + bskaitlis;
			Console.WriteLine(result);

			return result;
		}

	}
}
