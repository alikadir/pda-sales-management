using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	public class SiparisBaslikRaporForm : System.Windows.Forms.Form
	{
		Config c;
		private System.Windows.Forms.Button Kapat;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.TextBox SiparisNoTextBox;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.DataGrid SiparisBaslikdataGrid;
		private System.Windows.Forms.Label Tutar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CariTextBox;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.MenuItem menuItem3;
		SiparisIslemleri si;
	
		public SiparisBaslikRaporForm(Config c)
		{
			this.c = c;					
			this.si = new SiparisIslemleri(c);
			InitializeComponent();
			SiparisBaslikdataGrid.DataSource= si.SiparisBaslik().Tables[0];
			label1.Text=si.tumSiparisTutarlari().ToString("##.##0,0");

            			
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
			this.SiparisBaslikdataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.Kapat = new System.Windows.Forms.Button();
			this.SiparisNoTextBox = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.Tutar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CariTextBox = new System.Windows.Forms.TextBox();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			// 
			// SiparisBaslikdataGrid
			// 
			this.SiparisBaslikdataGrid.Size = new System.Drawing.Size(240, 224);
			this.SiparisBaslikdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.SiparisBaslikdataGrid.Text = "dataGrid1";
			this.SiparisBaslikdataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SiparisBaslikdataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.MappingName = "Siparisler";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "MK";
			this.dataGridTextBoxColumn1.MappingName = "Musteri_Kodu";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			this.dataGridTextBoxColumn1.Width = 60;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Sipariþ T";
			this.dataGridTextBoxColumn2.MappingName = "Siparis_Tarihi";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Teslim Tarihi";
			this.dataGridTextBoxColumn3.MappingName = "Teslim_Tarihi";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.MappingName = "Siparis_No";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			this.dataGridTextBoxColumn4.Width = 0;
			// 
			// Kapat
			// 
			this.Kapat.Location = new System.Drawing.Point(168, 248);
			this.Kapat.Text = "Kapat";
			this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
			// 
			// SiparisNoTextBox
			// 
			this.SiparisNoTextBox.Location = new System.Drawing.Point(64, 264);
			this.SiparisNoTextBox.Text = "";
			this.SiparisNoTextBox.Visible = false;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			// 
			// menuItem1
			// 
			this.menuItem1.Enabled = false;
			this.menuItem1.MenuItems.Add(this.menuItem2);
			this.menuItem1.MenuItems.Add(this.menuItem4);
			this.menuItem1.MenuItems.Add(this.menuItem3);
			this.menuItem1.Text = "SEÇÝLÝ ";
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "Sipariþ Detay";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Text = "Cari";
			this.menuItem4.Click += new System.EventHandler(this.menuItem4_Click);
			// 
			// Tutar
			// 
			this.Tutar.Location = new System.Drawing.Point(112, 228);
			this.Tutar.Size = new System.Drawing.Size(36, 20);
			this.Tutar.Text = "Tutar";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(160, 228);
			this.label1.Size = new System.Drawing.Size(80, 20);
			// 
			// CariTextBox
			// 
			this.CariTextBox.Location = new System.Drawing.Point(4, 244);
			this.CariTextBox.Text = "";
			this.CariTextBox.Visible = false;
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.HeaderText = "Adý";
			this.dataGridTextBoxColumn5.MappingName = "Musteri_Adi";
			this.dataGridTextBoxColumn5.NullText = "(null)";
			this.dataGridTextBoxColumn5.Width = 100;
			// 
			// menuItem3
			// 
			this.menuItem3.Text = "Sipariþ Sil";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click_1);
			// 
			// SiparisBaslikRaporForm
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.CariTextBox);
			this.Controls.Add(this.Kapat);
			this.Controls.Add(this.Tutar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SiparisNoTextBox);
			this.Controls.Add(this.SiparisBaslikdataGrid);
			this.Menu = this.mainMenu1;
			this.Text = "SiparisBaslikRaporForm";
			this.Load += new System.EventHandler(this.SiparisBaslikRaporForm_Load);

		}
		#endregion

		private void SiparisBaslikRaporForm_Load(object sender, System.EventArgs e)
		{
            		
		}

		private void Kapat_Click(object sender, System.EventArgs e)
		{
			
			this.Close();
		}

		private void SiparisBaslikdataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column =  SiparisBaslikdataGrid.HitTest(e.X,e.Y).Column;
			int Row =  SiparisBaslikdataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{				
											
				if(column==0)
				{
					CariTextBox.Text=SiparisBaslikdataGrid[Row,0].ToString();					
					SiparisNoTextBox.Text=SiparisBaslikdataGrid[Row,3].ToString();
					menuItem1.Enabled=true;
				}
				else
					menuItem1.Enabled=false;
			
			}

		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if(SiparisNoTextBox.Text.Trim() != string.Empty)
			{
				SiparisRaporlar sr = new SiparisRaporlar(c,Convert.ToInt16(SiparisNoTextBox.Text));
				sr.Show();
			}
		
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			si.SiparisSil(SiparisNoTextBox.Text);
			MessageBox.Show("seçili sipariþ detaylarý ile birlikte veri tabanýndan silindi");
			SiparisBaslikdataGrid.DataSource= si.SiparisBaslik().Tables[0];
		
		}

		private void menuItem4_Click(object sender, System.EventArgs e)
		{
				
			CariBilgiForm CF = new CariBilgiForm(CariTextBox.Text,c);
			CF.ShowDialog();
			
		
		}

		private void menuItem3_Click_1(object sender, System.EventArgs e)
		{
			si.SiparisSil(SiparisNoTextBox.Text);
			MessageBox.Show("seçili sipariþ detaylarý ile birlikte veri tabanýndan silindi");
			SiparisBaslikdataGrid.DataSource= si.SiparisBaslik().Tables[0];
		
		}
	}
}
