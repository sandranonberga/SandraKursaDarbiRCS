using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena10
{
	class Program
	{
		static void Main(string[] args)
		{
			double vii = Saskaitisana(3, 4.5); //uztaisa mainīgo no vērtībām, ko izsauc no otras funkcijas

			Console.WriteLine(vii); //izsauc tagad to mainīgo

			Console.ReadLine();
		}

		static double Saskaitisana(double a, double b)
		{
			double result;
			result = a + b;

			return result;
		}
	}
}
