using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ludzu, ievadiet savu vaardu:");
            string vards = Console.ReadLine();

            Console.WriteLine("Ludzu, ievadiet kaads gads ir tagad:");
            string gadstag = Console.ReadLine();
            int gadstagad = Convert.ToInt16(gadstag);

            Console.WriteLine("Ludzu, ievadiet savu dzimshanas gadu:");
            string gadsdz = Console.ReadLine();
            int gadsdzd = Convert.ToInt16(gadsdz);

            int rezultats = gadstagad - gadsdzd;
            Console.WriteLine("Tevi sauc " + vards + " un tev ir " + rezultats + " gadu");
            Console.ReadLine();
            

            /*
            Console.WriteLine("\"Luudzu, ievadiet savu vaardu:\"");
            string name = Console.ReadLine();
            Console.WriteLine("Sveiki, " + name + "!");

            string virkne1 = Console.ReadLine();
            int rezultats = Convert.ToInt16(virkne1); //ToInt16 ir no ~-32000 liidz 32000
            rezultats = rezultats + 6;
            Console.WriteLine(rezultats);
            Console.ReadLine();
            */

            /* 
            int a; //deklaree tikai mainiigo
            a = 5; //int mainiigaa veertiiba, vesels skaitlis
            a = 6;
            Console.WriteLine(a);
            int b = 3; //tas pats, tikai vienaa rindaa
            Console.WriteLine(b);
            b = 4;
            Console.WriteLine(b);

            double c = 33.333; //skaitlis ar komatu, komata vietaa liek punktu
            char simbols = 's';
            a = 5 + a; //pievieno jaunu vērtību, izvadot, būs gala rezultāts
            string virkne = "abc";
            virkne = virkne + simbols;
            Console.WriteLine(virkne);
            */

            /* Vairāku
             * rindu
             * komentārs */

            /*
            Console.WriteLine("Hello World!"); //izvada tekstu ar paarieshanu jaunaa rindaa
            Console.Write("Ievadi tekstu - "); //tikai izvada tekstu, nepaariet jaunaa rindaa
            Console.ReadLine(); //nolasa tekstu no programmas
            Console.WriteLine("Ievadi veel kaut ko - ");
            string virkne2 = Console.ReadLine();
            Console.WriteLine(virkne2);
            Console.ReadLine();
            */

        }
    }
}
