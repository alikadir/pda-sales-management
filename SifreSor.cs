using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for SifreSor.
	/// </summary>
	public class SifreSor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Button button2;
		Config config;
	
		public SifreSor(Config c)
		{
			this.config=c;
			
			InitializeComponent();			
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.button2 = new System.Windows.Forms.Button();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(64, 104);
			this.textBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 152);
			this.button1.Text = "Giriþ";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 248);
			this.button2.Text = "Çýkýþ";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// SifreSor
			// 
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Menu = this.mainMenu1;
			this.Text = "Þifrenizi Giriniz";
			this.Load += new System.EventHandler(this.SifreSor_Load);

		}
		#endregion

		private void SifreSor_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            DateTime dt = DateTime.Now;
			int toplam = dt.Year+dt.Day+dt.Month+dt.Hour;
			string sifre = toplam.ToString() +"00";			
			if(textBox1.Text == sifre)
			{
				this.Enabled=false;
				ConfigurationForm cf = new ConfigurationForm();
				cf.ShowDialog();
				this.Enabled=true;
                
			}
			else
			{
				MessageBox.Show("Hatalý þifre!");
				this.Close();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
