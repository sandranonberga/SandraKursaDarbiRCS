using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
	class Program
	{
		/*
		static void Main(string[] args)
		{
			Degviela();

			Console.ReadLine();
		}

		static void Degviela()
		{
			Console.WriteLine("Ievadiet degvielas cenu:");
			string cena = Console.ReadLine();
			double c = Convert.ToDouble(cena);

			Console.WriteLine("Ievadiet degvielas pateerinju litros uz 100km:");
			string paterins = Console.ReadLine();
			double p = Convert.ToDouble(paterins);

			Console.WriteLine("Ievadiet nobraukto kilometru skaitu:");
			string nobraukums = Console.ReadLine();
			double n = Convert.ToDouble(nobraukums);

			double kopejacena = (p / 100) * n * c;

			Console.WriteLine("Celsh izmaksaas " + kopejacena + " EUR!");
		}
		*/


		/*
		static void Main(string[] args)
		{
			RinkaLinija();

			Console.ReadLine();
		}

		static void RinkaLinija()
		{
			Console.WriteLine("Luudzu ievadiet rinkja liinijas radiusa veertiibu:");
			string radi = Console.ReadLine();
			double r = Convert.ToDouble(radi);

			double pi = 3.14;
			double diametrs = r * 2;
			double rlgarums = 2 * pi * r;

			Console.WriteLine("Rinkja diametrs ir " + diametrs);
			Console.WriteLine("Rinkja liinijas garums ir " + rlgarums);

		}
		*/



		
		static void Main(string[] args)
		{
			Class1 objekts1 = new Class1(); //šeit izsauc jaunu objektu no klases Class1
			int vertiba = objekts1.Saskaitit(5,5); //izsauc funkciju no citas klases caur objektu
			objekts1.Teksts();
			/*
			string vards, uzvards; //deklarē mainīgos
			Console.WriteLine("Luudzu ievadiet vaardu:");
			vards = Console.ReadLine();
			Console.WriteLine("Luudzu ievadiet uzvaardu:");
			uzvards = Console.ReadLine();

			IzvaditSveicienu(vards, uzvards);
			*/
			Console.ReadLine();
		}

		static void IzvaditSveicienu(string a, string b) //izveido divus parametrus
		{
			Console.WriteLine("Sveiki, " + a + " " + b + ", prieks tevi redzeet!");
		}
		
	}
}
