namespace WindowsForm_Demo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSummeBerechnen_Click(object sender, EventArgs e)
		{
			if (txtZahl1.Text != null && textZahl2.Text != null)
			{
				int zahl1; int zahl2;
				try
				{
					zahl1 = int.Parse(txtZahl1.Text);
					zahl2 = int.Parse(textZahl2.Text);
					lblSumme.Text = (zahl1 + zahl2).ToString();
				}
				catch (FormatException)
				{
					MessageBox.Show("Bitte nur Zahlen eingeben");
				}
				catch (OverflowException)
				{
					MessageBox.Show("Nicht übertreiben!");
				}
			}
		}
	}
}
