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
		SqlCeConnection CeConn = new SqlCeConnection("data source=ankara.sdf");
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		int MaxVadeValue;
			
	
		public SiparisDetay(Config cf, int SiparisNo, Cari c, string  OdemeSekli)
		{
			this.cf=cf;
			this.SiparisNo = SiparisNo;
			this.cari = c;
			IskontoField = cf.GetVadeField(OdemeSekli, out MaxVadeValue);

			CeConn.StateChange +=new StateChangeEventHandler(CeConn_StateChange);
			
		
            		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
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
			this.SicilAdlaricomboBox.Location = new System.Drawing.Point(5, 28);
			this.SicilAdlaricomboBox.Size = new System.Drawing.Size(230, 21);
			this.SicilAdlaricomboBox.ValueMember = "SICIL_KODU";
			this.SicilAdlaricomboBox.SelectedIndexChanged += new System.EventHandler(this.SicilAdlaricomboBox_SelectedIndexChanged);
			// 
			// FiyatcomboBox
			// 
			this.FiyatcomboBox.Items.Add("SF1");
			this.FiyatcomboBox.Items.Add("SF2");
			this.FiyatcomboBox.Items.Add("SF3");
			this.FiyatcomboBox.Items.Add("SF4");
			this.FiyatcomboBox.Items.Add("SF5");
			this.FiyatcomboBox.Location = new System.Drawing.Point(65, 4);
			this.FiyatcomboBox.Size = new System.Drawing.Size(52, 21);
			this.FiyatcomboBox.SelectedIndexChanged += new System.EventHandler(this.FiyatcomboBox_SelectedIndexChanged);
			// 
			// FiyatTextBox
			// 
			this.FiyatTextBox.Location = new System.Drawing.Point(120, 4);
			this.FiyatTextBox.ReadOnly = true;
			this.FiyatTextBox.Size = new System.Drawing.Size(72, 20);
			this.FiyatTextBox.Text = "";
			this.FiyatTextBox.TextChanged += new System.EventHandler(this.FiyatTextBox_TextChanged);
			// 
			// IskontotextBox1
			// 
			this.IskontotextBox1.Location = new System.Drawing.Point(60, 52);
			this.IskontotextBox1.Size = new System.Drawing.Size(32, 20);
			this.IskontotextBox1.Text = "";
			this.IskontotextBox1.TextChanged += new System.EventHandler(this.IskontotextBox1_TextChanged);
			// 
			// IskontotextBox2
			// 
			this.IskontotextBox2.Location = new System.Drawing.Point(95, 52);
			this.IskontotextBox2.Size = new System.Drawing.Size(32, 20);
			this.IskontotextBox2.Text = "";
			this.IskontotextBox2.TextChanged += new System.EventHandler(this.IskontotextBox2_TextChanged);
			// 
			// IskontotextBox3
			// 
			this.IskontotextBox3.Location = new System.Drawing.Point(130, 52);
			this.IskontotextBox3.Size = new System.Drawing.Size(32, 20);
			this.IskontotextBox3.Text = "";
			this.IskontotextBox3.TextChanged += new System.EventHandler(this.IskontotextBox3_TextChanged);
			// 
			// IskontotextBox4
			// 
			this.IskontotextBox4.Location = new System.Drawing.Point(165, 52);
			this.IskontotextBox4.Size = new System.Drawing.Size(32, 20);
			this.IskontotextBox4.Text = "";
			this.IskontotextBox4.TextChanged += new System.EventHandler(this.IskontotextBox4_TextChanged);
			// 
			// IskontotextBox5
			// 
			this.IskontotextBox5.Location = new System.Drawing.Point(200, 52);
			this.IskontotextBox5.Size = new System.Drawing.Size(32, 20);
			this.IskontotextBox5.Text = "";
			this.IskontotextBox5.TextChanged += new System.EventHandler(this.IskontotextBox5_TextChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(10, 52);
			this.label1.Size = new System.Drawing.Size(45, 20);
			this.label1.Text = "Ýskonto";
			// 
			// indim_tutar
			// 
			this.indim_tutar.Location = new System.Drawing.Point(60, 76);
			this.indim_tutar.ReadOnly = true;
			this.indim_tutar.Size = new System.Drawing.Size(80, 20);
			this.indim_tutar.Text = "";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(10, 76);
			this.label7.Size = new System.Drawing.Size(45, 20);
			this.label7.Text = "Ý. tutar";
			// 
			// Elke
			// 
			this.Elke.Location = new System.Drawing.Point(196, 4);
			this.Elke.Size = new System.Drawing.Size(38, 20);
			this.Elke.Text = "Ekle";
			this.Elke.Click += new System.EventHandler(this.Elke_Click);
			// 
			// MiktartextBox
			// 
			this.MiktartextBox.Location = new System.Drawing.Point(60, 100);
			this.MiktartextBox.Size = new System.Drawing.Size(60, 20);
			this.MiktartextBox.Text = "";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label8.Location = new System.Drawing.Point(10, 100);
			this.label8.Size = new System.Drawing.Size(45, 20);
			this.label8.Text = "Miktar";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label9.Location = new System.Drawing.Point(130, 100);
			this.label9.Size = new System.Drawing.Size(45, 20);
			this.label9.Text = "Birim";
			// 
			// BirimComboBox
			// 
			this.BirimComboBox.Location = new System.Drawing.Point(170, 100);
			this.BirimComboBox.Size = new System.Drawing.Size(64, 21);
			this.BirimComboBox.SelectedIndexChanged += new System.EventHandler(this.BirimComboBox_SelectedIndexChanged);
			// 
			// SiparisdataGrid
			// 
			this.SiparisdataGrid.Location = new System.Drawing.Point(6, 152);
			this.SiparisdataGrid.Size = new System.Drawing.Size(230, 108);
			this.SiparisdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.SiparisdataGrid.Text = "dataGrid1";
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
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
			this.dataGridTextBoxColumn2.MappingName = "Sicil_adi";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Tutar";
			this.dataGridTextBoxColumn3.MappingName = "Tutar";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(150, 76);
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(85, 20);
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.label2.Location = new System.Drawing.Point(12, 126);
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.Text = "Ara";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(62, 126);
			this.textBox2.Size = new System.Drawing.Size(172, 20);
			this.textBox2.Text = "";
			// 
			// SiparisDetay
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(239, 270);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
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
			this.Menu = this.mainMenu1;
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
			CeConn.Open();
			string sql = "select distinct(GRUP_KODU) from stok";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds);
			CeConn.Close();			
			return ds;			
		}



		DataSet SicilAdlari(string GrupKodu)
		{
			
			CeConn.Open();		
			string sql = "select SICIL_KODU, SICIL_ADI from stok  where GRUP_KODU = '"+GrupKodu+"' order by SICIL_ADI";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds);
			CeConn.Close();			
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
			GetPrice();
		}

		private void FiyatcomboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
			GetPrice();			

		}

		float SetIskonto1( string Field)
		{			
			CeConn.Open();
			string sql = "select "+Field+" from stok where SICIL_KODU = '"+SicilAdlaricomboBox.SelectedValue.ToString()+"'";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			float i = Convert.ToSingle(cmd.ExecuteScalar());
			CeConn.Close();
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
		void GetBirim()
		{
			
			CeConn.Open();		
			string sql = "select BIRIM1A, BIRIM1C, BIRIM from stok  where SICIL_KODU = '"+SicilAdlaricomboBox.SelectedValue+"'";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			SqlCeDataReader  rdr = cmd.ExecuteReader();
			while(rdr.Read())
			{				
				BirimComboBox.Items.Add(rdr["BIRIM1A"].ToString());
				Carpan =  Convert.ToSingle(rdr["BIRIM1C"].ToString());
				BirimComboBox.Items.Add(rdr["BIRIM"].ToString());

			}
			
							
			CeConn.Close();			
						
		}



		float GetPrice(string urunKodu, string field)
		{
			CeConn.Open();
			string sql = "select "+field+" from stok where SICIL_KODU = '"+urunKodu+"'";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			float i = Convert.ToSingle(cmd.ExecuteScalar());
			CeConn.Close();
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
			if(IskontotextBox3.Text.Trim() != string.Empty &&  Convert.ToDouble(IskontotextBox3.Text) > MaxIskono1)
			{
				MessageBox.Show("Iskonto 3 alanýna girilen deðer "+MaxIskono3.ToString()+" den büyük olamaz");
				a= false;
			}
			return a;
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			

		}
		


		void Hesapla()
		{
			
			if(temizle)
			{
				if(!ChectIskonto())
				{
					return;
				}
				//  int miktar = Convert.ToSingle(MiktartextBox.Text);
				//miktar = miktar  + GetMiktar(GropKodlaricomboBox.SelectedValue.ToString(),SiparisNo);
            
            
						
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
			}


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

				
				InsertSiparisDetay(GropKodlaricomboBox.SelectedValue.ToString(),
					SiparisNo,
					SicilAdlaricomboBox.SelectedValue.ToString(),
					cf.PlasiyerKodu,
					SicilAdlaricomboBox.Items[SicilAdlaricomboBox.SelectedIndex].ToString(),
					Convert.ToSingle(MiktartextBox.Text),					
					BirimComboBox.SelectedItem.ToString(),
					Convert.ToSingle(FiyatTextBox.Text),
					Convert.ToSingle(MiktartextBox.Text)*Convert.ToSingle(indim_tutar.Text) ,
					Convert.ToSingle(IskontotextBox1.Text),
					Convert.ToSingle(IskontotextBox2.Text),
					Convert.ToSingle(IskontotextBox3.Text),
					Convert.ToSingle(IskontotextBox4.Text),
					Convert.ToSingle(IskontotextBox5.Text));
					MessageBox.Show("sipariþ eklendi");
					Temizle();
			}
			else
			{
				MessageBox.Show("seçim yapýlmamýþ");
			}
		
		}


		void InsertSiparisDetay(
			string  Grup_Kodu,
			int		Siparis_No ,
			string	Sicil_Kodu,
			string	Plasiyer_Kodu ,
			string	Sicil_Adi ,
			float	Miktar,
			string	Birim ,
			float	Birim_Fiyat ,
			float	Tutar ,
			float	iskonto1 ,
			float	iskonto2 ,
			float	iskonto3 ,
			float	iskonto4 ,
			float	iskonto5 

			)
		{
			float kolimiktar = Miktar;

			if(BirimComboBox.SelectedIndex==1)
				kolimiktar = Miktar / Carpan;
		

			string sql = "Insert Into siparisDetay ("+
					" Grup_Kodu		,	"+
					" Siparis_No	,	"+
					" Sicil_Kodu	,	"+
					" Plasiyer_Kodu	,	"+	
					" Sicil_Adi		,	"+
					" Miktar		,	"+
					" Birim			,	"+
					" Birim_Fiyat	,	"+
					" Tutar			,	"+
					" iskonto1		,	"+
					" iskonto2		,	"+
					" iskonto3		,	"+
					" iskonto4		,	"+
					" iskonto5		,	"+
					" kolimiktar		)"+
					" VALUES		(	"+
				
					" '"+Grup_Kodu+"'	,	"+
					" "+Siparis_No+"	,	"+
					" '"+Sicil_Kodu+"'	,	"+
					" '"+Plasiyer_Kodu+"',	"+	
					" '"+Sicil_Adi+"'	,	"+
					" "+Miktar+"		,	"+
					" '"+Birim+"'		,	"+
					" "+Birim_Fiyat+"	,	"+
					" "+Tutar+"			,	"+
					" "+iskonto1+"		,	"+
					" "+iskonto2+"		,	"+				
					" "+iskonto3+"		,	"+
					" "+iskonto4+"		,	"+
					" "+iskonto5+"		,	"+
					" "+kolimiktar+"	)	";

			CeConn.Open();
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.ExecuteNonQuery();
			CeConn.Close();
			BindSiparisGrid();					
		}


		DataSet Siparisler()
		{
			CeConn.Open();
			string sql  = "select * from siparisDetay where siparis_no ="+SiparisNo+"";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Siparisler");
			CeConn.Close();
			return ds;            
		}


		void BindSiparisGrid()
		{
			SiparisdataGrid.DataSource = Siparisler().Tables[0];
			
		}

		private void FiyatTextBox_TextChanged(object sender, System.EventArgs e)
		{
			Hesapla();
		}

		private void BirimComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(FiyatTextBox.Text != string.Empty && FiyatTextBox.Text != "")
			{
				float birimF = Convert.ToSingle(FiyatTextBox.Text);		
				if(BirimComboBox.SelectedIndex == 0)
					birimF = birimF * Carpan;
				else
					birimF = birimF / Carpan;
				FiyatTextBox.Text=birimF.ToString();
					Hesapla();
			}

		}

		float GetMiktar(string Grup_Kodu, int Siparis_no)
		{
			CeConn.Open();
			string sql = "select sum(kolimiktar) from siparisDetay where  siparis_no ="+Siparis_no+" And "+
					" Grup_Kodu = '"+Grup_Kodu+"'";
			object o = new SqlCeCommand(sql,CeConn).ExecuteScalar();
			CeConn.Close();			
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			else
				return 0;
		}

		private void IskontotextBox1_TextChanged(object sender, System.EventArgs e)
		{
			Hesapla();
		}

		private void IskontotextBox2_TextChanged(object sender, System.EventArgs e)
		{
			Hesapla();
		}

		private void IskontotextBox3_TextChanged(object sender, System.EventArgs e)
		{
				Hesapla();
		}

		private void IskontotextBox4_TextChanged(object sender, System.EventArgs e)
		{
				Hesapla();
		}

		private void IskontotextBox5_TextChanged(object sender, System.EventArgs e)
		{
				Hesapla();
		}


		float GetAlisFiyati(string Sicil_Kodu, string Field)
		{
			CeConn.Open();
			string sql = "select " +Field +" from stok where SICIL_KODU = '"+Sicil_Kodu+"'";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			float f;
			object o  = cmd.ExecuteScalar();		
			f= Convert.ToSingle(o);
		          
			CeConn.Close();
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

		private void CeConn_StateChange(object sender, StateChangeEventArgs e)
		{
			int i = 0;
		}
	}
}
