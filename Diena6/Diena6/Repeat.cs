using System;
using System.Collections.Generic;
using System.Text;

namespace Diena6
{
	class Repeat
	{
		public void Izvade()
		{
			string result = Console.ReadLine();
			int skaitlis = Convert.ToInt16(result);

			string b = Sharp(skaitlis);

			Console.WriteLine(b);
			
			//Izvadit vai nu # vai ## atkariba no lietotaja ievades. Cilvekam jaievada vesels
			//skaitlis un jaizsauc funkcija Sharp(SEIT LIEKAM SKAITLISKU VERTIBU);
		}

		private string Sharp(int a)
		{

			string result = "";
			
			//TODO ja int a lielaks par 5, tad atgriezt ##, ja ne, tad #

			if (a > 5)
			{
				result = "##";
			}
			else
			{
				result = "#";
			}

			return result;
		}
	}
}