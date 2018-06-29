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
			pd1_1 objekts = new pd1_1();
			objekts.Funkcijas();

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
