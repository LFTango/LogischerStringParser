namespace LogischerStringParser
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.AusdruckTextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.ergLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// AusdruckTextBox
			// 
			this.AusdruckTextBox.Location = new System.Drawing.Point(118, 33);
			this.AusdruckTextBox.Name = "AusdruckTextBox";
			this.AusdruckTextBox.Size = new System.Drawing.Size(171, 20);
			this.AusdruckTextBox.TabIndex = 0;
			this.AusdruckTextBox.Text = "A&(B|C)&(D|E)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(118, 122);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Start";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ergLabel
			// 
			this.ergLabel.AutoSize = true;
			this.ergLabel.BackColor = System.Drawing.SystemColors.Control;
			this.ergLabel.Location = new System.Drawing.Point(115, 91);
			this.ergLabel.Name = "ergLabel";
			this.ergLabel.Size = new System.Drawing.Size(0, 13);
			this.ergLabel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Neuer Ausdruck: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(51, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ausdruck: ";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 172);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ergLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.AusdruckTextBox);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox AusdruckTextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label ergLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

