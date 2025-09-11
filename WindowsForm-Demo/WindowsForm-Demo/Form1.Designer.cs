namespace WindowsForm_Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			txtZahl1 = new TextBox();
			textZahl2 = new TextBox();
			label2 = new Label();
			btnSummeBerechnen = new Button();
			lblSumme = new Label();
			SuspendLayout();
			// 
			// txtZahl1
			// 
			txtZahl1.Location = new Point(41, 58);
			txtZahl1.Name = "txtZahl1";
			txtZahl1.Size = new Size(200, 39);
			txtZahl1.TabIndex = 0;
			txtZahl1.Text = "Zahl 1 eingeben";
			// 
			// textZahl2
			// 
			textZahl2.BackColor = SystemColors.MenuHighlight;
			textZahl2.Location = new Point(284, 58);
			textZahl2.Name = "textZahl2";
			textZahl2.Size = new Size(200, 39);
			textZahl2.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(284, 25);
			label2.Name = "label2";
			label2.Size = new Size(188, 32);
			label2.TabIndex = 3;
			label2.Text = "Zahl 2 eingeben";
			// 
			// btnSummeBerechnen
			// 
			btnSummeBerechnen.Location = new Point(556, 60);
			btnSummeBerechnen.Name = "btnSummeBerechnen";
			btnSummeBerechnen.Size = new Size(150, 46);
			btnSummeBerechnen.TabIndex = 4;
			btnSummeBerechnen.Text = "Summe Berechen";
			btnSummeBerechnen.UseVisualStyleBackColor = true;
			btnSummeBerechnen.Click += btnSummeBerechnen_Click;
			// 
			// lblSumme
			// 
			lblSumme.AutoSize = true;
			lblSumme.Location = new Point(45, 164);
			lblSumme.Name = "lblSumme";
			lblSumme.Size = new Size(0, 32);
			lblSumme.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(13F, 32F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(817, 473);
			Controls.Add(lblSumme);
			Controls.Add(btnSummeBerechnen);
			Controls.Add(label2);
			Controls.Add(textZahl2);
			Controls.Add(txtZahl1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtZahl1;
		private TextBox textZahl2;
		private Label label2;
		private Button btnSummeBerechnen;
		private Label lblSumme;
	}
}
