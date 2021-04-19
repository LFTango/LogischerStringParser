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

			string charSplitter; //für lesbarkeit. Enthählt immer den i'sten Char aus der textbox nachdem man den Button drückt.
			string A, B, C, D, E; //Kürzel. Der wert enspricht alle strings aus einer liste, pro buchstabe.

			char[] charTB = AusdruckTextBox.Text.ToCharArray(); //Teilt einen string der in die textbox eingegeben wird in alle characters auf und speichert diese in einem array

			List<string> mergeListA = new List<string>(); //Lists die einzelne chars als wert hinzugefügt bekommt
			List<string> mergeListB = new List<string>();
			List<string> mergeListC = new List<string>();
			List<string> mergeListD = new List<string>();
			List<string> mergeListE = new List<string>();

			bool vertBarBool = false; //Wenn ein "|" in charsplitter übergeben wird, wird dieser bool true gesetzt. Wird eine Klammer beendet, wird dieser bool false gesetzt
			bool klammerBool = false; //Bleibt true solange man sich in einer klammer befindet.
			bool switchBool = false; //Wird true gesetzt nachdem die erste klammer beendet wurde.
			bool initialBool = true; //Wird false gesetzt nachdem der erste "wert" in der textbox in eine liste hinzugefügt wird



			for (int i = 0; i <= (charTB.Length - 1); i++) //geht so oft durch wie die länge des char arrays. Hier wird im jedem durchlauf ein char zu einer der listen hinzugefügt
			{
				charSplitter = charTB[i].ToString();

				if (charSplitter == ")")
				{
					klammerBool = false;
					switchBool = true;
					vertBarBool = false;
				}
				if (charSplitter == "|")
				{
					vertBarBool = true;
				}
				else
				{
					if (klammerBool && !vertBarBool)
					{
						if (!switchBool) 
							mergeListB.Add(charSplitter);	//Wenn in klammer 1, added die werte die vor dem "|" stehen
						if (switchBool)
							mergeListD.Add(charSplitter);	//Wenn in klammer 2, added die werte die vor dem "|" stehen
					}
					else if (klammerBool && vertBarBool)
					{
						if (!switchBool)
							mergeListC.Add(charSplitter);	//Wenn in klammer 1, added die werte die nach dem "|" stehen
						if (switchBool)
							mergeListE.Add(charSplitter);	//Wenn in klammer 2, added die werte die nach dem "|" stehen
					}
				}

				if (charSplitter == "(")
				{
					klammerBool = true;
					initialBool = false;
				}
				else if (initialBool && charSplitter != "&") //Hier werden die Werte vor der Klammer in eine liste gepackt
				{
					mergeListA.Add(charSplitter);
				}
			}

			A = string.Join("", mergeListA); //Fügt alle string/chars in dieser list zusammen zu einem string
			B = string.Join("", mergeListB);
			C = string.Join("", mergeListC);
			D = string.Join("", mergeListD);
			E = string.Join("", mergeListE);

			// A&B&D|A&B&E|A&C&D|A&C&E

			ergLabel.UseMnemonic = false; //UseMnemonic wird false gesetzt weil ein label sonst "&" nicht anzeigt.
			ergLabel.Text = A + "&" + B + "&" + D + " | " + A + "&" + B + "&" + E + " | " + A + "&" + C + "&" + D + " | " + A + "&" + C + "&" + E + " "; //fügt die strings passend zusammen. 
			
		}
	}
}


