using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
	class pd1_1
	{
		public void Funkcijas()
		{
			Console.WriteLine("Izveelieties kaadu no 3 funkcijaam:");
			Console.WriteLine("1 - Sveiciena izvade");
			Console.WriteLine("2 - Virknju savienosana");
			Console.WriteLine("3 - Skaitlja paarkonverteesana");

			string izvele = Console.ReadLine();
			
			if (izvele == "1")
			{
				VardsUzvards();
			}
			else
			{
				if (izvele == "2")
				{
					virknes();
				}
				else
				{
					if (izvele == "3")
					{
						konvertesana();
					}
					else
					{
						Console.WriteLine("Nepareiza veertiiba!");
					}
				}
			}
		}

		private void VardsUzvards()
		{
			Console.WriteLine("Luudzu ievadiet savu vaardu:");
			string vards = Console.ReadLine();
			Console.WriteLine("Luudzu ievadiet savu uzvaardu:");
			string uzvards = Console.ReadLine();
			Console.WriteLine("Lietotaju sauc " + vards + " " + uzvards + "!");
		}

		private void virknes()
		{
			Console.WriteLine("Ievadiet pirmo simbolu virkni:");
			string pirmarinda = Console.ReadLine();
			Console.WriteLine("Ievadiet otro simbolu virkni:");
			string otrarinda = Console.ReadLine();

			Console.WriteLine("Rezultaats: " + pirmarinda + otrarinda);
		}

		private void konvertesana()
		{
			Console.WriteLine("Ievadiet kaut kaadu skaitli");
			string skaitlis = Console.ReadLine();
			int a = Convert.ToInt16(skaitlis);

			Console.WriteLine(a);

		}
	}
}
