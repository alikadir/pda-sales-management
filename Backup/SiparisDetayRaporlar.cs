using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{

	public class SiparisRaporlar : System.Windows.Forms.Form
	{
		Cari cari ;
		Config config;
		private System.Windows.Forms.DataGrid SiparisdataGrid;
		private System.Windows.Forms.Button Kapat;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.TextBox SiparisNoTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Tutar;
		SiparisIslemleri si;

		public SiparisRaporlar(Config config)
		{
			this.config=config;
		
			si = new SiparisIslemleri(config);
					

			InitializeComponent();	
			SiparisdataGrid.DataSource=si.TumSiparisDetaylari.Tables[0];
			
		}

		public SiparisRaporlar(Config config, Cari cari)
		{
			this.config=config;
			this.cari=cari;
			si = new SiparisIslemleri(config);
		
			InitializeComponent();	
			SiparisdataGrid.DataSource=si.TumSiparisDetaylariSorgu(cari.carino).Tables[0];
            label1.Text=si.tumSiparisTutarlari(cari.carino).ToString();

			InitializeComponent();	
		}

		public SiparisRaporlar(Config config, int Siparis_No)
		{
			this.config=config;
	
			si = new SiparisIslemleri(config);
		
			InitializeComponent();	
			SiparisdataGrid.DataSource=si.TumSiparisDetaylariSorgu(Siparis_No).Tables[0];
			label1.Text=si.tumSiparisTutarlari(Siparis_No).ToString();


			InitializeComponent();	
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
			this.SiparisdataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Kapat = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.SiparisNoTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Tutar = new System.Windows.Forms.Label();
			// 
			// SiparisdataGrid
			// 
			this.SiparisdataGrid.Size = new System.Drawing.Size(240, 208);
			this.SiparisdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.SiparisdataGrid.Text = "dataGrid1";
			this.SiparisdataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SiparisdataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.MappingName = "Siparisler";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "Sicil Adý";
			this.dataGridTextBoxColumn1.MappingName = "Sicil_Adi";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			this.dataGridTextBoxColumn1.Width = 75;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Miktar";
			this.dataGridTextBoxColumn2.MappingName = "Miktar";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			this.dataGridTextBoxColumn2.Width = 40;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Birim";
			this.dataGridTextBoxColumn3.MappingName = "Birim";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			this.dataGridTextBoxColumn3.Width = 40;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.HeaderText = "Tutar";
			this.dataGridTextBoxColumn4.MappingName = "Tutar";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			this.dataGridTextBoxColumn4.Width = 45;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.MappingName = "siparisdetay_no";
			this.dataGridTextBoxColumn5.NullText = "(null)";
			this.dataGridTextBoxColumn5.Width = 0;
			// 
			// Kapat
			// 
			this.Kapat.Location = new System.Drawing.Point(168, 248);
			this.Kapat.Text = "Kapat";
			this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			// 
			// menuItem1
			// 
			this.menuItem1.Enabled = false;
			this.menuItem1.Text = "SEÇÝLÝ SÝPARÝÞ";
			// 
			// SiparisNoTextBox
			// 
			this.SiparisNoTextBox.Location = new System.Drawing.Point(56, 244);
			this.SiparisNoTextBox.Text = "";
			this.SiparisNoTextBox.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 216);
			this.label1.Size = new System.Drawing.Size(80, 20);
			// 
			// Tutar
			// 
			this.Tutar.Location = new System.Drawing.Point(116, 216);
			this.Tutar.Size = new System.Drawing.Size(36, 20);
			this.Tutar.Text = "Tutar";
			// 
			// SiparisRaporlar
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.Tutar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SiparisNoTextBox);
			this.Controls.Add(this.Kapat);
			this.Controls.Add(this.SiparisdataGrid);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "SiparisRaporlar";
			this.Load += new System.EventHandler(this.SiparisRaporlar_Load);

		}
		#endregion

		private void SiparisRaporlar_Load(object sender, System.EventArgs e)
		{
			


		}

		private void Kapat_Click(object sender, System.EventArgs e)
		{
			
			this.Close();
		}

		private void SiparisdataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column =  SiparisdataGrid.HitTest(e.X,e.Y).Column;
			int Row =  SiparisdataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{				
				if(column==1)
				{
					SiparisNoTextBox.Text=SiparisdataGrid[Row,4].ToString();
					menuItem1.Enabled=true;
				}
			
			}
		
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			si.SiparisDetaySil(SiparisNoTextBox.Text);
			MessageBox.Show("seçili sipariþ veri tabanýndan silindi");

		}
	}
}
