using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for ZiyaretRaporForm.
	/// </summary>
	public class ZiyaretRaporForm : System.Windows.Forms.Form
	{
		Cari cari;
		private System.Windows.Forms.DataGrid ZiyaretdataGrid;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.TextBox CariNotextBox;
		private System.Windows.Forms.Button Kapat;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.Label ziyaretturu;
		Config config;

	
		public ZiyaretRaporForm(Cari cari, Config config)
		{
			this.cari=cari;
			this.config=config;			
			InitializeComponent();
			
			ZiyaretdataGrid.DataSource=Ziyaretler(cari.carino).Tables[0];

			
		}
		public ZiyaretRaporForm(Config config)
		{			
			this.config=config;
			
			InitializeComponent();
			ZiyaretdataGrid.DataSource=Ziyaretler().Tables[0];
			
			
		}


		DataSet Ziyaretler()
		{
			string sql = "SELECT * FROM Ziyaret order by Ziyaret_Tarih desc ";
			SqlCeCommand cmd = new SqlCeCommand(sql,config.CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Ziyaret");
			return ds;
			
		}
		DataSet Ziyaretler(string Cari_No)
		{
			string sql = "SELECT * FROM Ziyaret Where Cari_No='"+Cari_No+"' order by Ziyaret_Tarih desc";
			SqlCeCommand cmd = new SqlCeCommand(sql,config.CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Ziyaret");
			return ds;
			
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
			this.ZiyaretdataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.CariNotextBox = new System.Windows.Forms.TextBox();
			this.Kapat = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.ziyaretturu = new System.Windows.Forms.Label();
			// 
			// ZiyaretdataGrid
			// 
			this.ZiyaretdataGrid.Location = new System.Drawing.Point(0, 8);
			this.ZiyaretdataGrid.Size = new System.Drawing.Size(240, 192);
			this.ZiyaretdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.ZiyaretdataGrid.Text = "dataGrid1";
			this.ZiyaretdataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ZiyaretdataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.MappingName = "Ziyaret";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "CAri";
			this.dataGridTextBoxColumn1.MappingName = "Cari_No";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			this.dataGridTextBoxColumn1.Width = 80;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Km";
			this.dataGridTextBoxColumn2.MappingName = "Kilometre";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			this.dataGridTextBoxColumn2.Width = 60;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Tarih";
			this.dataGridTextBoxColumn3.MappingName = "Ziyaret_Tarih";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			this.dataGridTextBoxColumn3.Width = 55;
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.MappingName = "Ziyaret_turu";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			// 
			// CariNotextBox
			// 
			this.CariNotextBox.Location = new System.Drawing.Point(96, 272);
			this.CariNotextBox.Text = "";
			this.CariNotextBox.Visible = false;
			// 
			// Kapat
			// 
			this.Kapat.Location = new System.Drawing.Point(168, 248);
			this.Kapat.Text = "Kapat";
			this.Kapat.Click += new System.EventHandler(this.Kapat_Click);
			// 
			// ziyaretturu
			// 
			this.ziyaretturu.Location = new System.Drawing.Point(0, 200);
			this.ziyaretturu.Size = new System.Drawing.Size(168, 72);
			this.ziyaretturu.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
			// 
			// ZiyaretRaporForm
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.ziyaretturu);
			this.Controls.Add(this.Kapat);
			this.Controls.Add(this.CariNotextBox);
			this.Controls.Add(this.ZiyaretdataGrid);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "ZiyaretRaporForm";
			this.Load += new System.EventHandler(this.ZiyaretRaporForm_Load);

		}
		#endregion

		private void ZiyaretRaporForm_Load(object sender, System.EventArgs e)
		{
		
		}

		private void ZiyaretdataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column =  ZiyaretdataGrid.HitTest(e.X,e.Y).Column;
			int Row =  ZiyaretdataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{			
					
				if(column==0)
				{
					CariNotextBox.Text=ZiyaretdataGrid[Row,0].ToString();
					
					ziyaretturu.Text= ZiyaretdataGrid[Row,3].ToString();
				}
			
			}

		}

		private void Kapat_Click(object sender, System.EventArgs e)
		{
			
			
			this.Close();
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			
			CariBilgiForm CF = new CariBilgiForm(CariNotextBox.Text,this.config);
			CF.ShowDialog();
			
		}

		private void label1_ParentChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
