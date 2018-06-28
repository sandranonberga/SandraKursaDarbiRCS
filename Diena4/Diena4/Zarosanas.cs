using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena4
{
	class Zarosanas
	{

		/*public void LielaksVaiMazaks()
		{
			Console.WriteLine("Luudzu ievadiet skaitli");
			string input = Console.ReadLine();
			int skaitlis = Convert.ToInt16(input);

			//Vai skaitlis ir lielāks vai mazāks par 5
			// operatori - <, >, >=, <=, ==, !=

			if (skaitlis > 5)
			{
				Console.WriteLine("Skaitlis " + skaitlis + " ir lielaks par 5");
			}

			else
			{
				if (skaitlis == 5)
				{
					Console.WriteLine("Skaitlis " + skaitlis + " ir vienads");
				}
				else
				{
					Console.WriteLine("Skaitlis " + skaitlis + " ir mazaks par 5");
				}
			}

		}
		*/

		public void Funkcijas()
		{
			Console.WriteLine("Izveelieties funkciju (1 vai 2):");
			Console.WriteLine("1 - ArIf");
			Console.WriteLine("2 - ArCase");
			string izvele = Console.ReadLine();

			if (izvele == "1")
			{
				ArIf();
			}
			else
			{
				if (izvele == "2")
				{
					ArCase();
				}
				else
				{
					Console.WriteLine("Kludaina ievade");
				}
			}
		}

		public void ArIf()
		{
			// Ievade cilvēkam 0-10, int tipa skaitļi. Kas notiek, ja cilvēks ievada skaitli
			// 10 - "Ievade ir desmit"

			Console.WriteLine("Ievadiet skaitli no 1 liidz 10:");
			string skaitlis = Console.ReadLine();
			int vertiba = Convert.ToInt16(skaitlis);

			if (vertiba == 1)
			{
				Console.WriteLine("Skaitlis ir viens");
			}
			else
			{
				if (vertiba == 2)
				{
					Console.WriteLine("Skaitlis ir divi");
				}
				else
				{
					if (vertiba == 3)
					{
						Console.WriteLine("Skaitlis ir triis");
					}
					else
					{
						if (vertiba == 4)
						{
							Console.WriteLine("Skaitlis ir chetri");
						}
						else
						{
							if (vertiba == 5)
							{
								Console.WriteLine("Skaitlis ir pieci");
							}
							else
							{
								if (vertiba == 6)
								{
									Console.WriteLine("Skaitlis ir seshi");
								}
								else
								{
									if (vertiba == 7)
									{
										Console.WriteLine("Skaitlis ir septinji");
									}
									else
									{
										if (vertiba == 8)
										{
											Console.WriteLine("Skaitlis ir astonji");
										}
										else
										{
											if (vertiba == 9)
											{
												Console.WriteLine("Skaitlis ir devinji");
											}
											else
											{
												if (vertiba == 10)
												{
													Console.WriteLine("Skaitlis ir desmit");
												}
												else
												{
													Console.WriteLine("Kludaina ievade");
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		public void ArCase()
		{
			Console.WriteLine("Ievadiet skaitli no 1 liidz 10:");
			string skaitlis = Console.ReadLine();
			int vertiba = Convert.ToInt16(skaitlis);

			switch (vertiba)
			{
				case 1:
					Console.WriteLine("Skaitlis ir viens");
					break;
				case 2:
					Console.WriteLine("Skaitlis ir divi");
					break;
				case 3:
					Console.WriteLine("Skaitlis ir triis");
					break;
				case 4:
					Console.WriteLine("Skaitlis ir chetri");
					break;
				case 5:
					Console.WriteLine("Skaitlis ir pieci");
					break;
				case 6:
					Console.WriteLine("Skaitlis ir seshi");
					break;
				case 7:
					Console.WriteLine("Skaitlis ir septinji");
					break;
				case 8:
					Console.WriteLine("Skaitlis ir astonji");
					break;
				case 9:
					Console.WriteLine("Skaitlis ir devinji");
					break;
				case 10:
					Console.WriteLine("Skaitlis ir desmit");
					break;
				default:
					Console.WriteLine("Kludaina ievade");
					break;
			}
		}
	}
}
