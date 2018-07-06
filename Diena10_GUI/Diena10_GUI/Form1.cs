using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diena10_GUI
{

	public partial class Form1 : Form
	{
		private int skaitlis1 = 0;
		private int skaitlis2 = 0;

		public Form1()
		{
			InitializeComponent();
		}


		/*
		private void IevadesPoga_Click(object sender, EventArgs e)
		{

			string ievade = IevadesPoga.Text;
			ChangeLabel(ievade);
			
			//string input = Input.Text;

			//TekstaIzvade.Text = input;
			
		}
		*/

		private void TekstaIzvade_Click(object sender, EventArgs e)
		{
			string teksts = TekstaIzvade.Text;
			ChangeLabel(teksts);
		}


		/*
		private void ChangeLabel(string cipars)
		{
			TekstaIzvade.Text = cipars;
			
		}
		*/

		private void ChangeLabel(string cipars)
		{
			TekstaIzvade.Text = cipars;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string ievade = TekstaIzvade.Text;
			ChangeLabel(ievade);
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string ievade = button2.Text;
			ChangeLabel(ievade);

		}

		private void button3_Click(object sender, EventArgs e)
		{
			string ievade = button3.Text;
			ChangeLabel(ievade);

		}

		private void button4_Click(object sender, EventArgs e)
		{
			string ievade = button4.Text;
			ChangeLabel(ievade);

		}

		private void button5_Click(object sender, EventArgs e)
		{
			string ievade = button5.Text;
			ChangeLabel(ievade);

		}

		private void button6_Click(object sender, EventArgs e)
		{
			string ievade = button6.Text;
			ChangeLabel(ievade);

		}

		private void button7_Click(object sender, EventArgs e)
		{
			string ievade = button7.Text;
			ChangeLabel(ievade);

		}

		private void button8_Click(object sender, EventArgs e)
		{
			string ievade = button8.Text;
			ChangeLabel(ievade);

		}

		private void button9_Click(object sender, EventArgs e)
		{
			string ievade = button9.Text;
			ChangeLabel(ievade);

		}

		private void button10_Click(object sender, EventArgs e)
		{
			string ievade = button10.Text;
			ChangeLabel(ievade);

		}

		private void button11_Click(object sender, EventArgs e)
		{
			string ievade = button11.Text;
			skaitlis1 = Convert.ToInt16(ievade);

		}

		private void button12_Click(object sender, EventArgs e)
		{
			string ievade = button12.Text;
			skaitlis2 = Convert.ToInt16(ievade);

		}

		private void button13_Click(object sender, EventArgs e)
		{
			string ievade = button13.Text;
			skaitlis2 = Convert.ToInt16(ievade);

			TekstaIzvade.Text = Kalkulators.Saskaitisana(skaitlis1, skaitlis2);

		}

		

	}
}
