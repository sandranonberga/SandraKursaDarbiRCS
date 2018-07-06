using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena10_GUI
{
	class Kalkulators
	{

		public static string Saskaitisana(int a, int b)
		{
			string result = Convert.ToString(a + b);
			return result;
		}

		public int Atnemsana(int a, int b)
		{
			int result;
			result = a - b;

			return result;
		}

	}
}
