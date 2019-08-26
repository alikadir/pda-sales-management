using System;
using System.Data;
using System.Data.SqlServerCe;

using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for ZiyaretForm.
	/// </summary>
	public class ZiyaretForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox FiyatlarPahali;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.CheckBox checkBox7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		SqlCeConnection Ceconn ;
		Cari cari;
		private System.Windows.Forms.TextBox KilometretextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MainMenu mainMenu1;
		Config config;

	
		public ZiyaretForm(Cari cari, Config config)
		{
			this.cari=cari;
			this.config=config;
			Ceconn = config.CeConn;
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
			this.FiyatlarPahali = new System.Windows.Forms.CheckBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.checkBox7 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.KilometretextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			// 
			// FiyatlarPahali
			// 
			this.FiyatlarPahali.Location = new System.Drawing.Point(8, 4);
			this.FiyatlarPahali.Size = new System.Drawing.Size(100, 16);
			this.FiyatlarPahali.Text = "Fiyatlar Pahalý";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(8, 28);
			this.checkBox1.Size = new System.Drawing.Size(100, 16);
			this.checkBox1.Text = "Yetkili Yok";
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(8, 52);
			this.checkBox2.Size = new System.Drawing.Size(100, 16);
			this.checkBox2.Text = "Yeterli Malý Var";
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(8, 76);
			this.checkBox3.Size = new System.Drawing.Size(100, 16);
			this.checkBox3.Text = "Parasý Yok";
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(8, 100);
			this.checkBox4.Size = new System.Drawing.Size(100, 16);
			this.checkBox4.Text = "Sorunlu Müþteri";
			// 
			// checkBox5
			// 
			this.checkBox5.Location = new System.Drawing.Point(8, 124);
			this.checkBox5.Size = new System.Drawing.Size(100, 16);
			this.checkBox5.Text = "Müþteri Kapalý";
			// 
			// checkBox6
			// 
			this.checkBox6.Location = new System.Drawing.Point(8, 148);
			this.checkBox6.Size = new System.Drawing.Size(100, 16);
			this.checkBox6.Text = "Dükkan El Deðiþti";
			// 
			// checkBox7
			// 
			this.checkBox7.Location = new System.Drawing.Point(8, 172);
			this.checkBox7.Size = new System.Drawing.Size(100, 16);
			this.checkBox7.Text = "Diðer";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 248);
			this.button1.Text = "Kaydet";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 248);
			this.button2.Text = "Kapat";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// KilometretextBox
			// 
			this.KilometretextBox.Location = new System.Drawing.Point(80, 196);
			this.KilometretextBox.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 196);
			this.label1.Size = new System.Drawing.Size(68, 16);
			this.label1.Text = "Kilometre";
			// 
			// ZiyaretForm
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.KilometretextBox);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox7);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.FiyatlarPahali);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "Ziyaret Kaydý";
			this.Load += new System.EventHandler(this.ZiyaretForm_Load);

		}
		#endregion

		private void button2_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, System.EventArgs e)
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
			
			InsertZiyaret(cari.carino,GetChecked(),kilometre, config.PlasiyerKodu);
			MessageBox.Show("Ziyaret kaydý alýndý");
			this.Close();
		
		}


		public void InsertZiyaret(string Cari_No, string Ziyaret_Turu, float Kilometre, string Plasiyer_Kodu)
		{
					
			string sql = "INSERT INTO Ziyaret (Cari_No,Ziyaret_turu,Kilometre,Ziyaret_Tarih, Plasiyer_Kodu) values ( "+
				"'"+Cari_No+"','"+Ziyaret_Turu+"',"+Kilometre+",'"+DateTime.Now.ToString("MM/dd/yyyy")+"','"+Plasiyer_Kodu+"' )";
			SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
			cmd.ExecuteNonQuery();
			
		}

		string GetChecked()
		{
			string text = "";
			if(FiyatlarPahali.Checked)
				text +=FiyatlarPahali.Text+";";
			if(	checkBox1.Checked)
				text +=	checkBox1.Text+";";
			if(	checkBox2.Checked)
				text +=	checkBox2.Text+";";
			if(	checkBox3.Checked)
				text +=	checkBox3.Text+";";
			if(	checkBox4.Checked)
				text +=	checkBox4.Text+";";
			if(	checkBox5.Checked)
				text +=	checkBox5.Text+";";
			if(	checkBox6.Checked)
				text +=	checkBox6.Text+";";
			if(	checkBox7.Checked)
				text +=	checkBox7.Text+";";
			return text;


		}

		private void ZiyaretForm_Load(object sender, System.EventArgs e)
		{
			
			string bcount = "select count(*) from Ziyaret where Cari_No = '"+cari.carino+"'";
			SqlCeCommand cmd = new SqlCeCommand(bcount,Ceconn);
			int i =  Convert.ToInt16(cmd.ExecuteScalar().ToString());
			if(i != 0)
			{
				MessageBox.Show(cari.carino +" no lu cariye daha önce kayýt yapýlmýþtýr");
				this.Close();
			}
					
		}
	}
}
