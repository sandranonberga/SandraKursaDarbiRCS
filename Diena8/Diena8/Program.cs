using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena8
{
	class Program
	{
		static void Main(string[] args)
		{
			//Switch un case izveelne
			CikluUzdevumi obj = new CikluUzdevumi();
			Masivs array = new Masivs();
			Console.WriteLine("Izvelieties uzdevumu - 1 vai 2");
			string izvelne = Console.ReadLine();

			switch (izvelne)
			{
				case "1":
					obj.Zvaigznite();
					break;
				case "2":
					array.IzvaditMasivu();
					break;
				case "0":
					break;
				default:
					Console.WriteLine("Nepareiza ievade");
					break;
			}

			/*
			while (izvelne != "0")
			{
				Console.WriteLine("Izvelieties uzdevumu - 1");
				izvelne = Console.ReadLine();

				switch (izvelne)
				{
					case "1":
						obj.Zvaigznite();
						break;
					case "2":
						array.IzvaditMasivu();
						break;
					case "0":
						break;
					default:
						Console.WriteLine("Nepareiza ievade");
						break;
				}

			}
			*/

			Console.ReadLine();
		}
	}
}
