using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
	class Program
	{
		static void Main(string[] args)
		{
			RinkaLinija();

			Console.ReadLine();
		}

		static void RinkaLinija()
		{
			Console.WriteLine("Luudzu ievadiet rinkja liinijas radiusa veertiibu:");
			string radi = Console.ReadLine();
			int r = Convert.ToInt16(radi);

			double pi = 3.14;
			int piNew = Convert.ToInt16(pi);
			int diametrs = r * 2;
			int rlgarums = 2 * piNew * r;

			Console.WriteLine("Rinkja diametrs ir " + diametrs);
			Console.WriteLine("Rinkja liinijas radiuss ir " + rlgarums);

		}



		/*
		static void Main(string[] args)
		{
			string vards, uzvards; //deklarē mainīgos
			Console.WriteLine("Luudzu ievadiet vaardu:");
			vards = Console.ReadLine();
			Console.WriteLine("Luudzu ievadiet uzvaardu:");
			uzvards = Console.ReadLine();

			IzvaditSveicienu(vards, uzvards);

			Console.ReadLine();
		}

		static void IzvaditSveicienu(string a, string b) //izveido divus parametrus
		{
			Console.WriteLine("Sveiki, " + a + " " + b + ", prieks tevi redzeet!");
		}
		*/
	}
}
