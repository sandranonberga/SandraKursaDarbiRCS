using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena3
{
	class Class1
	{
		public int globals = 4; //mainīgo var definēt ārpus funkcijas, jānorāda, ka tas ir public
		private int lokalsklasei = 2; //var piekļūt tikai no šīs klases

		public int Saskaitit(int a, int b) //public - norāda, ka funkcijai varēs piekļūt ārpus šīs klases
		{
			int rezultats = a + b;
			globals = 6;
			lokalsklasei = 3;
			//Teksts();
			return rezultats; //lai būtu return, nedrīkst būt void, jābūt int. Return ir pēdējā lieta, ko izdara funkcija
		}

		private void Teksts() //private - šai funkcijai varēs piekļūt tikai no šīs klases
		{
			globals = 8;
			Console.WriteLine("hfudishfods");
		}
	}
}
