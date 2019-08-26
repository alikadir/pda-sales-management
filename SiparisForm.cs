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
	/// Summary description for SiparisForm.
	/// </summary>
	public class SiparisForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label cariadi;
		private System.Windows.Forms.Label carino;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label ortalamavade;
		private System.Windows.Forms.Label borcbakiye;
		private System.Windows.Forms.Label toplamrisk;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox VadetextBox;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox odemeSeklicomboBox;
		private System.Windows.Forms.Button Kaydet;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		SqlCeConnection Ceconn;
		Config cf;
		private System.Windows.Forms.ComboBox Yil;
		private System.Windows.Forms.ComboBox Ay;
		private System.Windows.Forms.ComboBox Gun;
		Cari c;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox KilometretextBox;
		DateCombos dc ;
		
	
		public SiparisForm(string CariNo, Config cf)
		{
			this.cf=cf;
			InitializeComponent();
			c = new Cari(CariNo,cf);
			Ceconn = cf.CeConn;

			cariadi.Text = c.cariadi;
			carino.Text=CariNo;
			odemeSeklicomboBox.SelectedIndex=0;
			
			
			toplamrisk.Text=c.toplamrisk;
			borcbakiye.Text=c.borcbakiye;
			ortalamavade.Text=c.ortalamavade;
		
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
			this.cariadi = new System.Windows.Forms.Label();
			this.carino = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.ortalamavade = new System.Windows.Forms.Label();
			this.borcbakiye = new System.Windows.Forms.Label();
			this.toplamrisk = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.VadetextBox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.odemeSeklicomboBox = new System.Windows.Forms.ComboBox();
			this.Kaydet = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Yil = new System.Windows.Forms.ComboBox();
			this.Ay = new System.Windows.Forms.ComboBox();
			this.Gun = new System.Windows.Forms.ComboBox();
			this.KilometretextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			// 
			// cariadi
			// 
			this.cariadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.cariadi.Location = new System.Drawing.Point(83, 31);
			this.cariadi.Size = new System.Drawing.Size(147, 27);
			this.cariadi.Text = "bos";
			// 
			// carino
			// 
			this.carino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.carino.Location = new System.Drawing.Point(83, 9);
			this.carino.Size = new System.Drawing.Size(139, 20);
			this.carino.Text = "bos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(74, 29);
			this.label3.Size = new System.Drawing.Size(8, 20);
			this.label3.Text = ":";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(0, 30);
			this.label4.Size = new System.Drawing.Size(84, 20);
			this.label4.Text = "Adý";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(75, 7);
			this.label2.Size = new System.Drawing.Size(8, 20);
			this.label2.Text = ":";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(1, 7);
			this.label1.Size = new System.Drawing.Size(84, 20);
			this.label1.Text = "Cari No";
			// 
			// ortalamavade
			// 
			this.ortalamavade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.ortalamavade.Location = new System.Drawing.Point(83, 114);
			this.ortalamavade.Size = new System.Drawing.Size(150, 18);
			this.ortalamavade.Text = "bos";
			// 
			// borcbakiye
			// 
			this.borcbakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.borcbakiye.Location = new System.Drawing.Point(82, 92);
			this.borcbakiye.Size = new System.Drawing.Size(150, 18);
			this.borcbakiye.Text = "bos";
			// 
			// toplamrisk
			// 
			this.toplamrisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.toplamrisk.Location = new System.Drawing.Point(81, 69);
			this.toplamrisk.Size = new System.Drawing.Size(150, 18);
			this.toplamrisk.Text = "bos";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(74, 114);
			this.label15.Size = new System.Drawing.Size(5, 10);
			this.label15.Text = ":";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(0, 115);
			this.label16.Size = new System.Drawing.Size(84, 20);
			this.label16.Text = "Ort. Vade";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(74, 91);
			this.label13.Size = new System.Drawing.Size(5, 10);
			this.label13.Text = ":";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label14.Location = new System.Drawing.Point(0, 92);
			this.label14.Size = new System.Drawing.Size(84, 20);
			this.label14.Text = "Borç Bakiye";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(75, 68);
			this.label11.Size = new System.Drawing.Size(5, 10);
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(0, 69);
			this.label12.Size = new System.Drawing.Size(84, 20);
			this.label12.Text = "Toplam Risk";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(0, 161);
			this.label9.Size = new System.Drawing.Size(84, 20);
			this.label9.Text = "Vade";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(74, 158);
			this.label10.Size = new System.Drawing.Size(5, 10);
			this.label10.Text = ":";
			// 
			// VadetextBox
			// 
			this.VadetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.VadetextBox.Location = new System.Drawing.Point(84, 157);
			this.VadetextBox.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(74, 136);
			this.label17.Size = new System.Drawing.Size(5, 10);
			this.label17.Text = ":";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label18.Location = new System.Drawing.Point(0, 138);
			this.label18.Size = new System.Drawing.Size(84, 20);
			this.label18.Text = "Ödeme Þekli";
			// 
			// odemeSeklicomboBox
			// 
			this.odemeSeklicomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.odemeSeklicomboBox.Items.Add("Kredi kartý");
			this.odemeSeklicomboBox.Items.Add("Cek");
			this.odemeSeklicomboBox.Items.Add("Senet");
			this.odemeSeklicomboBox.Items.Add("Nakit");
			this.odemeSeklicomboBox.Location = new System.Drawing.Point(84, 132);
			this.odemeSeklicomboBox.Size = new System.Drawing.Size(100, 20);
			// 
			// Kaydet
			// 
			this.Kaydet.Location = new System.Drawing.Point(163, 247);
			this.Kaydet.Size = new System.Drawing.Size(72, 19);
			this.Kaydet.Text = "Ýleri";
			this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(74, 181);
			this.label5.Size = new System.Drawing.Size(5, 10);
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(0, 184);
			this.label6.Size = new System.Drawing.Size(84, 20);
			this.label6.Text = "Teslim Tarihi";
			// 
			// Yil
			// 
			this.Yil.Location = new System.Drawing.Point(183, 179);
			this.Yil.Size = new System.Drawing.Size(50, 20);
			// 
			// Ay
			// 
			this.Ay.Location = new System.Drawing.Point(126, 179);
			this.Ay.Size = new System.Drawing.Size(54, 20);
			// 
			// Gun
			// 
			this.Gun.Location = new System.Drawing.Point(84, 179);
			this.Gun.Size = new System.Drawing.Size(40, 20);
			// 
			// KilometretextBox
			// 
			this.KilometretextBox.Location = new System.Drawing.Point(84, 204);
			this.KilometretextBox.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(74, 207);
			this.label7.Size = new System.Drawing.Size(5, 10);
			this.label7.Text = ":";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(0, 207);
			this.label8.Size = new System.Drawing.Size(84, 20);
			this.label8.Text = "Kilometre";
			// 
			// SiparisForm
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.KilometretextBox);
			this.Controls.Add(this.Yil);
			this.Controls.Add(this.Ay);
			this.Controls.Add(this.Gun);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Kaydet);
			this.Controls.Add(this.odemeSeklicomboBox);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.VadetextBox);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.ortalamavade);
			this.Controls.Add(this.borcbakiye);
			this.Controls.Add(this.toplamrisk);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.cariadi);
			this.Controls.Add(this.carino);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "Sipariþ Kaydý";
			this.Load += new System.EventHandler(this.SiparisForm_Load);

		}
		#endregion

		private void SiparisForm_Load(object sender, System.EventArgs e)
		{//
			dc = new DateCombos(Gun,Ay,Yil);
			dc.SetDate(DateTime.Now.AddDays(1));
		}

		private void Kaydet_Click(object sender, System.EventArgs e)
		{
			if(VadetextBox.Text.Trim() == string.Empty || VadetextBox.Text.Trim() == "")
			{
				MessageBox.Show("Vade belirtmediniz");
			}
			int vade = 0;
			try
			{
				vade = Convert.ToInt16(VadetextBox.Text);
			}
			catch
			{
				MessageBox.Show("Vade alanýna sayýsal bir deðer girilmelidir");
				return;
			}

			int Max = 0;
			string Field = cf.GetVadeField(odemeSeklicomboBox.SelectedItem.ToString().Substring(0,1),out Max);
			if(Convert.ToInt16(VadetextBox.Text) > Max)
			{
				MessageBox.Show("Hata! \r\n Girilen Vade "+Max.ToString()+" den büyük olamaz");
				return ;
			}
            

			DateTime teslimTarihi = dc.Getdate;
			if(teslimTarihi.Year == DateTime.MinValue.Year)
			{			
				MessageBox.Show("Geçersiz tarih!\r\nLütfen tarihi kontrol ediniz");
				return ;
			
            
			}

			float kilometre = 0;
			if(KilometretextBox.Text.Trim() != string.Empty || KilometretextBox.Text != "")
			{
				try
				{
					kilometre = Convert.ToSingle(KilometretextBox.Text);
				
				}
				catch
				{
					MessageBox.Show("Geçersiz kilometre!\r\n");
					return ;			
				}
			}

			

           int siparisNo =  InsertMainSparis(c.carino, c.cariadi, cf.PlasiyerKodu, 
				teslimTarihi,Convert.ToInt16(VadetextBox.Text),
				odemeSeklicomboBox.SelectedItem.ToString().Substring(0,1));
			SiparisDetay sd = new SiparisDetay(cf, siparisNo,c,odemeSeklicomboBox.SelectedItem.ToString().Substring(0,1),kilometre);
			sd.Show();
			this.Close();
		}

		int InsertMainSparis(string MusteriKodu, string MusteriAdi, string PlasiyerKodu,
			DateTime teslimTarihi, int vadeGunu, string odemeSekli)
		{
			MusteriAdi = MusteriAdi.Replace("'","''");
			
			string dt = DateTime.Now.ToString("MM/dd/yyyy"); 
			string tsdt = teslimTarihi.ToString("MM/dd/yyyy"); 		
			string sql = "insert into SiparisBaslik "+
				"(Musteri_Kodu, Musteri_Adi, Plasiyer_Kodu,Siparis_Tarihi, Teslim_Tarihi, "+
				" Vade_Gunu, Odeme_Sekli)"+
				" VALUES ("+
				" '"+MusteriKodu+"',"+
				" '"+MusteriAdi+"',"+
				" '"+PlasiyerKodu+"',"+
				" '"+dt+"',"+
				" '"+tsdt+"',"+
				" "+vadeGunu+","+
				" '"+odemeSekli+"'"+
				")";
			SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
			cmd.ExecuteNonQuery();
			cmd.CommandText="select @@identity";		
			int s =  Convert.ToInt16(cmd.ExecuteScalar().ToString());
				
			return s;

		}

	}
}
