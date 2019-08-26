using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for KilometreGiris.
	/// </summary>
	public class KilometreGiris : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox KilometretextBox;
		private System.Windows.Forms.Button Kaydetbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		Config config;

	
		public KilometreGiris(Config config)
		{
			this.config=config;
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
			this.KilometretextBox = new System.Windows.Forms.TextBox();
			this.Kaydetbutton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			// 
			// KilometretextBox
			// 
			this.KilometretextBox.Location = new System.Drawing.Point(40, 112);
			this.KilometretextBox.Size = new System.Drawing.Size(160, 20);
			this.KilometretextBox.Text = "";
			// 
			// Kaydetbutton
			// 
			this.Kaydetbutton.Location = new System.Drawing.Point(168, 248);
			this.Kaydetbutton.Text = "Kaydet";
			this.Kaydetbutton.Click += new System.EventHandler(this.Kaydetbutton_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(88, 88);
			this.label1.Size = new System.Drawing.Size(64, 20);
			this.label1.Text = "Kilometre";
			// 
			// KilometreGiris
			// 
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Kaydetbutton);
			this.Controls.Add(this.KilometretextBox);
			this.Menu = this.mainMenu1;
			this.Text = "KilometreGiris";

		}
		#endregion

		private void Kaydetbutton_Click(object sender, System.EventArgs e)
		{
			float kilometre;
			try
			{
				kilometre = Convert.ToSingle(KilometretextBox.Text);
			}
			catch
			{
				MessageBox.Show("Hatalý kilometre, kilometre alanýna sayýsal bir deðer girilmelidir.");
				return;
			}
			if(KilometretextBox.Text == string.Empty)
			{
				MessageBox.Show("Kilometre giriniz");			
				return;
			}
			else
			{
                SiparisIslemleri si = new SiparisIslemleri(config);
				si.InsertZiyaret("pl"+config.PlasiyerKodu,"gb",kilometre,config.PlasiyerKodu);
                this.Close();
			}

		}
	}
}
