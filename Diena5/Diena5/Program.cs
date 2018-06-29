using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Izveelieties no kuras klases izsaukt funkcijas - 1 vai 2:");
			string izv = Console.ReadLine();

			if (izv == "1")
			{
				pd1_1 objekts = new pd1_1();
				objekts.Funkcijas();
			}
			else
			{ 
				if (izv == "2")
				{
					pd1_2 objekts2 = new pd1_2();
					objekts2.izsauktfunkcijas();
				}
				else
				{
					Console.WriteLine("Nevar izsaukt klasi :(");
				}
			}

			Console.ReadLine();
		}


		/*
		static void Main(string[] args)
		{
			int vaiBusHotdogs = Hotdogs(2);
			if(vaiBusHotdogs == 1)
			{
				Console.WriteLine("awww Yissss");
			}
			else
			{
				Console.WriteLine("Nopeerc labaak roltonu");
			}

			Console.ReadLine();
		}

		static int Hotdogs(int naudasmaks) //naudasmaks ir input vērtība
		{
			int result = 0; //vnk nodeklarē mainīgo
			int hotdogacena = 3;
			int starpiba = naudasmaks - hotdogacena;

			if (starpiba >= 0)
			{
				result = 1; //apzīmēs true
			} 
			else
			{
				result = 0;
			}

			return result;
		}
		*/
	}
}
