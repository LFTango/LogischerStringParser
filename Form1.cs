using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogischerStringParser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// A & (B | C) & (D | E)
			// A&B&D|A&B&E|A&C&D|A&C&E

			//Regex regexVertBar = new Regex(@"\b\|\b");
			string chSplitter;
			string test = AusdruckTextBox.Text;
			string[] striMergeColl = new string[5];
			string[] merger = new string[4];
			char[] chTB = AusdruckTextBox.Text.ToCharArray();
			bool regswitch = true;
			//Match mPlus, mMinus, mCheck;



			for (int i = 0; i <= 12; i++)
			{
				chSplitter = chTB[i].ToString();
				//mCheck = regexVertBar.Match(chParser, 1);
				//label1.Text = mCheck.Value;
				if (chSplitter == "|")
				//if (regexVertBar.Match(chParser, 1).Success)
				{
					if (regswitch == true)
					{
						striMergeColl[1] = chTB[i - 1].ToString();
						striMergeColl[2] = chTB[i + 1].ToString();
						regswitch = false;
					}
					else
					{
						striMergeColl[3] = chTB[i - 1].ToString();
						striMergeColl[4] = chTB[i + 1].ToString();
						regswitch = true;
					}
				}
			}

			merger[0] = chTB[0] + "&" + striMergeColl[1] + "&" + striMergeColl[3] + " ";
			merger[1] = chTB[0] + "&" + striMergeColl[1] + "&" + striMergeColl[4] + " ";
			merger[2] = chTB[0] + "&" + striMergeColl[2] + "&" + striMergeColl[3] + " ";
			merger[3] = chTB[0] + "&" + striMergeColl[2] + "&" + striMergeColl[4] + " ";
			label1.Text = string.Join("", merger);


		}
	}
}

