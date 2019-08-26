using System;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	
	public class TahsilatForm : System.Windows.Forms.Form
	{
		Config config;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox odemeSeklicomboBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Button BelgeDetaybutton1;
		private System.Windows.Forms.TextBox BankatextBox;
		private System.Windows.Forms.TextBox SubetextBox;
		private System.Windows.Forms.TextBox CeknotextBox;
		private System.Windows.Forms.TextBox knotextBox;
		private System.Windows.Forms.TextBox TutartextBox;
		private System.Windows.Forms.TextBox tanzimYeritextBox;
		private System.Windows.Forms.Label borctutarilabel;
		private System.Windows.Forms.Button Kaydet;
		private System.Windows.Forms.ComboBox Gun;
		private System.Windows.Forms.ComboBox Ay;
		private System.Windows.Forms.ComboBox Yil;
		Cari cari;
		DateCombos dc;
		private System.Windows.Forms.MainMenu mainMenu1;
		string OdemeSekli;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ParaTuru;
		private System.Windows.Forms.TextBox TanzimTarihtextBox;
		SqlCeConnection Ceconn;
		int MakbuzNo;
		private System.Windows.Forms.TextBox knotextBox2;
		private System.Windows.Forms.TextBox knotextBox4;
		private System.Windows.Forms.TextBox knotextBox3;
		private System.Windows.Forms.TextBox borclutextBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		float kilometre;

		public TahsilatForm(Config config, Cari cari, int MakbuzNo, float kilometre)
		{
			this.config = config;
			this.cari=cari;
			Ceconn = config.CeConn;
			
			this.MakbuzNo = MakbuzNo;
			this.kilometre=kilometre;

			
			
			
			InitializeComponent();
			dc = new DateCombos(Gun,Ay,Yil);
			odemeSeklicomboBox.SelectedIndex=0;
			borclutextBox.Text= cari.cariadi;

			
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
			this.BelgeDetaybutton1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.odemeSeklicomboBox = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.BankatextBox = new System.Windows.Forms.TextBox();
			this.SubetextBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.CeknotextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.knotextBox = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.TutartextBox = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.TanzimTarihtextBox = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.tanzimYeritextBox = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.borctutarilabel = new System.Windows.Forms.Label();
			this.Kaydet = new System.Windows.Forms.Button();
			this.Gun = new System.Windows.Forms.ComboBox();
			this.Ay = new System.Windows.Forms.ComboBox();
			this.Yil = new System.Windows.Forms.ComboBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.ParaTuru = new System.Windows.Forms.ComboBox();
			this.knotextBox2 = new System.Windows.Forms.TextBox();
			this.knotextBox4 = new System.Windows.Forms.TextBox();
			this.knotextBox3 = new System.Windows.Forms.TextBox();
			this.borclutextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			// 
			// BelgeDetaybutton1
			// 
			this.BelgeDetaybutton1.Location = new System.Drawing.Point(176, 20);
			this.BelgeDetaybutton1.Size = new System.Drawing.Size(60, 20);
			this.BelgeDetaybutton1.Text = "Detay";
			this.BelgeDetaybutton1.Click += new System.EventHandler(this.BelgeDetaybutton1_Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label3.Location = new System.Drawing.Point(0, 4);
			this.label3.Size = new System.Drawing.Size(60, 12);
			this.label3.Text = "Borc tutarý";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(0, 22);
			this.label4.Size = new System.Drawing.Size(60, 11);
			this.label4.Text = "T. Türü";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(58, 20);
			this.label5.Size = new System.Drawing.Size(8, 11);
			this.label5.Text = ":";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(58, 4);
			this.label6.Size = new System.Drawing.Size(8, 11);
			this.label6.Text = ":";
			// 
			// odemeSeklicomboBox
			// 
			this.odemeSeklicomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.odemeSeklicomboBox.Items.Add("Kredi kartý");
			this.odemeSeklicomboBox.Items.Add("Cek");
			this.odemeSeklicomboBox.Items.Add("Senet");
			this.odemeSeklicomboBox.Items.Add("Nakit");
			this.odemeSeklicomboBox.Location = new System.Drawing.Point(66, 20);
			this.odemeSeklicomboBox.Size = new System.Drawing.Size(100, 20);
			this.odemeSeklicomboBox.SelectedIndexChanged += new System.EventHandler(this.odemeSeklicomboBox_SelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(58, 42);
			this.label9.Size = new System.Drawing.Size(8, 11);
			this.label9.Text = ":";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(0, 44);
			this.label10.Size = new System.Drawing.Size(60, 11);
			this.label10.Text = "Banka";
			// 
			// BankatextBox
			// 
			this.BankatextBox.Location = new System.Drawing.Point(66, 42);
			this.BankatextBox.Text = "";
			// 
			// SubetextBox
			// 
			this.SubetextBox.Location = new System.Drawing.Point(66, 80);
			this.SubetextBox.Text = "";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(58, 80);
			this.label11.Size = new System.Drawing.Size(8, 11);
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(0, 82);
			this.label12.Size = new System.Drawing.Size(60, 11);
			this.label12.Text = "Þube";
			// 
			// CeknotextBox
			// 
			this.CeknotextBox.Location = new System.Drawing.Point(66, 122);
			this.CeknotextBox.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(58, 122);
			this.label13.Size = new System.Drawing.Size(8, 11);
			this.label13.Text = ":";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(0, 124);
			this.label14.Size = new System.Drawing.Size(60, 11);
			this.label14.Text = "Çek No";
			// 
			// knotextBox
			// 
			this.knotextBox.Location = new System.Drawing.Point(66, 102);
			this.knotextBox.MaxLength = 4;
			this.knotextBox.Size = new System.Drawing.Size(40, 18);
			this.knotextBox.Text = "";
			this.knotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.knotextBox_KeyPress);
			this.knotextBox.TextChanged += new System.EventHandler(this.knotextBox_TextChanged);
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(58, 102);
			this.label15.Size = new System.Drawing.Size(8, 11);
			this.label15.Text = ":";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label16.Location = new System.Drawing.Point(0, 104);
			this.label16.Size = new System.Drawing.Size(60, 11);
			this.label16.Text = "K.No";
			// 
			// TutartextBox
			// 
			this.TutartextBox.Location = new System.Drawing.Point(66, 204);
			this.TutartextBox.Text = "";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(58, 206);
			this.label17.Size = new System.Drawing.Size(8, 11);
			this.label17.Text = ":";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label18.Location = new System.Drawing.Point(0, 208);
			this.label18.Size = new System.Drawing.Size(60, 11);
			this.label18.Text = "Tutar";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(58, 184);
			this.label19.Size = new System.Drawing.Size(8, 11);
			this.label19.Text = ":";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label20.Location = new System.Drawing.Point(0, 184);
			this.label20.Size = new System.Drawing.Size(60, 11);
			this.label20.Text = "Vade";
			// 
			// TanzimTarihtextBox
			// 
			this.TanzimTarihtextBox.Location = new System.Drawing.Point(66, 162);
			this.TanzimTarihtextBox.ReadOnly = true;
			this.TanzimTarihtextBox.Text = "";
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(58, 164);
			this.label21.Size = new System.Drawing.Size(8, 11);
			this.label21.Text = ":";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label22.Location = new System.Drawing.Point(0, 164);
			this.label22.Size = new System.Drawing.Size(60, 11);
			this.label22.Text = "Tarih";
			// 
			// tanzimYeritextBox
			// 
			this.tanzimYeritextBox.Location = new System.Drawing.Point(66, 142);
			this.tanzimYeritextBox.Text = "Ankara";
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(58, 142);
			this.label23.Size = new System.Drawing.Size(8, 11);
			this.label23.Text = ":";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label24.Location = new System.Drawing.Point(0, 144);
			this.label24.Size = new System.Drawing.Size(60, 11);
			this.label24.Text = "Tanzim Yeri";
			// 
			// borctutarilabel
			// 
			this.borctutarilabel.Location = new System.Drawing.Point(76, 4);
			this.borctutarilabel.Size = new System.Drawing.Size(122, 14);
			// 
			// Kaydet
			// 
			this.Kaydet.Location = new System.Drawing.Point(184, 250);
			this.Kaydet.Size = new System.Drawing.Size(56, 20);
			this.Kaydet.Text = "Kaydet";
			this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
			// 
			// Gun
			// 
			this.Gun.Location = new System.Drawing.Point(66, 182);
			this.Gun.Size = new System.Drawing.Size(40, 20);
			// 
			// Ay
			// 
			this.Ay.Location = new System.Drawing.Point(106, 182);
			this.Ay.Size = new System.Drawing.Size(54, 20);
			// 
			// Yil
			// 
			this.Yil.Location = new System.Drawing.Point(162, 182);
			this.Yil.Size = new System.Drawing.Size(64, 20);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(0, 250);
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(58, 230);
			this.label1.Size = new System.Drawing.Size(8, 11);
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(0, 232);
			this.label2.Size = new System.Drawing.Size(60, 11);
			this.label2.Text = "Para Türü";
			// 
			// ParaTuru
			// 
			this.ParaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.ParaTuru.Items.Add("YTL");
			this.ParaTuru.Items.Add("EUR");
			this.ParaTuru.Items.Add("USD");
			this.ParaTuru.Location = new System.Drawing.Point(66, 226);
			this.ParaTuru.Size = new System.Drawing.Size(100, 20);
			// 
			// knotextBox2
			// 
			this.knotextBox2.Location = new System.Drawing.Point(108, 102);
			this.knotextBox2.MaxLength = 4;
			this.knotextBox2.Size = new System.Drawing.Size(40, 18);
			this.knotextBox2.Text = "";
			// 
			// knotextBox4
			// 
			this.knotextBox4.Location = new System.Drawing.Point(192, 102);
			this.knotextBox4.MaxLength = 4;
			this.knotextBox4.Size = new System.Drawing.Size(40, 18);
			this.knotextBox4.Text = "";
			// 
			// knotextBox3
			// 
			this.knotextBox3.Location = new System.Drawing.Point(150, 102);
			this.knotextBox3.MaxLength = 4;
			this.knotextBox3.Size = new System.Drawing.Size(40, 18);
			this.knotextBox3.Text = "";
			// 
			// borclutextBox
			// 
			this.borclutextBox.Location = new System.Drawing.Point(66, 60);
			this.borclutextBox.Size = new System.Drawing.Size(170, 18);
			this.borclutextBox.Text = "";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(58, 60);
			this.label7.Size = new System.Drawing.Size(8, 11);
			this.label7.Text = ":";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(0, 62);
			this.label8.Size = new System.Drawing.Size(60, 11);
			this.label8.Text = "Borçlu";
			// 
			// TahsilatForm
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.borclutextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.knotextBox4);
			this.Controls.Add(this.knotextBox3);
			this.Controls.Add(this.knotextBox2);
			this.Controls.Add(this.ParaTuru);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Yil);
			this.Controls.Add(this.Ay);
			this.Controls.Add(this.Gun);
			this.Controls.Add(this.Kaydet);
			this.Controls.Add(this.borctutarilabel);
			this.Controls.Add(this.TutartextBox);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.TanzimTarihtextBox);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.tanzimYeritextBox);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.CeknotextBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.knotextBox);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.SubetextBox);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.BankatextBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.odemeSeklicomboBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BelgeDetaybutton1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "Tahsilat Kaydý";
			this.Load += new System.EventHandler(this.TahsilatForm_Load);

		}
		#endregion

		private void TahsilatForm_Load(object sender, System.EventArgs e)
		{
		
			borctutarilabel.Text=cari.borcbakiye;
			TanzimTarihtextBox.Text=DateTime.Now.ToString("dd/MMMM/yyyy");
			ParaTuru.SelectedIndex=0;
		

		}

		private void BelgeDetaybutton1_Click(object sender, System.EventArgs e)
		{
			CariBilgiForm cf = new CariBilgiForm(cari.carino, this.config);
			cf.Show();
		}

		private void odemeSeklicomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			OdemeSekli = odemeSeklicomboBox.SelectedItem.ToString().Substring(0,1).ToLower();			
			SetVade();
		}


		void SetVade()
		{
			disableAll();
			switch(OdemeSekli)
			{
				case "k":
				{
					dc.SetDate(DateTime.Now.AddDays(21));
					BankatextBox.ReadOnly=false;
					knotextBox.ReadOnly=false;		
						knotextBox2.ReadOnly=false;		
						knotextBox3.ReadOnly=false;		
						knotextBox4.ReadOnly=false;		
					break;
				}
				case "n":
					dc.SetDate(DateTime.Now);
					break;
				case "c":
				{
					dc.SetDate(DateTime.Now.AddDays(45));
					CeknotextBox.ReadOnly=false;
					BankatextBox.ReadOnly=false;
					SubetextBox.ReadOnly=false;
					break;
				}
				case "s":
					dc.SetDate(DateTime.Now.AddDays(21));
					break;

			}
		}

		void disableAll()
		{
			BankatextBox.ReadOnly=true;
			SubetextBox.ReadOnly=true;
			knotextBox.ReadOnly=true;
			knotextBox2.ReadOnly=true;
			knotextBox3.ReadOnly=true;
			knotextBox4.ReadOnly=true;
			CeknotextBox.ReadOnly=true;

		
		}
			



		private void Kaydet_Click(object sender, System.EventArgs e)
		{
			if(!checkRequire())
				return;

			if(CheckDate())
			{
				float tahsilat_tutari ;

				if(!CheckFloat(TutartextBox.Text,out tahsilat_tutari))
				{
					MessageBox.Show("Tahsilat tutarý hatalý");
					return;
				}
                string kartno = knotextBox.Text+"/"+
					knotextBox2.Text+"/"+
					knotextBox3.Text+"/"+
					knotextBox4.Text;

				IsertTahsilat(OdemeSekli,tahsilat_tutari,ParaTuru.SelectedItem.ToString(),
					dc.Getdate,borclutextBox.Text,Convert.ToDateTime(TanzimTarihtextBox.Text),tanzimYeritextBox.Text,
					BankatextBox.Text,SubetextBox.Text,kartno,MakbuzNo,config.PlasiyerKodu,cari.carino); 				
				SiparisIslemleri si = new SiparisIslemleri(config);
				si.InsertZiyaret(cari.carino,"Baþarýlý",this.kilometre,config.PlasiyerKodu);
				MessageBox.Show("Tahsilat kaydý yapýldý");
				Temizle();
				this.Close();
			}         				
		}

		bool checkRequire()
		{
			if(!BankatextBox.ReadOnly && BankatextBox.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Banka boþ býrakýlamaz");
				return false;
			}

			if(!SubetextBox.ReadOnly && SubetextBox.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Þube boþ býrakýlamaz");
				return false;
			}

			if(!knotextBox.ReadOnly)
			{
				try
				{
					uint i = Convert.ToUInt16(knotextBox.Text);
					i = Convert.ToUInt16(knotextBox2.Text);
					i = Convert.ToUInt16(knotextBox3.Text);
					i = Convert.ToUInt16(knotextBox4.Text);
				}
				catch
				{
					MessageBox.Show("Kart numarasý hatalý");
					return false;
				}
				if(knotextBox.Text.Trim().Length != 4 || 
					knotextBox2.Text.Trim().Length != 4 || 
					knotextBox3.Text.Trim().Length != 4 || 
					knotextBox4.Text.Trim().Length != 4 )
				{
					MessageBox.Show("Kart numarasý hatalý");
					return false;

				}
					

			}
			
			if(!CeknotextBox.ReadOnly && CeknotextBox.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Çek numarasý boþ býrakýlamaz");
				return false;
			}
			if(!tanzimYeritextBox.ReadOnly && tanzimYeritextBox.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Tanzim yeri boþ býrakýlamaz");
				return false;
			}
			return true;			
		}

		void Temizle()
		{
			BankatextBox.Text="";
			SubetextBox.Text="";
			knotextBox.Text="";
			CeknotextBox.Text="";
			tanzimYeritextBox.Text="";
			TutartextBox.Text="";

		}

		bool CheckFloat(string Text, out float val)
		{
			
			try
			{
				val = Convert.ToSingle(Text.Replace(",","."));
				return true;
			}
			catch(FormatException ex)
			{
				val = 0;
				return false;
			}
		}


		void IsertTahsilat(
			string Tahsilat_turu,
			float Tahsilat_tutari,
			string Para_cinsi,
			DateTime Vadesi,
			string borclu,
			DateTime Tanzim_tarihi,
			string Tanzim_Yeri,
			string Banka,
			string Banka_Sube,
			
			string Kkart_no,
            int Makbuz_no,
			string Plasiyer_Kodu,
			string Cari_No
			)
		{
            string sql = "INSERT INTO  TahsilatDetay (Tahsilat_turu, Tahsilat_tutari, "+
				" Para_Cinsi, Vadesi, Borclu, Tanzim_Tarihi, Tanzim_Yeri, Banka, Banka_sube, "+
				" KKart_no, makbuz_no, Plasiyer_Kodu, Cari_No) Values ( "+
				" '"+Tahsilat_turu+"' ," +
				" "+Tahsilat_tutari+" ," +
				" '"+Para_cinsi+"' ," +
				" '"+Vadesi.ToString("MM/dd/yyyy")+"' ," +
				" '"+borclu+"' ," +
				" '"+Tanzim_tarihi.ToString("MM/dd/yyyy")+"' ," +
				" '"+Tanzim_Yeri+"' ," +
				" '"+Banka+"' ," +
				" '"+Banka_Sube+"' ," +				
				" '"+Kkart_no+"' ," +
				" "+Makbuz_no+" ,"+
				" '"+Plasiyer_Kodu+"',"+
				" '"+Cari_No+"')";
			
			SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
			cmd.ExecuteNonQuery();
			
			
		}

		

		bool CheckDate()
		{
			TimeSpan ts = dc.Getdate.Subtract(DateTime.Now);		
			int fark = ts.Days;
			if(fark < 0 )
			{
				MessageBox.Show("Geçmiþ tarih seçilemez\r\n Tarih bugüne ayarlandý");
				dc.SetDate(DateTime.Now);
				return false;
			}

			switch(OdemeSekli)
			{
				case "k":
					if (fark > 21)
					{
						MessageBox.Show("Kredi kartýnda vade 21 günden fazla olamaz\r\n Tarih bu güne ayarlandý!");
						return false;
					}
                        
					break;
				case "n":
					if (fark > 0)
					{
						MessageBox.Show("Nakitte vade 0 günden fazla olamaz\r\n Tarih bu güne ayarlandý!");
						return false;
					}
					break;
				case "c":
					
					break;
				case "s":
					
					break;

			}
			return true;


		}

		private void button1_Click(object sender, System.EventArgs e)
		{		
			this.Close();

		}

		string blk1;
		string blk2;
		string blk3;
		string blk4;

		int j = 0;

		private void knotextBox_TextChanged(object sender, System.EventArgs e)
		{
			
								 
		}

		private void knotextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			
		}


		


	}
}
