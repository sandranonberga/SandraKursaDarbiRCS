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
			Matematika objekts1 = new Matematika(); //definē objektu no klases
			///Matematika objekts2 = new Matematika();
			objekts1.Matem(); //ar jauno objektu izsaucu metodi, kur jau visas darbības definētas
			//objekts2.Atnem(4,3);

			/*
			Class1 objekts1 = new Class1(); //šeit izsauc jaunu objektu no klases Class1
			Class1 objekts2 = new Class1();
			int vertiba = objekts1.Saskaitit(5,3); //izsauc funkciju no citas klases caur objektu
			objekts1.globals = 5 + 5;

			Console.WriteLine(objekts1.globals);
			Console.WriteLine(objekts2.globals); //paņems vērtību no Class1
			Console.WriteLine(vertiba);
			*/
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


		/*
		static void IzvaditSveicienu(string a, string b) //izveido divus parametrus
		{
			Console.WriteLine("Sveiki, " + a + " " + b + ", prieks tevi redzeet!");
		}
		*/
		
	}
}
