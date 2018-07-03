using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena7
{
	class Program
	{
		static void Main(string[] args)
		{
			Piemeri examples = new Piemeri();
			examples.Kamer();

			Console.WriteLine("Izveelieties uzdevumu - 1, 2, 3, 4, 5 vai 6");
			string choice = Console.ReadLine();
			int ch = Convert.ToInt16(choice);

			Praktiskie prak = new Praktiskie(); //Klases objekts

			switch (ch)
			{
				case 1:
					prak.Pirmais();
					break;
				case 2:
					prak.Otrais();
					break;
				case 3:
					examples.Kamer();
					break;
				case 4:
					examples.Darit();
					break;
				case 5:
					prak.Tresais();
					break;
				case 6:
					prak.Ceturtais();
					break;
				default:
					Console.WriteLine("Nepareiza ievade!");
					break;
			}
			

			/*
			Praktiskie obj = new Praktiskie();
			//obj.Pirmais();
			obj.Otrais();
			*/

			Console.ReadLine();
		}
	}
}
