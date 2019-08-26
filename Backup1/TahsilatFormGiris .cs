using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for TahsilatFormGiris .
	/// </summary>
	public class TahsilatFormGiris  : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label musteriadilabel;
		private System.Windows.Forms.Label musterinolabel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button Ileri;
		private System.Windows.Forms.Button button1;
		Cari cari;
		Config config;
		
		SqlCeConnection CeConn;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox KilometretextBox;	
		SqlCeCommand cmd = new SqlCeCommand();

	
		public TahsilatFormGiris (Cari cari, Config config)
		{
			this.config=config;
			this.cari = cari;			
			this.CeConn= config.CeConn;
			cmd.Connection=CeConn;
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
			this.musteriadilabel = new System.Windows.Forms.Label();
			this.musterinolabel = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Ileri = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.KilometretextBox = new System.Windows.Forms.TextBox();
			// 
			// musteriadilabel
			// 
			this.musteriadilabel.Location = new System.Drawing.Point(80, 32);
			this.musteriadilabel.Size = new System.Drawing.Size(150, 48);
			// 
			// musterinolabel
			// 
			this.musterinolabel.Location = new System.Drawing.Point(80, 8);
			this.musterinolabel.Size = new System.Drawing.Size(122, 12);
			this.musterinolabel.ParentChanged += new System.EventHandler(this.musterinolabel_ParentChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(72, 8);
			this.label8.Size = new System.Drawing.Size(8, 11);
			this.label8.Text = ":";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(72, 32);
			this.label7.Size = new System.Drawing.Size(8, 11);
			this.label7.Text = ":";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Size = new System.Drawing.Size(80, 14);
			this.label3.Text = "Müþteri No";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Size = new System.Drawing.Size(80, 12);
			this.label4.Text = "Müþteri Adý";
			// 
			// Ileri
			// 
			this.Ileri.Location = new System.Drawing.Point(168, 240);
			this.Ileri.Text = "Ýleri >>";
			this.Ileri.Click += new System.EventHandler(this.Ileri_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 240);
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(8, 88);
			this.label1.Size = new System.Drawing.Size(64, 12);
			this.label1.Text = "Kilometre";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(72, 88);
			this.label2.Size = new System.Drawing.Size(8, 11);
			this.label2.Text = ":";
			// 
			// KilometretextBox
			// 
			this.KilometretextBox.Location = new System.Drawing.Point(80, 88);
			this.KilometretextBox.Text = "";
			// 
			// TahsilatFormGiris
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.KilometretextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Ileri);
			this.Controls.Add(this.musteriadilabel);
			this.Controls.Add(this.musterinolabel);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "Tahsilat Kaydý";
			this.Load += new System.EventHandler(this.TahsilatFormGiris_Load);

		}
		#endregion

		private void musterinolabel_ParentChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			
			this.Close();
		}

		private void Ileri_Click(object sender, System.EventArgs e)
		{
			float kilometre = 0;
			if(KilometretextBox.Text.Trim() != string.Empty || KilometretextBox.Text.Trim() != "")
			{
				try
				{
					kilometre = Convert.ToSingle(KilometretextBox.Text);					
				}
				catch
				{
					MessageBox.Show("Kilometre alanýna girilen deðer sayýsal olmalýdýr");
					return;
				}
			}


			int makbuzno = MakbuzNo();
		
			this.Close();
			TahsilatForm tf = new TahsilatForm(config,cari,makbuzno,kilometre);
			tf.Show();
		}

		int MakbuzNo()
		{
			int i;

			string sql = "";
		
			sql ="Insert Into TahsilatBaslik (Cari_No,Plasiyer_Kodu,Tahsilat_Tarihi) ";
			sql += " VALUES('"+cari.carino+"','"+config.PlasiyerKodu+"','"+DateTime.Now.ToString("MM/dd/yyyy")+"')";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();
			cmd.CommandText="select @@identity";
			i = Convert.ToInt16(cmd.ExecuteScalar().ToString());		
			return i;
			
		}

		private void TahsilatFormGiris_Load(object sender, System.EventArgs e)
		{
			musterinolabel.Text=cari.carino;
			musteriadilabel.Text=cari.cariadi;
		}

		


	}
}
