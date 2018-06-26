using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena2
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Ievadiet pirmo skaitli:");
			string SkaitlisViens = Console.ReadLine();
			int pirmais = Convert.ToInt16(SkaitlisViens);

			Console.WriteLine("Ievadiet pirmo skaitli:");
			string SkaitlisDivi = Console.ReadLine();
			int otrais = Convert.ToInt16(SkaitlisDivi);

			Console.WriteLine("Rezultaats:");
			Saskaita(pirmais, otrais);
			Atnem(pirmais, otrais);

			Console.ReadLine();
		}

		static void Saskaita(int a, int b)
		{
			int result = a + b;
			Console.WriteLine(result);
		}

		static void Atnem(int a, int b)
		{
			int result = a - b;
			Console.WriteLine(result);
		}
		
		/*
		static void Main(string[] args)
		{
			Console.WriteLine("Luudzu ievadiet skaitli");
			int atbilde = ReturnSkaitli();
			Console.WriteLine(atbilde);
			Console.ReadLine();

		}

		static int ReturnSkaitli()
		{
			string gads = Console.ReadLine();
			int rezultats = Convert.ToInt16(gads);
			return rezultats;
		}
		*/


		/*static - nav nepieciešams uztaisīt objektu no klases
			 * void - raksta funkcijas datu tipa vietā, ja funkcija neatgriež vērtību
			 * Main - šeit -> funkcijas nosaukums
			 * args - string mainīgais, kas atrodas funkcijā Main
			 */

		/*
		static void Main(string[] args) 
		{

			NeatgriezVertibu(); //izsauc funkciju no NeatgriezVertibu, ja neizsauc, tad nekas no tā neparādīsies
			NeatgriezVertibu(); //izsauc funkciju otro reizi
			ArParametriem(1,2); //int parametru a un b veertiibas
			ArParametriem(9, -99);

			int atbilde = ArReturn(4,5); //definē tipu un izsauc funkciju ar vērtībām
			Console.WriteLine(atbilde);

			Console.ReadLine();
		}

		static void NeatgriezVertibu() //mainīgais funkcijā neatrodas, šeit definē funkciju
		{
			int mainigais = 55;
			Console.WriteLine(mainigais); //ja uzreiz definē, tad visu laiku izvadīs vienu un to pašu skaitli (konstantu)
			Console.WriteLine("1. funkcija");
			Console.WriteLine("Bez inputa un outputa");
		}

		static void ArParametriem(int a, int b) //deklarē mainīgos ar parametriem, kurus apstrādās
		{
			int result = a + b;
			Console.WriteLine(result);
		}

		static int ArReturn(int a, int b) //ja tiek ņemta vērtība no ReadLine, funkcijai būs outputs
		{
			int result = a + b; //lokāls mainīgais, tāpēc mainīgo nosaukumus var lietot atkārtoti
			return result; //return - definē, ka tiek atgriezta vērtība
		}
		*/
	}
}
