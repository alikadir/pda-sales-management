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
	/// Summary description for CariBilgiForm.
	/// </summary>
	public class CariBilgiForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label carino;
		private System.Windows.Forms.Label cariadi;
		private System.Windows.Forms.Label vergidairesi;
		private System.Windows.Forms.Label vergino;
		private System.Windows.Forms.Label risklimiti;
		private System.Windows.Forms.Label toplamrisk;
		private System.Windows.Forms.Label borcbakiye;
		private System.Windows.Forms.Label ortalamavade;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label ADres;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label telefon;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGrid CariDataGrid;
		private System.Windows.Forms.Label label1;
		Cari c;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn5;
	
		
		
		
	
		public CariBilgiForm(string Carino, Config config)
		{
						
			InitializeComponent();			
			c = new Cari(Carino,config);		
			cariadi.Text = c.cariadi;
			carino.Text=Carino;
			vergidairesi.Text=c.vergidairesi;
			vergino.Text=c.vergino;
			risklimiti.Text=c.risklimiti;
			toplamrisk.Text=c.toplamrisk;
			borcbakiye.Text=c.borcbakiye;
			ortalamavade.Text=c.ortalamavade;
			ADres.Text= c.cariadres1+"\r\n"+c.cariadres2;
			telefon.Text=c.caritel;

					


			
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.telefon = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.ADres = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.ortalamavade = new System.Windows.Forms.Label();
			this.borcbakiye = new System.Windows.Forms.Label();
			this.toplamrisk = new System.Windows.Forms.Label();
			this.risklimiti = new System.Windows.Forms.Label();
			this.vergino = new System.Windows.Forms.Label();
			this.vergidairesi = new System.Windows.Forms.Label();
			this.cariadi = new System.Windows.Forms.Label();
			this.carino = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.CariDataGrid = new System.Windows.Forms.DataGrid();
			this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
			this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.dataGridTextBoxColumn5 = new System.Windows.Forms.DataGridTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(240, 272);
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.telefon);
			this.tabPage1.Controls.Add(this.label19);
			this.tabPage1.Controls.Add(this.label20);
			this.tabPage1.Controls.Add(this.ADres);
			this.tabPage1.Controls.Add(this.label17);
			this.tabPage1.Controls.Add(this.label18);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.ortalamavade);
			this.tabPage1.Controls.Add(this.borcbakiye);
			this.tabPage1.Controls.Add(this.toplamrisk);
			this.tabPage1.Controls.Add(this.risklimiti);
			this.tabPage1.Controls.Add(this.vergino);
			this.tabPage1.Controls.Add(this.vergidairesi);
			this.tabPage1.Controls.Add(this.cariadi);
			this.tabPage1.Controls.Add(this.carino);
			this.tabPage1.Controls.Add(this.label15);
			this.tabPage1.Controls.Add(this.label16);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 4);
			this.tabPage1.Size = new System.Drawing.Size(232, 246);
			this.tabPage1.Text = "Cari";
			// 
			// telefon
			// 
			this.telefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.telefon.ForeColor = System.Drawing.Color.Blue;
			this.telefon.Location = new System.Drawing.Point(64, 110);
			this.telefon.Size = new System.Drawing.Size(150, 20);
			this.telefon.Text = "bos";
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(52, 110);
			this.label19.Size = new System.Drawing.Size(8, 20);
			this.label19.Text = ":";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label20.Location = new System.Drawing.Point(8, 110);
			this.label20.Size = new System.Drawing.Size(40, 20);
			this.label20.Text = "Tel.";
			// 
			// ADres
			// 
			this.ADres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.ADres.ForeColor = System.Drawing.Color.Blue;
			this.ADres.Location = new System.Drawing.Point(62, 66);
			this.ADres.Size = new System.Drawing.Size(150, 40);
			this.ADres.Text = "bos";
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(52, 66);
			this.label17.Size = new System.Drawing.Size(8, 20);
			this.label17.Text = ":";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label18.Location = new System.Drawing.Point(6, 64);
			this.label18.Size = new System.Drawing.Size(40, 20);
			this.label18.Text = "Adres";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(52, 230);
			this.label9.Size = new System.Drawing.Size(8, 20);
			this.label9.Text = ":";
			// 
			// ortalamavade
			// 
			this.ortalamavade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.ortalamavade.ForeColor = System.Drawing.Color.Blue;
			this.ortalamavade.Location = new System.Drawing.Point(64, 230);
			this.ortalamavade.Size = new System.Drawing.Size(150, 20);
			this.ortalamavade.Text = "bos";
			// 
			// borcbakiye
			// 
			this.borcbakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.borcbakiye.ForeColor = System.Drawing.Color.Blue;
			this.borcbakiye.Location = new System.Drawing.Point(64, 210);
			this.borcbakiye.Size = new System.Drawing.Size(150, 20);
			this.borcbakiye.Text = "bos";
			// 
			// toplamrisk
			// 
			this.toplamrisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.toplamrisk.ForeColor = System.Drawing.Color.Blue;
			this.toplamrisk.Location = new System.Drawing.Point(64, 190);
			this.toplamrisk.Size = new System.Drawing.Size(150, 20);
			this.toplamrisk.Text = "bos";
			// 
			// risklimiti
			// 
			this.risklimiti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.risklimiti.ForeColor = System.Drawing.Color.Blue;
			this.risklimiti.Location = new System.Drawing.Point(64, 170);
			this.risklimiti.Size = new System.Drawing.Size(150, 20);
			this.risklimiti.Text = "bos";
			// 
			// vergino
			// 
			this.vergino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.vergino.ForeColor = System.Drawing.Color.Blue;
			this.vergino.Location = new System.Drawing.Point(64, 150);
			this.vergino.Size = new System.Drawing.Size(150, 20);
			this.vergino.Text = "bos";
			// 
			// vergidairesi
			// 
			this.vergidairesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.vergidairesi.ForeColor = System.Drawing.Color.Blue;
			this.vergidairesi.Location = new System.Drawing.Point(64, 130);
			this.vergidairesi.Size = new System.Drawing.Size(150, 20);
			this.vergidairesi.Text = "bos";
			// 
			// cariadi
			// 
			this.cariadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.cariadi.ForeColor = System.Drawing.Color.Blue;
			this.cariadi.Location = new System.Drawing.Point(64, 18);
			this.cariadi.Size = new System.Drawing.Size(150, 40);
			this.cariadi.Text = "bos";
			// 
			// carino
			// 
			this.carino.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular);
			this.carino.ForeColor = System.Drawing.Color.Blue;
			this.carino.Location = new System.Drawing.Point(64, 2);
			this.carino.Size = new System.Drawing.Size(150, 20);
			this.carino.Text = "bos";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(52, 210);
			this.label15.Size = new System.Drawing.Size(8, 20);
			this.label15.Text = ":";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label16.Location = new System.Drawing.Point(6, 230);
			this.label16.Size = new System.Drawing.Size(40, 20);
			this.label16.Text = "Ort. V.";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(52, 190);
			this.label13.Size = new System.Drawing.Size(8, 20);
			this.label13.Text = ":";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label14.Location = new System.Drawing.Point(6, 210);
			this.label14.Size = new System.Drawing.Size(40, 20);
			this.label14.Text = "Bakiye";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(52, 170);
			this.label11.Size = new System.Drawing.Size(8, 20);
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label12.Location = new System.Drawing.Point(6, 190);
			this.label12.Size = new System.Drawing.Size(40, 20);
			this.label12.Text = "R.Top.";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(6, 170);
			this.label10.Size = new System.Drawing.Size(40, 20);
			this.label10.Text = "R.Lim";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(52, 150);
			this.label8.Size = new System.Drawing.Size(8, 20);
			this.label8.Text = ":";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(6, 150);
			this.label7.Size = new System.Drawing.Size(40, 20);
			this.label7.Text = "V.N.";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(52, 130);
			this.label6.Size = new System.Drawing.Size(8, 20);
			this.label6.Text = ":";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(6, 130);
			this.label5.Size = new System.Drawing.Size(40, 20);
			this.label5.Text = "V.D.";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(52, 18);
			this.label3.Size = new System.Drawing.Size(8, 20);
			this.label3.Text = ":";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(6, 18);
			this.label4.Size = new System.Drawing.Size(40, 20);
			this.label4.Text = "Adý";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(52, 2);
			this.label2.Size = new System.Drawing.Size(8, 20);
			this.label2.Text = ":";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(6, 2);
			this.label1.Size = new System.Drawing.Size(40, 20);
			this.label1.Text = "No";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.CariDataGrid);
			this.tabPage2.Location = new System.Drawing.Point(4, 4);
			this.tabPage2.Size = new System.Drawing.Size(232, 246);
			this.tabPage2.Text = "Extre";
			// 
			// CariDataGrid
			// 
			this.CariDataGrid.Location = new System.Drawing.Point(4, 8);
			this.CariDataGrid.Size = new System.Drawing.Size(224, 230);
			this.CariDataGrid.TableStyles.Add(this.dataGridTableStyle1);
			this.CariDataGrid.Text = "dataGrid1";
			// 
			// dataGridTableStyle1
			// 
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn1);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn2);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn3);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn4);
			this.dataGridTableStyle1.GridColumnStyles.Add(this.dataGridTextBoxColumn5);
			this.dataGridTableStyle1.MappingName = "CarDat";
			// 
			// dataGridTextBoxColumn1
			// 
			this.dataGridTextBoxColumn1.HeaderText = "Tarih";
			this.dataGridTextBoxColumn1.MappingName = "TARIH";
			this.dataGridTextBoxColumn1.NullText = "(null)";
			this.dataGridTextBoxColumn1.Width = 55;
			// 
			// dataGridTextBoxColumn2
			// 
			this.dataGridTextBoxColumn2.HeaderText = "Belge No";
			this.dataGridTextBoxColumn2.MappingName = "BELGE_NO";
			this.dataGridTextBoxColumn2.NullText = "(null)";
			this.dataGridTextBoxColumn2.Width = 60;
			// 
			// dataGridTextBoxColumn3
			// 
			this.dataGridTextBoxColumn3.HeaderText = "B";
			this.dataGridTextBoxColumn3.MappingName = "BORC";
			this.dataGridTextBoxColumn3.NullText = "(null)";
			// 
			// dataGridTextBoxColumn4
			// 
			this.dataGridTextBoxColumn4.HeaderText = "A";
			this.dataGridTextBoxColumn4.MappingName = "ALAC";
			this.dataGridTextBoxColumn4.NullText = "(null)";
			// 
			// dataGridTextBoxColumn5
			// 
			this.dataGridTextBoxColumn5.HeaderText = "Ö Kod";
			this.dataGridTextBoxColumn5.MappingName = "OZKOD2";
			this.dataGridTextBoxColumn5.NullText = "(null)";
			this.dataGridTextBoxColumn5.Width = 120;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(160, 224);
			this.button1.Text = "Kapat";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// CariBilgiForm
			// 
			this.ControlBox = false;
			this.Controls.Add(this.tabControl1);
			this.Text = "CariBilgiForm";
			this.Load += new System.EventHandler(this.CariBilgiForm_Load);

		}
		#endregion

		private void CariBilgiForm_Load(object sender, System.EventArgs e)
		{
			
			CariDataGrid.DataSource=c.CariData.Tables[0];

		
		}
		
		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
	}
}
