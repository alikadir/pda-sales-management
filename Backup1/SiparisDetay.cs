using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlServerCe;
using System.Threading;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for SiparisDetay.
	/// </summary>
	public class SiparisDetay : System.Windows.Forms.Form
	{
		Config cf;
	
		private System.Windows.Forms.ComboBox GropKodlaricomboBox;
		private System.Windows.Forms.ComboBox SicilAdlaricomboBox;
		private System.Windows.Forms.ComboBox FiyatcomboBox;
		private System.Windows.Forms.TextBox FiyatTextBox;
		private System.Windows.Forms.TextBox IskontotextBox1;
		private System.Windows.Forms.Label label1;
		SqlCeConnection CeConn;
		// combo boxlarýn g,her ikisi de dolduðunda iki deðer de true olur
		bool a = false;
		private System.Windows.Forms.TextBox indim_tutar;
		private System.Windows.Forms.Label label7;
		bool b = false;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.TextBox IskontotextBox2;
		private System.Windows.Forms.TextBox IskontotextBox3;
		private System.Windows.Forms.TextBox IskontotextBox4;
		private System.Windows.Forms.TextBox IskontotextBox5;
		float tutar;
		private System.Windows.Forms.Button Elke;
		private System.Windows.Forms.TextBox MiktartextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox BirimComboBox;
		private System.Windows.Forms.DataGrid SiparisdataGrid;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		int SiparisNo;
		Cari cari;
		string IskontoField;
		int MaxVadeValue;
		private System.Windows.Forms.Button kapa;
		private System.Windows.Forms.TextBox Kdv_textBox;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.TextBox secili_siparis;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		SqlCeCommand cmd = new SqlCeCommand();
		private System.Windows.Forms.Button Duzenle;
		SiparisIslemleri sp;
		float  kilometre;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn7;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn8;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn9;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn10;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn11;
		string OdemeSekli;
			
	
		public SiparisDetay(Config cf, int SiparisNo, Cari c, string  OdemeSekli, float kilometre)
		{

			CeConn = cf.CeConn;
			this.cf=cf;
			this.SiparisNo = SiparisNo;
			this.cari = c;
			IskontoField = cf.GetVadeField(OdemeSekli, out MaxVadeValue);
			this.kilometre=kilometre;
			this.OdemeSekli=OdemeSekli.ToLower();
			cmd.Connection =CeConn;

			sp = new SiparisIslemleri(SiparisNo,cf,c);	
            		
			InitializeComponent();
		
			//BindSiparisGrid();
		}

	
		
		protected override void Dispose( bool disposing )
		{
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		
		private void InitializeComponent()
		{
			this.GropKodlaricomboBox = new System.Windows.Forms.ComboBox();
			this.SicilAdlaricomboBox = new System.Windows.Forms.ComboBox();
			this.FiyatcomboBox = new System.Windows.Forms.ComboBox();
			this.FiyatTextBox = new System.Windows.Forms.TextBox();
			this.IskontotextBox1 = new System.Windows.Forms.TextBox();
			this.IskontotextBox2 = new System.Windows.Forms.TextBox();
			this.IskontotextBox3 = new System.Windows.Forms.TextBox();
			this.IskontotextBox4 = new System.Windows.Forms.TextBox();
			this.IskontotextBox5 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.indim_tutar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.Elke = new System.Windows.Forms.Button();
			this.MiktartextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.BirimComboBox = new System.Windows.Forms.ComboBox();
			this.SiparisdataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Kdv_textBox = new System.Windows.Forms.TextBox();
			this.kapa = new System.Windows.Forms.Button();
			this.secili_siparis = new System.Windows.Forms.TextBox();
			this.Duzenle = new System.Windows.Forms.Button();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn7 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn8 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn9 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn10 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn11 = new System.Windows.Forms.DataGridTextBoxColumn();
			// 
			// GropKodlaricomboBox
			// 
			this.GropKodlaricomboBox.DisplayMember = "GRUP_KODU";
			this.GropKodlaricomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.GropKodlaricomboBox.Location = new System.Drawing.Point(6, 4);
			this.GropKodlaricomboBox.Size = new System.Drawing.Size(52, 20);
			this.GropKodlaricomboBox.ValueMember = "GRUP_KODU";
			this.GropKodlaricomboBox.SelectedIndexChanged += new System.EventHandler(this.GropKodlaricomboBox_SelectedIndexChanged);
			// 
			// SicilAdlaricomboBox
			// 
			this.SicilAdlaricomboBox.DisplayMember = "SICIL_ADI";
			this.SicilAdlaricomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.SicilAdlaricomboBox.Location = new System.Drawing.Point(5, 28);
			this.SicilAdlaricomboBox.Size = new System.Drawing.Size(230, 20);
			this.SicilAdlaricomboBox.ValueMember = "SICIL_KODU";
			this.SicilAdlaricomboBox.SelectedIndexChanged += new System.EventHandler(this.SicilAdlaricomboBox_SelectedIndexChanged);
			// 
			// FiyatcomboBox
			// 
			this.FiyatcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.FiyatcomboBox.Items.Add("SF1");
			this.FiyatcomboBox.Items.Add("SF2");
			this.FiyatcomboBox.Items.Add("SF3");
			this.FiyatcomboBox.Items.Add("SF4");
			this.FiyatcomboBox.Items.Add("SF5");
			this.FiyatcomboBox.Location = new System.Drawing.Point(65, 4);
			this.FiyatcomboBox.Size = new System.Drawing.Size(52, 20);
			this.FiyatcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiyatcomboBox_SelectedIndexChanged);
			// 
			// FiyatTextBox
			// 
			this.FiyatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.FiyatTextBox.Location = new System.Drawing.Point(120, 4);
			this.FiyatTextBox.ReadOnly = true;
			this.FiyatTextBox.Size = new System.Drawing.Size(72, 18);
			this.FiyatTextBox.Text = "";
			this.FiyatTextBox.TextChanged += new System.EventHandler(this.FiyatTextBox_TextChanged);
			// 
			// IskontotextBox1
			// 
			this.IskontotextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.IskontotextBox1.Location = new System.Drawing.Point(60, 52);
			this.IskontotextBox1.Size = new System.Drawing.Size(32, 18);
			this.IskontotextBox1.Text = "";
			this.IskontotextBox1.TextChanged += new System.EventHandler(this.IskontotextBox1_TextChanged);
			// 
			// IskontotextBox2
			// 
			this.IskontotextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.IskontotextBox2.Location = new System.Drawing.Point(95, 52);
			this.IskontotextBox2.Size = new System.Drawing.Size(32, 18);
			this.IskontotextBox2.Text = "";
			this.IskontotextBox2.TextChanged += new System.EventHandler(this.IskontotextBox2_TextChanged);
			// 
			// IskontotextBox3
			// 
			this.IskontotextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.IskontotextBox3.Location = new System.Drawing.Point(130, 52);
			this.IskontotextBox3.Size = new System.Drawing.Size(32, 18);
			this.IskontotextBox3.Text = "";
			this.IskontotextBox3.TextChanged += new System.EventHandler(this.IskontotextBox3_TextChanged);
			// 
			// IskontotextBox4
			// 
			this.IskontotextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.IskontotextBox4.Location = new System.Drawing.Point(165, 52);
			this.IskontotextBox4.Size = new System.Drawing.Size(32, 18);
			this.IskontotextBox4.Text = "";
			this.IskontotextBox4.TextChanged += new System.EventHandler(this.IskontotextBox4_TextChanged);
			// 
			// IskontotextBox5
			// 
			this.IskontotextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.IskontotextBox5.Location = new System.Drawing.Point(200, 52);
			this.IskontotextBox5.Size = new System.Drawing.Size(32, 18);
			this.IskontotextBox5.Text = "";
			this.IskontotextBox5.TextChanged += new System.EventHandler(this.IskontotextBox5_TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(10, 52);
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.Text = "Ýskonto";
			// 
			// indim_tutar
			// 
			this.indim_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.indim_tutar.Location = new System.Drawing.Point(60, 76);
			this.indim_tutar.ReadOnly = true;
			this.indim_tutar.Size = new System.Drawing.Size(80, 18);
			this.indim_tutar.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(10, 78);
			this.label7.Size = new System.Drawing.Size(45, 16);
			this.label7.Text = "Ý. tutar";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			this.mainMenu1.MenuItems.Add(this.menuItem5);
			// 
			// menuItem1
			// 
			this.menuItem1.Enabled = false;
			this.menuItem1.MenuItems.Add(this.menuItem2);
			this.menuItem1.MenuItems.Add(this.menuItem3);
			this.menuItem1.MenuItems.Add(this.menuItem4);
			this.menuItem1.Text = "SEÇÝLÝ SÝPARÝÞ";
			this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "SATIR SÝL";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Text = "SATIR DÜZENLE";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Text = "TÜMÜNÜ SÝL";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Text = "Hesapla";
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// Elke
			// 
			this.Elke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Elke.Location = new System.Drawing.Point(196, 4);
			this.Elke.Size = new System.Drawing.Size(38, 20);
			this.Elke.Text = "Ekle";
			this.Elke.Click += new System.EventHandler(this.Elke_Click);
			// 
			// MiktartextBox
			// 
			this.MiktartextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.MiktartextBox.Location = new System.Drawing.Point(60, 100);
			this.MiktartextBox.Size = new System.Drawing.Size(60, 18);
			this.MiktartextBox.Text = "";
			this.MiktartextBox.TextChanged += new System.EventHandler(this.MiktartextBox_TextChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(10, 102);
			this.label8.Size = new System.Drawing.Size(45, 16);
			this.label8.Text = "Miktar";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(130, 104);
			this.label9.Size = new System.Drawing.Size(45, 14);
			this.label9.Text = "Birim";
			// 
			// BirimComboBox
			// 
			this.BirimComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.BirimComboBox.Location = new System.Drawing.Point(170, 100);
			this.BirimComboBox.Size = new System.Drawing.Size(64, 20);
			this.BirimComboBox.SelectedIndexChanged += new System.EventHandler(this.BirimComboBox_SelectedIndexChanged);
			// 
			// SiparisdataGrid
			// 
			this.SiparisdataGrid.Location = new System.Drawing.Point(6, 152);
			this.SiparisdataGrid.Size = new System.Drawing.Size(230, 108);
			this.SiparisdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.SiparisdataGrid.Text = "dataGrid1";
			this.SiparisdataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SiparisdataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn11);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn10);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn7);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn8);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn9);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.MappingName = "siparisler";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "Sicil Kodu";
			this.dataGridTextBoxColumn1.MappingName = "Sicil_Kodu";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Sicil Adý";
			this.dataGridTextBoxColumn2.MappingName = "Sicil_Adi";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			this.dataGridTextBoxColumn2.Width = 100;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Tutar";
			this.dataGridTextBoxColumn3.MappingName = "Tutar";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.HeaderText = "sd no";
			this.dataGridTextBoxColumn4.MappingName = "SiparisDetay_No";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			this.dataGridTextBoxColumn4.Width = 0;
			// 
			// Kdv_textBox
			// 
			this.Kdv_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Kdv_textBox.Location = new System.Drawing.Point(150, 76);
			this.Kdv_textBox.Size = new System.Drawing.Size(85, 18);
			this.Kdv_textBox.Text = "";
			this.Kdv_textBox.TextChanged += new System.EventHandler(this.Kdv_textBox_TextChanged);
			// 
			// kapa
			// 
			this.kapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.kapa.Location = new System.Drawing.Point(190, 126);
			this.kapa.Size = new System.Drawing.Size(46, 20);
			this.kapa.Text = "Kaydet";
			this.kapa.Click += new System.EventHandler(this.kapa_Click);
			// 
			// secili_siparis
			// 
			this.secili_siparis.Location = new System.Drawing.Point(130, 232);
			this.secili_siparis.Text = "";
			this.secili_siparis.Visible = false;
			// 
			// Duzenle
			// 
			this.Duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Duzenle.Location = new System.Drawing.Point(196, 4);
			this.Duzenle.Size = new System.Drawing.Size(38, 20);
			this.Duzenle.Text = "Ekle";
			this.Duzenle.Visible = false;
			this.Duzenle.Click += new System.EventHandler(this.Duzenle_Click);
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.HeaderText = "IND1";
			this.dataGridTextBoxColumn5.MappingName = "iskonto1";
			this.dataGridTextBoxColumn5.NullText = "(null)";
			this.dataGridTextBoxColumn5.Width = 30;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.HeaderText = "IND2";
			this.dataGridTextBoxColumn6.MappingName = "iskonto2";
			this.dataGridTextBoxColumn6.NullText = "(null)";
			this.dataGridTextBoxColumn6.Width = 30;
			// 
			// dataGridTextBoxColumn7
			// 
			this.dataGridTextBoxColumn7.HeaderText = "IND3";
			this.dataGridTextBoxColumn7.MappingName = "iskonto3";
			this.dataGridTextBoxColumn7.NullText = "(null)";
			this.dataGridTextBoxColumn7.Width = 30;
			// 
			// dataGridTextBoxColumn8
			// 
			this.dataGridTextBoxColumn8.HeaderText = "IND4";
			this.dataGridTextBoxColumn8.MappingName = "iskonto4";
			this.dataGridTextBoxColumn8.NullText = "(null)";
			this.dataGridTextBoxColumn8.Width = 30;
			// 
			// dataGridTextBoxColumn9
			// 
			this.dataGridTextBoxColumn9.HeaderText = "IND5";
			this.dataGridTextBoxColumn9.MappingName = "iskonto5";
			this.dataGridTextBoxColumn9.NullText = "(null)";
			this.dataGridTextBoxColumn9.Width = 30;
			// 
			// dataGridTextBoxColumn10
			// 
			this.dataGridTextBoxColumn10.HeaderText = "BF";
			this.dataGridTextBoxColumn10.MappingName = "Birim Fiyatý";
			this.dataGridTextBoxColumn10.NullText = "(null)";
			// 
			// dataGridTextBoxColumn11
			// 
			this.dataGridTextBoxColumn11.HeaderText = "Miktar";
			this.dataGridTextBoxColumn11.MappingName = "Miktar";
			this.dataGridTextBoxColumn11.NullText = "(null)";
			// 
			// SiparisDetay
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(239, 270);
			this.ControlBox = false;
			this.Controls.Add(this.secili_siparis);
			this.Controls.Add(this.kapa);
			this.Controls.Add(this.Kdv_textBox);
			this.Controls.Add(this.SiparisdataGrid);
			this.Controls.Add(this.BirimComboBox);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.MiktartextBox);
			this.Controls.Add(this.Elke);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.indim_tutar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IskontotextBox5);
			this.Controls.Add(this.IskontotextBox4);
			this.Controls.Add(this.IskontotextBox3);
			this.Controls.Add(this.IskontotextBox2);
			this.Controls.Add(this.IskontotextBox1);
			this.Controls.Add(this.FiyatTextBox);
			this.Controls.Add(this.FiyatcomboBox);
			this.Controls.Add(this.SicilAdlaricomboBox);
			this.Controls.Add(this.GropKodlaricomboBox);
			this.Controls.Add(this.Duzenle);
			this.MaximizeBox = false;
			this.Menu = this.mainMenu1;
			this.MinimizeBox = false;
			this.Text = "SiparisDetay";
			this.Load += new System.EventHandler(this.SiparisDetay_Load);

		}
		#endregion

		private void SiparisDetay_Load(object sender, System.EventArgs e)
		{
			FiyatcomboBox.SelectedIndex= 0;
			GropKodlaricomboBox.DataSource=GrupKodlari().Tables[0];	
			a = true;    
   	
			
		}

	

		DataSet GrupKodlari()
		{
			
			string sql = "select distinct(GRUP_KODU) from stok";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds);
				
			return ds;			
		}



		DataSet SicilAdlari(string GrupKodu)
		{
			
				
			string sql = "select SICIL_KODU, SICIL_ADI from stok  where GRUP_KODU = '"+GrupKodu+"' order by SICIL_ADI";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds);
				
			return ds;
		}


		DataSet SicilAdi(string SICIL_KODU)
		{				
			string sql = "select SICIL_KODU, SICIL_ADI from stok  where SICIL_KODU = '"+SICIL_KODU+"' order by SICIL_ADI";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds);				
			return ds;
		}

		private void GropKodlaricomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(a)
			{
				BindStokSicilDropdown();
				GetPrice();
						

			}	
		}

		void BindStokSicilDropdown()
		{
			b = false;
			SicilAdlaricomboBox.DataSource=SicilAdlari(GropKodlaricomboBox.SelectedValue.ToString()).Tables[0];			
			BirimComboBox.Items.Clear();
			GetBirim();
			BirimComboBox.SelectedIndex=0;
			b = true;
		}

		private void SicilAdlaricomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(b)
				GetBirim();	
			GetPrice();
		}

		private void FiyatcomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			GetPrice();			

		}

		float SetIskonto1( string Field)
		{			
			
			string sql = "select "+Field+" from stok where SICIL_KODU = '"+SicilAdlaricomboBox.SelectedValue.ToString()+"'";
		
			cmd.CommandText  = sql;
			float i = Convert.ToSingle(cmd.ExecuteScalar());
			
			return i;

		}

		bool isFilled()
		{
			return SicilAdlaricomboBox.SelectedValue != null && FiyatcomboBox.SelectedItem != null && a && b;
		}


		float MaxIskono1;
		float MaxIskono2;
		float MaxIskono3;
		
		void GetPrice()
		{
			if(isFilled())
			{
				float birimF =GetPrice(SicilAdlaricomboBox.SelectedValue.ToString(),FiyatcomboBox.SelectedItem.ToString());		
				if(BirimComboBox.SelectedIndex == 0)
					birimF = birimF * Carpan;

				FiyatTextBox.Text= birimF.ToString();				
				MaxIskono1	=SetIskonto1(IskontoField);
				MaxIskono2	=SetIskonto1("IND4");
				MaxIskono3	=SetIskonto1("IND5");				

				IskontotextBox1.Text=MaxIskono1.ToString();
				IskontotextBox2.Text=MaxIskono2.ToString();
				IskontotextBox3.Text=MaxIskono3.ToString();
			}

		}

        
		float Carpan;
		int index;
		void GetBirim()
		{
			BirimComboBox.Items.Clear();         
			string sql = "select BIRIM1A, BIRIM1C, BIRIM from stok  where SICIL_KODU = '"+SicilAdlaricomboBox.SelectedValue+"'";			
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"birim");
			BirimComboBox.Items.Add(ds.Tables[0].Rows[0]["BIRIM1A"].ToString());
			Carpan = Convert.ToSingle(ds.Tables[0].Rows[0]["BIRIM1C"].ToString());
			BirimComboBox.Items.Add(ds.Tables[0].Rows[0]["BIRIM"].ToString());	
			BirimComboBox.SelectedIndex=0;
			index = BirimComboBox.SelectedIndex;
            						
		}



		float GetPrice(string urunKodu, string field)
		{
		
			string sql = "select "+field+" from stok where SICIL_KODU = '"+urunKodu+"'";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			float i = Convert.ToSingle(cmd.ExecuteScalar());		
			return i;
		}


	
		bool ChectIskonto()
		{
			bool a = true;
			
			if( IskontotextBox1.Text.Trim() != string.Empty &&  Convert.ToDouble(IskontotextBox1.Text) > MaxIskono1)
			{
				MessageBox.Show("Iskonto 1 alanýna girilen deðer "+MaxIskono1.ToString()+" den büyük olamaz");
				a= false;
			}
			if(IskontotextBox2.Text.Trim() != string.Empty && Convert.ToDouble(IskontotextBox2.Text) > MaxIskono2)
			{
				MessageBox.Show("Iskonto 2 alanýna girilen deðer "+MaxIskono2.ToString()+" den büyük olamaz");
				a= false;
			}
			if(IskontotextBox3.Text.Trim() != string.Empty &&  Convert.ToDouble(IskontotextBox3.Text) > MaxIskono3)
			{
				MessageBox.Show("Iskonto 3 alanýna girilen deðer "+MaxIskono3.ToString()+" den büyük olamaz");
				a= false;
			}
			return a;
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			

		}
		


		float kdv ;
		void Hesapla()
		{
			
			if(temizle && FiyatTextBox.Text.Trim() != string.Empty)		
			{
				if(!ChectIskonto())
				{
					return;
				}
		            
						
				ArrayList al = new ArrayList();
				if(IskontotextBox1.Text.Trim() != string.Empty)
					al.Add(Convert.ToSingle(IskontotextBox1.Text));
				if(IskontotextBox2.Text.Trim() != string.Empty)
					al.Add(Convert.ToSingle(IskontotextBox2.Text));
				if(IskontotextBox3.Text.Trim() != string.Empty)
					al.Add(Convert.ToSingle(IskontotextBox3.Text));
				if(IskontotextBox4.Text.Trim() != string.Empty)
					al.Add(Convert.ToSingle(IskontotextBox4.Text));
				if(IskontotextBox5.Text.Trim() != string.Empty)
					al.Add(Convert.ToSingle(IskontotextBox5.Text));

				float sonuc = 0;
				float tutar = Convert.ToSingle(FiyatTextBox.Text);
				if(al.Count > 0)
				{
					for(int i = 0; i < al.Count;i++)
					{
						sonuc = perc(tutar,((float)al[i]));
						tutar = sonuc;
					}
                
				}
				else
					sonuc = tutar;
				indim_tutar.Text= sonuc.ToString();
				kdv = GetKdv(SicilAdlaricomboBox.SelectedValue.ToString());
				Kdv_textBox.Text =(sonuc + (sonuc*kdv) /100).ToString();		

			}


		}

		float GetKdv(string Sicil_Kodu)
		{
			string sql = "select SATIS_KDVY from stok Where SICIL_KODU ='"+Sicil_Kodu+"'";
			cmd.CommandText= sql;
			Object o = cmd.ExecuteScalar();
			float kdv ;
			if(o != System.DBNull.Value)
				kdv = Convert.ToSingle(o);
			else
				kdv= 0;
			return kdv;
		}

		float perc(float fiyat , float yuzde)
		{
            float  k = (fiyat * yuzde) / 100;
			return fiyat - k;
		}

		private void Elke_Click(object sender, System.EventArgs e)
		{
			
			if(!ChectIskonto())
			{
				return;
			}

			if(MiktartextBox.Text.Trim() == string.Empty || MiktartextBox.Text =="")
			{
				MessageBox.Show("Miktar alaný boþ býrakýlamaz");
				return;
			}
			if(FiyatTextBox.Text == string.Empty)
			{
				MessageBox.Show("Lütfen bir ürün seçiniz");
				return;
			}

			float miktar = GetMiktar(GropKodlaricomboBox.SelectedValue.ToString(),this.SiparisNo);					
			string field =  cf.GetAlisFiyatiField(miktar);

			float Af = GetAlisFiyati(SicilAdlaricomboBox.SelectedValue.ToString(),field);
            if(BirimComboBox.SelectedIndex == 0)
				Af = Af * Carpan;

			

			// ödeme türüne göre alýþ fiyatý hesaplama

			Af = Af +  ((Af * AlisFiyati(this.OdemeSekli,SicilAdlaricomboBox.SelectedValue.ToString()))/100);
			
			if(IskontotextBox4.Text!= "100")
			{
				if(Af > Convert.ToSingle(indim_tutar.Text))
				{
					MessageBox.Show("Bu fiyata satýþ yapýlmaz");
					return;
				}
			}


			if(isFilled())
			{

				IskontotextBox1.Text = IskontotextBox1.Text.Trim() == string.Empty ? "0" :IskontotextBox1.Text;
				IskontotextBox2.Text = IskontotextBox2.Text.Trim() == string.Empty ? "0" :IskontotextBox2.Text;
				IskontotextBox3.Text = IskontotextBox3.Text.Trim() == string.Empty ? "0" :IskontotextBox3.Text;
				IskontotextBox4.Text = IskontotextBox4.Text.Trim() == string.Empty ? "0" :IskontotextBox4.Text;
				IskontotextBox5.Text = IskontotextBox5.Text.Trim() == string.Empty ? "0" :IskontotextBox5.Text;

				float Miktar =  Convert.ToSingle(MiktartextBox.Text);

				float kolimiktar = Miktar;

				if(BirimComboBox.SelectedIndex==1)
					kolimiktar = Miktar / Carpan;
				
				sp.InsertSiparisDetay(GropKodlaricomboBox.SelectedValue.ToString(),
					SiparisNo,
					SicilAdlaricomboBox.SelectedValue.ToString(),
					cf.PlasiyerKodu,
					GetSicilAdi(SicilAdlaricomboBox.SelectedValue.ToString()),
					Convert.ToSingle(MiktartextBox.Text),					
					BirimComboBox.SelectedItem.ToString(),
					Convert.ToSingle(FiyatTextBox.Text),
					Convert.ToSingle(MiktartextBox.Text)*Convert.ToSingle(indim_tutar.Text) ,
					Convert.ToSingle(IskontotextBox1.Text),
					Convert.ToSingle(IskontotextBox2.Text),
					Convert.ToSingle(IskontotextBox3.Text),
					Convert.ToSingle(IskontotextBox4.Text),
					Convert.ToSingle(IskontotextBox5.Text),kolimiktar);
					MessageBox.Show("sipariþ eklendi");
					Temizle();
					BindSiparisGrid();		
			}
			else
			{
				MessageBox.Show("seçim yapýlmamýþ");
			}
		
		}


		float AlisFiyati(string odemesekli, string stokkodu)
		{
			string field = "";
			switch(odemesekli)
			{
				case "c":
					field = "IND1";
					break;
				case "s":
					field = "IND1";
					break;
				case "n":
					field = "IND3";
					break;
				case "k":
					field = "IND2";
					break;
			}

			string sql = "select "+field+" from stok where SICIL_KODU = '"+stokkodu+"'";
            cmd.CommandText = sql;
			float i = Convert.ToSingle(cmd.ExecuteScalar());
			return i;
		}


		void BindSiparisGrid()
		{
			SiparisdataGrid.DataSource = sp.SiparisDetaylari.Tables[0];
			
		}

		private void FiyatTextBox_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(FiyatTextBox.Text))
			Hesapla();
			else
				MessageBox.Show("Girilen deðer hatýalý");

		}
        
		bool CheckFloat(string Text)
		{
			if(Text.Trim() == string.Empty || Text.Trim() == "")
				return true;
			try
			{
				float t = Convert.ToSingle(Text);
				return true;
			}
			catch(FormatException ex)
			{
				return false;
			}
		}


		
		private void BirimComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{			
			if(index != BirimComboBox.SelectedIndex)
			{
				if(FiyatTextBox.Text != string.Empty && FiyatTextBox.Text != "")
				{
					float birimF = Convert.ToSingle(FiyatTextBox.Text);		
					if(BirimComboBox.SelectedIndex == 0)
						birimF = birimF * Carpan;
					else
						birimF = birimF / Carpan;
					FiyatTextBox.Text=birimF.ToString();
					index =  BirimComboBox.SelectedIndex;
					Hesapla();
				}
			}

		}

		float GetMiktar(string Grup_Kodu, int Siparis_no)
		{
			string sql = "select sum(kolimiktar) from siparisDetay where  siparis_no ="+Siparis_no+" And "+
					" Grup_Kodu = '"+Grup_Kodu+"'";
			object o = new SqlCeCommand(sql,CeConn).ExecuteScalar();
					
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			else
				return 0;
		}

		string GetSicilAdi(string Sicil_Kodu)
		{
			string sql = "select sicil_adi from stok where sicil_kodu = '"+Sicil_Kodu+"'";
			cmd.CommandText=sql;
			string s = cmd.ExecuteScalar().ToString();
			return s;
		}

		private void IskontotextBox1_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(IskontotextBox1.Text))
				Hesapla();
			else
			{
				MessageBox.Show("Girilen deðer hatalý");
				IskontotextBox1.Text="";
			}
		}

		private void IskontotextBox2_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(IskontotextBox2.Text))
				Hesapla();
			else
			{
				MessageBox.Show("Girilen deðer hatalý");
				IskontotextBox2.Text="";
			}
		}

		private void IskontotextBox3_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(IskontotextBox3.Text))
				Hesapla();
			else
			{
				MessageBox.Show("Girilen deðer hatalý");
				IskontotextBox3.Text="";
			}
		}

		private void IskontotextBox4_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(IskontotextBox4.Text))
				Hesapla();
			else
			{
				MessageBox.Show("Girilen deðer hatalý");
				IskontotextBox4.Text="";
			}
		}

		private void IskontotextBox5_TextChanged(object sender, System.EventArgs e)
		{
			if(CheckFloat(IskontotextBox5.Text))
				Hesapla();
			else
			{
				MessageBox.Show("Girilen deðer hatalý");
				IskontotextBox5.Text="";
			}
		}


		float GetAlisFiyati(string Sicil_Kodu, string Field)
		{
			
			string sql = "select " +Field +" from stok where SICIL_KODU = '"+Sicil_Kodu+"'";			
			cmd.CommandText=sql;
			float f;
			object o  = cmd.ExecuteScalar();		
			f= Convert.ToSingle(o);
		          
		
			return f;
		}

		bool temizle = true;
		void Temizle()
		{
			temizle = false;
		
			FiyatTextBox.Text="";
			IskontotextBox1.Text= "";
			IskontotextBox2.Text= "";
			IskontotextBox3.Text= "";
			IskontotextBox4.Text= "";
			IskontotextBox5.Text= "";
			MiktartextBox.Text="";
			temizle = true;
		
             
		}

		

		

		private void kapa_Click(object sender, System.EventArgs e)
		{
			if(sp.SiparisDetaylari.Tables[0].Rows.Count == 0)
			{
                MessageBox.Show("Sipariþ kartýna herhangi bir ürün girmediniz. sipariþ kartý silinecek");
				sp.SiparisSil(this.SiparisNo.ToString());
			}
			else
			{
				sp.InsertZiyaret(cari.carino,"Baþarýlý",this.kilometre,cf.PlasiyerKodu);
							
			}
			
			this.Close();
		}

		private void MiktartextBox_TextChanged(object sender, System.EventArgs e)
		{
			if(!CheckFloat(MiktartextBox.Text))
			{
				MessageBox.Show("Girilen deðer hatalý");
				MiktartextBox.Text="";
			}
		}

		private void SiparisdataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column = SiparisdataGrid.HitTest(e.X,e.Y).Column;
			int Row = SiparisdataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{
				if(column == 0)
				{
					secili_siparis.Text= SiparisdataGrid[Row,4].ToString();
					menuItem1.Enabled=true;
				}
				else
					menuItem1.Enabled=false;
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			sp.SiparisDetaySil(secili_siparis.Text);
			secili_siparis.Text= "";
            menuItem1.Enabled=false;			
			BindSiparisGrid();	
		}

	

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
			sp.SiparisSil(SiparisNo.ToString());			
			
			this.Close();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			Enable(false);			
			Duzenle.Visible=true;
			SicilAdlaricomboBox.DataSource=SicilAdi(SicilKodu(secili_siparis.Text)).Tables[0];
			//BirimComboBox.Items.Clear();
			//GetBirim();
			BirimComboBox.SelectedIndex=0;
			//Hesapla();
			MiktartextBox.Text=siparismiktar(secili_siparis.Text).ToString();
			IskontotextBox1.Text=iskontolar(secili_siparis.Text,"iskonto1").ToString();
			IskontotextBox2.Text=iskontolar(secili_siparis.Text,"iskonto2").ToString();
			IskontotextBox3.Text=iskontolar(secili_siparis.Text,"iskonto3").ToString();
			IskontotextBox4.Text=iskontolar(secili_siparis.Text,"iskonto4").ToString();
			IskontotextBox5.Text=iskontolar(secili_siparis.Text,"iskonto5").ToString();
            
			//IskontoField = cf.GetVadeField(OdemeSekli, out MaxVadeValue);
			//GetPrice(secili_siparis.Text, IskontoField);
		}


		string SicilKodu(string siparisNo)
		{				
			string sql = "select sicil_kodu  from siparisDetay  where siparisdetay_no = '"+siparisNo+"'";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
            object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return o.ToString();
			return "";

		}

		float siparismiktar(string siparisNo)
		{				
			string sql = "select Miktar  from siparisDetay  where siparisdetay_no = '"+siparisNo+"'";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);

			return 0;
		}

		float iskontolar(string siparisNo, string field)
		{					
			string sql = "select "+field+"  from siparisDetay  where siparisdetay_no = '"+siparisNo+"'";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			return 0;	
		}

		void Enable(bool enable)
		{
			GropKodlaricomboBox.Enabled=enable;
			SicilAdlaricomboBox.Enabled=enable;
			FiyatcomboBox.Enabled=enable;
			Elke.Visible=enable;
		}

		private void Duzenle_Click(object sender, System.EventArgs e)
		{
            Update(Convert.ToInt16(secili_siparis.Text));
			Enable(true);			
			Duzenle.Visible=false;
		
		}	
	
		
		
		
		void Update(int siparisdetay_no)
		{
			
			if(!ChectIskonto())
			{
				return;
			}

			if(MiktartextBox.Text.Trim() == string.Empty || MiktartextBox.Text =="")
			{
				MessageBox.Show("Miktar alaný boþ býrakýlamaz");
				return;
			}

			float miktar = GetMiktar(GropKodlaricomboBox.SelectedValue.ToString(),this.SiparisNo);					
			string field =  cf.GetAlisFiyatiField(miktar);

			float Af = GetAlisFiyati(SicilAdlaricomboBox.SelectedValue.ToString(),field);
			if(BirimComboBox.SelectedIndex == 0)
				Af = Af * Carpan;

			
			if(Af > Convert.ToSingle(indim_tutar.Text))
			{
				MessageBox.Show("Bu fiyata satýþ yapýlmaz");
				return;
			}			

			if(isFilled())
			{

				IskontotextBox1.Text = IskontotextBox1.Text.Trim() == string.Empty ? "0" :IskontotextBox1.Text;
				IskontotextBox2.Text = IskontotextBox2.Text.Trim() == string.Empty ? "0" :IskontotextBox2.Text;
				IskontotextBox3.Text = IskontotextBox3.Text.Trim() == string.Empty ? "0" :IskontotextBox3.Text;
				IskontotextBox4.Text = IskontotextBox4.Text.Trim() == string.Empty ? "0" :IskontotextBox4.Text;
				IskontotextBox5.Text = IskontotextBox5.Text.Trim() == string.Empty ? "0" :IskontotextBox5.Text;

				float Miktar =  Convert.ToSingle(MiktartextBox.Text);

				float kolimiktar = Miktar;

				if(BirimComboBox.SelectedIndex==1)
					kolimiktar = Miktar / Carpan;
				
				sp.UpdateSiparisDetay(siparisdetay_no,
					Convert.ToSingle(MiktartextBox.Text),					
					BirimComboBox.SelectedItem.ToString(),
					Convert.ToSingle(FiyatTextBox.Text),
					Convert.ToSingle(MiktartextBox.Text)*Convert.ToSingle(indim_tutar.Text) ,
					Convert.ToSingle(IskontotextBox1.Text),
					Convert.ToSingle(IskontotextBox2.Text),
					Convert.ToSingle(IskontotextBox3.Text),
					Convert.ToSingle(IskontotextBox4.Text),
					Convert.ToSingle(IskontotextBox5.Text),kolimiktar);
				MessageBox.Show("sipariþ düzenlendi");
				Temizle();
				BindSiparisGrid();		
			}
			else
			{
				MessageBox.Show("seçim yapýlmamýþ");
			}

		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
		
		}

		private void Kdv_textBox_TextChanged(object sender, System.EventArgs e)
		{
           
			
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			try
			{
				Convert.ToSingle(IskontotextBox1.Text);	
				Convert.ToSingle(IskontotextBox2.Text);	
				Convert.ToSingle(IskontotextBox3.Text);	
				Convert.ToSingle(FiyatTextBox.Text);	
			}
			catch
			{
				return;
			}


			
			float birimFiyat = Convert.ToSingle(FiyatTextBox.Text);			 
			
			float  iskonto1 =  Convert.ToSingle(IskontotextBox1.Text);		
			float  iskonto2 =  Convert.ToSingle(IskontotextBox2.Text);		
			float  iskonto3 =  Convert.ToSingle(IskontotextBox3.Text);		
				
			float yeniskonto ;
			float girilen = Convert.ToSingle(Kdv_textBox.Text);
           
			birimFiyat = birimFiyat - ((birimFiyat*iskonto1)/100);
			birimFiyat = birimFiyat - ((birimFiyat*iskonto2)/100);
			birimFiyat = birimFiyat - ((birimFiyat*iskonto3)/100);
			//birimFiyat = birimFiyat+((birimFiyat*kdv)/100);

			yeniskonto =  (girilen / (1+(kdv/100)))/ birimFiyat;
			yeniskonto = (1 - yeniskonto)*100;
			yeniskonto = Convert.ToSingle(System.Math.Round(Convert.ToDouble(yeniskonto),2));
			IskontotextBox4.Text=yeniskonto.ToString();
			//Hesapla();		
		}

		

	}
}
