using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;



namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		ConfigurationForm cf ;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ComboBox Gunler;
		private System.Windows.Forms.DataGrid CariDataGrid;
			Config config = new Config();
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.TextBox CariNotextBox;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.Button cikis;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		 SqlCeConnection Ceconn;

	

		public Form1()
		{
			cf = new ConfigurationForm();	
			
			if(!config.IsConfigured)
			{
				this.Enabled=false;
				cf.ShowDialog();	
				this.Enabled=true;
			
			}
			config.SetProertyes();
			
			bool aktarma = true;

			
			if(!File.Exists("ankara.sdf"))
			{
				DB  d = new DB(config);
				aktarma= false;
			}


					
			Ceconn=config.CeConn;		
			Ceconn.Open();	

            
			if(!aktarma)
			{
                this.Enabled=false;				
				AktarmalarForm af = new AktarmalarForm(config);
				af.ShowDialog();
				this.Enabled=true;
			}

			

			


			
			
			

			
			
			/*
			cf = new ConfigurationForm();				


			if(!config.IsDbExist)
			{
				this.Enabled=false;

				
				this.Enabled=true;
			}
                      					
         

			
			this.Enabled=false;		
			if(!config.IsConfigured)
			{
				
				cf.ShowDialog();
				
			}
			else
			{
				config.SetProertyes();
			}

			this.Enabled=true;
*/
				
			InitializeComponent();			

		}
	
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}
		#region Windows Form Designer generated code
	
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.Gunler = new System.Windows.Forms.ComboBox();
			this.CariDataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CariNotextBox = new System.Windows.Forms.TextBox();
			this.statusBar1 = new System.Windows.Forms.StatusBar();
			this.cikis = new System.Windows.Forms.Button();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem4);
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			this.mainMenu1.MenuItems.Add(this.menuItem14);
			// 
			// menuItem4
			// 
			this.menuItem4.Enabled = false;
			this.menuItem4.MenuItems.Add(this.menuItem5);
			this.menuItem4.MenuItems.Add(this.menuItem6);
			this.menuItem4.MenuItems.Add(this.menuItem7);
			this.menuItem4.MenuItems.Add(this.menuItem13);
			this.menuItem4.Text = "Seçili Cari";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Text = "Müþ Detay";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.MenuItems.Add(this.menuItem10);
			this.menuItem6.MenuItems.Add(this.menuItem12);
			this.menuItem6.Text = "Sipariþler";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Text = "Sipariþ Al";
			this.menuItem10.Click += new System.EventHandler(this.menuItem10_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Text = "Sipariþ Raporu";
			this.menuItem12.Click += new System.EventHandler(this.menuItem12_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.MenuItems.Add(this.menuItem18);
			this.menuItem7.MenuItems.Add(this.menuItem19);
			this.menuItem7.Text = "Tahsilat";
			// 
			// menuItem18
			// 
			this.menuItem18.Text = "Tahsilat Kaydý";
			this.menuItem18.Click += new System.EventHandler(this.menuItem18_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Text = "Tahsilat Raporu";
			this.menuItem19.Click += new System.EventHandler(this.menuItem19_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.MenuItems.Add(this.menuItem20);
			this.menuItem13.MenuItems.Add(this.menuItem21);
			this.menuItem13.Text = "Ziyaret";
			// 
			// menuItem20
			// 
			this.menuItem20.Text = "Ziyaret Kaydý";
			this.menuItem20.Click += new System.EventHandler(this.menuItem20_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Text = "Ziyaret Raporu";
			this.menuItem21.Click += new System.EventHandler(this.menuItem21_Click);
			// 
			// menuItem1
			// 
			this.menuItem1.MenuItems.Add(this.menuItem2);
			this.menuItem1.MenuItems.Add(this.menuItem3);
			this.menuItem1.Text = "Program";
			// 
			// menuItem2
			// 
			this.menuItem2.MenuItems.Add(this.menuItem15);
			this.menuItem2.MenuItems.Add(this.menuItem16);
			this.menuItem2.MenuItems.Add(this.menuItem17);
			this.menuItem2.Text = "Ayarlar";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Text = "Program";
			this.menuItem15.Click += new System.EventHandler(this.menuItem15_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Text = "Ödeme";
			// 
			// menuItem17
			// 
			this.menuItem17.Text = "Sipariþ";
			// 
			// menuItem3
			// 
			this.menuItem3.Text = "Veri Ýletiþimi";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.MenuItems.Add(this.menuItem22);
			this.menuItem14.MenuItems.Add(this.menuItem11);
			this.menuItem14.MenuItems.Add(this.menuItem23);
			this.menuItem14.Text = "Raporlar";
			this.menuItem14.Click += new System.EventHandler(this.menuItem14_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Text = "Sipariþ";
			this.menuItem22.Click += new System.EventHandler(this.menuItem22_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Text = "Ziyaret";
			this.menuItem11.Click += new System.EventHandler(this.menuItem11_Click_1);
			// 
			// menuItem23
			// 
			this.menuItem23.Text = "Tahsilat";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// Gunler
			// 
			this.Gunler.Items.Add("Pazartesi");
			this.Gunler.Items.Add("Salý");
			this.Gunler.Items.Add("Çarþamba");
			this.Gunler.Items.Add("Perþembe");
			this.Gunler.Items.Add("Cuma");
			this.Gunler.Items.Add("Cumartesi");
			this.Gunler.Items.Add("Pazar");
			this.Gunler.Items.Add("Tüm Müþteriler");
			this.Gunler.Location = new System.Drawing.Point(2, 2);
			this.Gunler.Size = new System.Drawing.Size(100, 20);
			this.Gunler.SelectedIndexChanged += new System.EventHandler(this.Gunler_SelectedIndexChanged);
			// 
			// CariDataGrid
			// 
			this.CariDataGrid.ForeColor = System.Drawing.Color.Black;
			this.CariDataGrid.Location = new System.Drawing.Point(0, 24);
			this.CariDataGrid.Size = new System.Drawing.Size(240, 216);
			this.CariDataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.CariDataGrid.Text = "dataGrid1";
			this.CariDataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CariDataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.MappingName = "C";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "Borç Bakiye";
			this.dataGridTextBoxColumn1.MappingName = "borc_bakiye";
			this.dataGridTextBoxColumn1.NullText = "0";
			this.dataGridTextBoxColumn1.Width = 60;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Cari Adý";
			this.dataGridTextBoxColumn2.MappingName = "CR_CARI_ADI1";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			this.dataGridTextBoxColumn2.Width = 120;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Sýra";
			this.dataGridTextBoxColumn3.MappingName = "DAY";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			this.dataGridTextBoxColumn3.Width = 30;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.MappingName = "CR_CARI_NO";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			this.dataGridTextBoxColumn4.Width = 0;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.HeaderText = "Zt";
			this.dataGridTextBoxColumn5.MappingName = "Ziyaret_turu";
			this.dataGridTextBoxColumn5.NullText = "-";
			// 
			// CariNotextBox
			// 
			this.CariNotextBox.Location = new System.Drawing.Point(216, 248);
			this.CariNotextBox.Text = "";
			this.CariNotextBox.Visible = false;
			this.CariNotextBox.TextChanged += new System.EventHandler(this.CariNotextBox_TextChanged);
			// 
			// statusBar1
			// 
			this.statusBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.statusBar1.Location = new System.Drawing.Point(0, 248);
			this.statusBar1.Size = new System.Drawing.Size(240, 22);
			this.statusBar1.TextChanged += new System.EventHandler(this.statusBar1_TextChanged);
			// 
			// cikis
			// 
			this.cikis.Location = new System.Drawing.Point(166, 2);
			this.cikis.Text = "Çýkýþ";
			this.cikis.Click += new System.EventHandler(this.cikis_Click);
			// 
			// Form1
			// 
			this.Controls.Add(this.cikis);
			this.Controls.Add(this.statusBar1);
			this.Controls.Add(this.CariNotextBox);
			this.Controls.Add(this.CariDataGrid);
			this.Controls.Add(this.Gunler);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Text = "Enterprice Mobile";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.Form1_Closed);

		}
		#endregion

		

		static void Main() 
		{
			Application.Run(new Form1());
		}

	//dkaradeniz@superopnline.com  ulker@dogukaradeniz.com.tr

	

		private void Form1_Load(object sender, System.EventArgs e)
		{	

			if(!config.kilometre)
			{
				
				KilometreGiris kg = new KilometreGiris(this.config);
				kg.Show();				
				
			}

			
			SelectToDay();

		}




		void ChectConfig()
		{
			if(!config.IsConfigured)
			{
				
				cf.ShowDialog();
				
			}
			else
			{
				config.SetProertyes();
			}

		}

		void SelectToDay()
		{
			switch(DateTime.Now.DayOfWeek)
			{
				case DayOfWeek.Monday :
					Gunler.SelectedIndex=0;
					break;
				case DayOfWeek.Tuesday :
					Gunler.SelectedIndex=1;
					break;
				case DayOfWeek.Wednesday :
					Gunler.SelectedIndex=2;
					break;
				case DayOfWeek.Thursday :
					Gunler.SelectedIndex=3;
					break;
				case DayOfWeek.Friday :
					Gunler.SelectedIndex=4;
					break;
				case DayOfWeek.Saturday :
					Gunler.SelectedIndex=5;
					break;
				case DayOfWeek.Sunday :
					Gunler.SelectedIndex=6;
					break;
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			cf.Show();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			AktarmalarForm af = new AktarmalarForm(config);
			af.Show();
		}

		private void Gunler_SelectedIndexChanged(object sender, System.EventArgs e)
		{    
            BindGrid();
			
			
		}


		void BindGrid()
		{
			CariDataGrid.DataSource=Cariler(GetField(Gunler.SelectedIndex),config.PlasiyerKodu).Tables[0];
			


		}

		

		string GetField(int index)
		{
			string ret = "";
			switch(index)
			{
				case 0:
					ret = "rg_pt";
					break;
				case 1:
					ret = "rg_sl";
					break;
				case 2:
					ret = "rg_cr";
					break;
				case 3:
					ret = "rg_pr";
					break;
				case 4:
					ret = "rg_cm";
					break;
				case 5:
					ret = "rg_ct";
					break;
				case 6:
					ret = "rg_pz";
					break;
				case 7:
					ret = "tumu";
					break;
			}
			return ret;
		}

		DataSet Cariler(string Dayfield, string PlasiyerKodu)
		{
		
			string sql = "";
			if(Dayfield != "tumu")
				sql = " SELECT    borc_bakiye ,CR_CARI_ADI1, "+Dayfield+" as DAY, CR_CARI_NO , Ziyaret_turu"+
					" FROM         CARI LEFT OUTER JOIN "+
					"    Ziyaret ON CARI.CR_CARI_NO = Ziyaret.Cari_No "+
					" where "+Dayfield+" > 0 order by "+Dayfield+"";
			else
				sql = " SELECT    borc_bakiye ,CR_CARI_ADI1, rg_pz as DAY, CR_CARI_NO , Ziyaret_turu"+
					" FROM         CARI LEFT OUTER JOIN "+
					"    Ziyaret ON CARI.CR_CARI_NO = Ziyaret.Cari_No "+
					"  order by CR_CARI_ADI1";	


			DataSet ds = new DataSet();	
			
			SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			ad.Fill(ds,"C");		
			return ds;         	

		}

		private void CariDataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column = CariDataGrid.HitTest(e.X,e.Y).Column;
			int Row = CariDataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{
				//MessageBox.Show(CariDataGrid[Row,column].ToString());
				if(column==1)			
					CariNotextBox.Text=CariDataGrid[Row,4].ToString();
				statusBar1.Text=CariDataGrid[Row,1].ToString();
			}
		
		}

		private void CariNotextBox_TextChanged(object sender, System.EventArgs e)
		{
				menuItem4.Enabled=true;
		
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			
			CariBilgiForm cf = new CariBilgiForm(CariNotextBox.Text,this.config);
			cf.Show();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			
			AktarmalarForm af = new AktarmalarForm(config);
			af.Show();

		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem7_Click(object sender, System.EventArgs e)
		{	
		
		}

		private void menuItem10_Click(object sender, System.EventArgs e)
		{
			
			SiparisForm sf = new SiparisForm(CariNotextBox.Text,config);
			sf.Show();			
		}

		private void Form1_Closed(object sender, System.EventArgs e)
		{

            		
		}
		
		private void menuItem18_Click(object sender, System.EventArgs e)
		{
			
			Cari c = new Cari(CariNotextBox.Text,config);
			TahsilatFormGiris tg = new TahsilatFormGiris(c,config);
			tg.Show();
		}

		private void menuItem20_Click(object sender, System.EventArgs e)
		{
			Cari c = new Cari(CariNotextBox.Text,config);
			ZiyaretForm zf = new ZiyaretForm(c,config);
			zf.Show();
		}

		private void menuItem11_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem12_Click(object sender, System.EventArgs e)
		{
			Cari c = new Cari(CariNotextBox.Text,config	);
			SiparisRaporlar sr = new SiparisRaporlar(config,c);
			sr.Show();
		}

		private void menuItem22_Click(object sender, System.EventArgs e)
		{
			
			SiparisBaslikRaporForm sbf = new SiparisBaslikRaporForm(config);
			sbf.Show();
		
		}

		private void menuItem14_Click(object sender, System.EventArgs e)
		{
		
		}

		private void menuItem11_Click_1(object sender, System.EventArgs e)
		{
			ZiyaretRaporForm zrf = new ZiyaretRaporForm(config);
			zrf.Show();
		}

		private void menuItem21_Click(object sender, System.EventArgs e)
		{
			Cari c = new Cari(CariNotextBox.Text,this.config);

			ZiyaretRaporForm zrf = new ZiyaretRaporForm(c,config);
			zrf.Show();
		
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			TahsilatRapor tr = new TahsilatRapor(config);
			tr.Show();	
		}

		private void menuItem24_Click(object sender, System.EventArgs e)
		{
			StokBilgiForm sbf = new StokBilgiForm(config);
			sbf.Show();
		
		}

		private void menuItem9_Click(object sender, System.EventArgs e)
		{
			
		}

		private void statusBar1_TextChanged(object sender, System.EventArgs e)
		{
			
		}

		private void cikis_Click(object sender, System.EventArgs e)
		{
			Ceconn.Close();			
			this.Close();

		}

		private void menuItem19_Click(object sender, System.EventArgs e)
		{
			TahsilatRapor tr = new TahsilatRapor(config);
			tr.Show();		
		}

		private void menuItem15_Click(object sender, System.EventArgs e)
		{
			//cf = new ConfigurationForm();
			//cf.Show();
			SifreSor sf  = new SifreSor(config);
			sf.Show();
		}
	}
}
