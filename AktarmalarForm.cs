using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for AktarmalarForm.
	/// </summary>
	public class AktarmalarForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button baslat;
		private System.Windows.Forms.Button VeriTabaniOlustur;
		Config config;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label mesaj;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox Offline;
		DB db;
		public AktarmalarForm(Config c)
		{
		
			
			InitializeComponent();
			this.config=c;
           

			 c.CeConn.Close();
			
			
		}

		
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AktarmalarForm));
			this.baslat = new System.Windows.Forms.Button();
			this.VeriTabaniOlustur = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.mesaj = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Offline = new System.Windows.Forms.CheckBox();
			// 
			// baslat
			// 
			this.baslat.Location = new System.Drawing.Point(40, 80);
			this.baslat.Size = new System.Drawing.Size(144, 20);
			this.baslat.Text = "Veri iletiþimi";
			this.baslat.Click += new System.EventHandler(this.baslat_Click);
			// 
			// VeriTabaniOlustur
			// 
			this.VeriTabaniOlustur.Location = new System.Drawing.Point(40, 8);
			this.VeriTabaniOlustur.Size = new System.Drawing.Size(144, 20);
			this.VeriTabaniOlustur.Text = "Veri tabanýný oluþtur";
			this.VeriTabaniOlustur.Click += new System.EventHandler(this.VeriTabaniOlustur_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 200);
			this.label1.Size = new System.Drawing.Size(224, 32);
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// mesaj
			// 
			this.mesaj.Location = new System.Drawing.Point(32, 120);
			this.mesaj.Size = new System.Drawing.Size(176, 48);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(8, 240);
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// Offline
			// 
			this.Offline.Checked = true;
			this.Offline.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Offline.Location = new System.Drawing.Point(56, 48);
			this.Offline.Text = "Offline";
			// 
			// AktarmalarForm
			// 
			this.ControlBox = false;
			this.Controls.Add(this.Offline);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mesaj);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.VeriTabaniOlustur);
			this.Controls.Add(this.baslat);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Text = "Data aktarmalarý";
			this.Load += new System.EventHandler(this.AktarmalarForm_Load);

		}
		#endregion

		private void AktarmalarForm_Load(object sender, System.EventArgs e)
		{
			
		
		}

		bool CheckSycnh(out bool err)
		{
			int i =0;
			int x = 0;
			try
			{
				SqlConnection conn = new SqlConnection(config.ConnectionString);
				conn.Open();			
				string sql = " select count(*) from tahsilatBaslik where Plasiyer_Kodu = '"+config.PlasiyerKodu+"'";
				SqlCommand cmd = new SqlCommand(sql,conn);
				i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
				sql = " select count(*) from siparisBaslik where Plasiyer_Kodu = '"+config.PlasiyerKodu+"'";
				cmd.CommandText=sql;
				x =  Convert.ToInt16(cmd.ExecuteScalar().ToString());
				conn.Close();
				err = true;
			}
			catch(SqlException ex)
			{
				err = false;
				return false;

			}

            return (i+x) > 0;			

		}


		

		private void baslat_Click(object sender, System.EventArgs e)
		{
			config.isOffline=Offline.Checked;
			bool err = false;	
			if(CheckSycnh(out err))
			{
				
				MessageBox.Show("Sunucuda "+config.PlasiyerKodu+" kodlu plasiyere ait aktarýlmamýþ veriler var!\r\nAktarma devam edemez. Lütfen Sql servdan verileri alýnýz");
				baslat.Enabled=false;
				VeriTabaniOlustur.Enabled=false;
			
			}
			else
			{
				if(!err)
				{
					MessageBox.Show("Sql servera baðlanýrken bir hata oluþtu. Ayarlarý kontrol edin");					
					return;				
				}
			}
				
			
			#region stok aktarma
			try
			{
				mesaj.Text="Stok bilgileri aktarýlýyor";
				Application.DoEvents();

				if(config == null)
				{
					config=new Config();
					config.SetProertyes();
					
				}
				config.isOffline = Offline.Checked;

				if(db == null)
					db = new DB(config,true);
				db.stokOkuYaz(label1);
				
			
				mesaj.Text="";
			
			}
			catch(Exception ex)
			{
				MessageBox.Show("Stok bilgileri aktarýlýrken bir hata oluþtu","Dikkat");
			}
#endregion

			#region cari aktarma
			try
			{			
				mesaj.Text="Cari aktarýlýyor";
				Application.DoEvents();
				if(config == null)
				{
					config=new Config();
					config.SetProertyes();
				}
				if(db == null)
					db = new DB(config,true);
				db.CariOkuYaz(config.PlasiyerKodu,label1);
			
				label1.Text="";
			
			
				mesaj.Text="";
			}
			catch
			{
				MessageBox.Show("Cari aktarýlýrken bir hata opluþtu");
			}
			#endregion
			
			#region caridata aktarma
			try
			{
				mesaj.Text="Cari bilgileri aktarýlýyor";
				Application.DoEvents();
				if(config == null)
				{
					config=new Config();
					config.SetProertyes();
				}
				if(db == null)
					db = new DB(config,true);
				db.CariDataOkuYaz(config.PlasiyerKodu,label1);
				
				mesaj.Text="";				
			}
			catch
			{
				MessageBox.Show("Cari aktarýlýrken bir hata oluþtu");
			}
			#endregion
			

			mesaj.Text="Sipariþ baþlýk tablosu aktarýlýyor";
			Application.DoEvents();
			db.PdaSiparisBaslikOku(label1);

			mesaj.Text="Sipariþ detay tablosu aktarýlýyor";
			Application.DoEvents();
			db.PdaSiparisDetayOku(label1);
			
			mesaj.Text="Tahsilat baþlýk tablosu aktarýlýyor";
			Application.DoEvents();
			db.PdaTahsilatBaslikOku(label1);
			
			mesaj.Text="Tahsilat detay tablosu aktarýlýyor";
			Application.DoEvents();
			db.PdaTahsilatDetayOku(label1);
			
			mesaj.Text="Ziyaret tablosu aktarýlýyor";
			Application.DoEvents();
			db.PdaZiyaretOku(label1);
			mesaj.Text="Aktarmalar tamamlandý";
			label1.Text="";
			
		}

		private void VeriTabaniOlustur_Click(object sender, System.EventArgs e)
		{
			try
			{
				mesaj.Text="Veri Tabaný Oluþturuluyor";
				Application.DoEvents();

				db = new DB(config);
				MessageBox.Show("Veri tabaný oluþturuldu");
				baslat.Enabled=true;
				label1.Text="";
				mesaj.Text="";
			}
			catch
			{
				MessageBox.Show("Veri tabaný oluþturulurken bir hata oluþtu","Dikkat");
			}


		

			
		}

	

		

		
		
		
		private void button1_Click_1(object sender, System.EventArgs e)
		{
			config.CeConn.Open();
			this.Close();
		}
	}
}
