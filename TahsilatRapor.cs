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
	/// Summary description for TahsilatRapor.
	/// </summary>
	public class TahsilatRapor : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid tahsilatdataGrid;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		Config config;
		float ToplamTutar = 0;
		float	krediliTutar = 0;
		float	senetTutar = 0;
		float	cektutar = 0;
		private System.Windows.Forms.Label toplamlabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label nakitlabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label Ceklabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label Senetlabel;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label kredilabel;
		private System.Windows.Forms.Label label11;
		float	nakit = 0;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn6;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.TextBox MakbuzNo;
		SqlCeCommand cmd = new SqlCeCommand();

	
		public TahsilatRapor(Config config)
		{
			
			this.config=config;
			InitializeComponent();
		
			cmd.Connection=config.CeConn;
			tahsilatdataGrid.DataSource=Tahsilatlar().Tables[0];
			toplamlabel.Text=Gettutar().ToString();
			kredilabel.Text=Gettutar("k").ToString();
			Ceklabel.Text=Gettutar("c").ToString();
			Senetlabel.Text=Gettutar("s").ToString();
			nakitlabel.Text=Gettutar("n").ToString();
			
		}

		DataSet Tahsilatlar()
		{
			string sql  = "SELECT     *  "+
				"FROM         TahsilatBaslik INNER JOIN "+
				"TahsilatDetay ON TahsilatBaslik.makbuz_no = TahsilatDetay.makbuz_no ";		

			SqlCeCommand cmd = new SqlCeCommand(sql,config.CeConn);
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Tahsilat");
			return ds;            
		}

		float Gettutar(string turu)
		{
			string sql = "Select sum(Tahsilat_Tutari) from TahsilatDetay where Tahsilat_Turu='"+turu+"'";
			cmd.CommandText=sql;
            object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			return 0;
		}
		float Gettutar()
		{
			string sql = "Select sum(Tahsilat_Tutari) from TahsilatDetay ";
			cmd.CommandText=sql;
			object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			return 0;
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
			this.tahsilatdataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.toplamlabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nakitlabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Ceklabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Senetlabel = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.kredilabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn6 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.MakbuzNo = new System.Windows.Forms.TextBox();
			// 
			// tahsilatdataGrid
			// 
			this.tahsilatdataGrid.Size = new System.Drawing.Size(240, 184);
			this.tahsilatdataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.tahsilatdataGrid.Text = "dataGrid1";
			this.tahsilatdataGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tahsilatdataGrid_MouseDown);
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn6);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.MappingName = "Tahsilat";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "Cari No";
			this.dataGridTextBoxColumn1.MappingName = "Cari_No";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Tutar";
			this.dataGridTextBoxColumn2.MappingName = "Tahsilat_Tutari";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "Tarih";
			this.dataGridTextBoxColumn3.MappingName = "Tanzim_Tarihi";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.HeaderText = "Turu";
			this.dataGridTextBoxColumn4.MappingName = "Tahsilat_Turu";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(2, 248);
			this.button1.Size = new System.Drawing.Size(40, 20);
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(122, 188);
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.Text = "Toplam";
			// 
			// toplamlabel
			// 
			this.toplamlabel.Location = new System.Drawing.Point(188, 188);
			this.toplamlabel.Size = new System.Drawing.Size(50, 15);
			this.toplamlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(164, 188);
			this.label2.Size = new System.Drawing.Size(16, 15);
			this.label2.Text = ":";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(164, 204);
			this.label3.Size = new System.Drawing.Size(16, 15);
			this.label3.Text = ":";
			// 
			// nakitlabel
			// 
			this.nakitlabel.Location = new System.Drawing.Point(188, 204);
			this.nakitlabel.Size = new System.Drawing.Size(50, 15);
			this.nakitlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(124, 204);
			this.label5.Size = new System.Drawing.Size(56, 15);
			this.label5.Text = "Nakit";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(164, 220);
			this.label4.Size = new System.Drawing.Size(16, 15);
			this.label4.Text = ":";
			// 
			// Ceklabel
			// 
			this.Ceklabel.Location = new System.Drawing.Point(188, 220);
			this.Ceklabel.Size = new System.Drawing.Size(50, 15);
			this.Ceklabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(124, 220);
			this.label7.Size = new System.Drawing.Size(56, 15);
			this.label7.Text = "Çek";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(164, 236);
			this.label6.Size = new System.Drawing.Size(16, 15);
			this.label6.Text = ":";
			// 
			// Senetlabel
			// 
			this.Senetlabel.Location = new System.Drawing.Point(188, 236);
			this.Senetlabel.Size = new System.Drawing.Size(50, 15);
			this.Senetlabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(124, 236);
			this.label9.Size = new System.Drawing.Size(56, 15);
			this.label9.Text = "Senet";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(164, 252);
			this.label8.Size = new System.Drawing.Size(16, 15);
			this.label8.Text = ":";
			// 
			// kredilabel
			// 
			this.kredilabel.Location = new System.Drawing.Point(188, 252);
			this.kredilabel.Size = new System.Drawing.Size(50, 15);
			this.kredilabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(124, 252);
			this.label11.Size = new System.Drawing.Size(56, 15);
			this.label11.Text = "Kredi";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.Add(this.menuItem1);
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.HeaderText = "no";
			this.dataGridTextBoxColumn5.MappingName = "Makbuz_No";
			this.dataGridTextBoxColumn5.NullText = "(null)";
			this.dataGridTextBoxColumn5.Width = 0;
			// 
			// dataGridTextBoxColumn6
			// 
			this.dataGridTextBoxColumn6.HeaderText = "Borçlu";
			this.dataGridTextBoxColumn6.MappingName = "Borclu";
			this.dataGridTextBoxColumn6.NullText = "(null)";
			this.dataGridTextBoxColumn6.Width = 100;
			// 
			// menuItem1
			// 
			this.menuItem1.MenuItems.Add(this.menuItem2);
			this.menuItem1.Text = "Seçili Tahsilat";
			// 
			// menuItem2
			// 
			this.menuItem2.Text = "Sil";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// MakbuzNo
			// 
			this.MakbuzNo.Location = new System.Drawing.Point(18, 202);
			this.MakbuzNo.Text = "";
			this.MakbuzNo.Visible = false;
			// 
			// TahsilatRapor
			// 
			this.BackColor = System.Drawing.Color.Silver;
			this.ControlBox = false;
			this.Controls.Add(this.MakbuzNo);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.kredilabel);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.Senetlabel);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Ceklabel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.nakitlabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.toplamlabel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tahsilatdataGrid);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.Menu = this.mainMenu1;
			this.Text = "TahsilatRapor";
			this.Load += new System.EventHandler(this.TahsilatRapor_Load);

		}
		#endregion

		private void TahsilatRapor_Load(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
		
			this.Close();
		}

		private void tahsilatdataGrid_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			int column =  tahsilatdataGrid.HitTest(e.X,e.Y).Column;
			int Row =  tahsilatdataGrid.HitTest(e.X,e.Y).Row;
			if(column != -1 && Row != -1)
			{				
											
				if(column==0)
				{
					MakbuzNo.Text=tahsilatdataGrid[Row,5].ToString();					
					menuItem1.Enabled=true;
				}
				else
					menuItem1.Enabled=false;
			
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{

			TahsilatSil(MakbuzNo.Text);
			MessageBox.Show("Seçil tehsilat detaylarý ile birlikte silindi");
			tahsilatdataGrid.DataSource=Tahsilatlar().Tables[0];
			toplamlabel.Text=Gettutar().ToString();
			kredilabel.Text=Gettutar("k").ToString();
			Ceklabel.Text=Gettutar("c").ToString();
			Senetlabel.Text=Gettutar("s").ToString();
			nakitlabel.Text=Gettutar("n").ToString();
		
		}

		void TahsilatSil(string makbuzNo)
		{
			string sql = "delete from TahsilatBaslik where Makbuz_No = '"+makbuzNo+"'";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();
			sql = "delete from TahsilatDetay where Makbuz_No = '"+makbuzNo+"'";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();

		}
	}
}
