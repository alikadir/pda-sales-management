using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for ConfigurationForm.
	/// </summary>
	public class ConfigurationForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox DatbaseTextBox;
		private System.Windows.Forms.TextBox ServertextBox;
		private System.Windows.Forms.TextBox dbUserNametextBox;
		private System.Windows.Forms.TextBox DbSifre;
		private System.Windows.Forms.TextBox plasiyerKodutextBox;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox kilometretextbox;
		private System.Windows.Forms.Label uyari;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.TextBox OnlineIptextBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;

		Config config = new Config();
	
		public ConfigurationForm()
		{
						
			InitializeComponent();
			if(config.IsConfigured)
				Filltextboxs();
			else
				MessageBox.Show("Henüz kofigürasyon yapýlamaýþ! \r\nBu iþlemi yapmadan programý kullanamazssýnýz"); 
			
		}

		void Filltextboxs()
		{
			config.SetProertyes();
			DatbaseTextBox.Text=config.DataBase;
			ServertextBox.Text=config.Server;
			dbUserNametextBox.Text=config.Uid;
			DbSifre.Text=config.Pwd;
			plasiyerKodutextBox.Text=config.PlasiyerKodu;
			kilometretextbox.Text=config.Km;



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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.DatbaseTextBox = new System.Windows.Forms.TextBox();
			this.ServertextBox = new System.Windows.Forms.TextBox();
			this.dbUserNametextBox = new System.Windows.Forms.TextBox();
			this.DbSifre = new System.Windows.Forms.TextBox();
			this.plasiyerKodutextBox = new System.Windows.Forms.TextBox();
			this.kilometretextbox = new System.Windows.Forms.TextBox();
			this.SaveButton = new System.Windows.Forms.Button();
			this.uyari = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.OnlineIptextBox = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 48);
			this.label1.Size = new System.Drawing.Size(80, 20);
			this.label1.Text = "Database";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 72);
			this.label2.Size = new System.Drawing.Size(80, 20);
			this.label2.Text = "Server";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 120);
			this.label3.Size = new System.Drawing.Size(80, 20);
			this.label3.Text = "Db kullanýcý adý";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(8, 144);
			this.label4.Size = new System.Drawing.Size(80, 20);
			this.label4.Text = "Db Þifre";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(8, 168);
			this.label5.Size = new System.Drawing.Size(80, 20);
			this.label5.Text = "Plasiyer Kodu";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 192);
			this.label6.Size = new System.Drawing.Size(80, 20);
			this.label6.Text = "Kilometre";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(88, 48);
			this.label7.Size = new System.Drawing.Size(8, 20);
			this.label7.Text = ":";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(88, 72);
			this.label8.Size = new System.Drawing.Size(8, 20);
			this.label8.Text = ":";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(88, 120);
			this.label9.Size = new System.Drawing.Size(8, 20);
			this.label9.Text = ":";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(88, 144);
			this.label10.Size = new System.Drawing.Size(8, 20);
			this.label10.Text = ":";
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(88, 168);
			this.label11.Size = new System.Drawing.Size(8, 20);
			this.label11.Text = ":";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(88, 192);
			this.label12.Size = new System.Drawing.Size(8, 20);
			this.label12.Text = ":";
			// 
			// DatbaseTextBox
			// 
			this.DatbaseTextBox.Location = new System.Drawing.Point(96, 48);
			this.DatbaseTextBox.Text = "";
			// 
			// ServertextBox
			// 
			this.ServertextBox.Location = new System.Drawing.Point(96, 72);
			this.ServertextBox.Text = "";
			// 
			// dbUserNametextBox
			// 
			this.dbUserNametextBox.Location = new System.Drawing.Point(96, 120);
			this.dbUserNametextBox.Text = "";
			// 
			// DbSifre
			// 
			this.DbSifre.Location = new System.Drawing.Point(96, 144);
			this.DbSifre.Text = "";
			// 
			// plasiyerKodutextBox
			// 
			this.plasiyerKodutextBox.Location = new System.Drawing.Point(96, 168);
			this.plasiyerKodutextBox.Text = "";
			// 
			// kilometretextbox
			// 
			this.kilometretextbox.Location = new System.Drawing.Point(96, 192);
			this.kilometretextbox.Text = "";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(120, 240);
			this.SaveButton.Text = "Kaydet";
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// uyari
			// 
			this.uyari.ForeColor = System.Drawing.Color.Red;
			this.uyari.Location = new System.Drawing.Point(0, 8);
			this.uyari.Size = new System.Drawing.Size(224, 32);
			this.uyari.Text = "Konfigürasyon tamamlanmadan programý kullanamazssýnýz";
			// 
			// OnlineIptextBox
			// 
			this.OnlineIptextBox.Location = new System.Drawing.Point(96, 96);
			this.OnlineIptextBox.Text = "";
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(88, 96);
			this.label13.Size = new System.Drawing.Size(8, 20);
			this.label13.Text = ":";
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 96);
			this.label14.Size = new System.Drawing.Size(80, 20);
			this.label14.Text = "Online IP";
			// 
			// ConfigurationForm
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.OnlineIptextBox);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.uyari);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.kilometretextbox);
			this.Controls.Add(this.plasiyerKodutextBox);
			this.Controls.Add(this.DbSifre);
			this.Controls.Add(this.dbUserNametextBox);
			this.Controls.Add(this.ServertextBox);
			this.Controls.Add(this.DatbaseTextBox);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Menu = this.mainMenu1;
			this.Text = "Ayarlamalar";
			this.Load += new System.EventHandler(this.ConfigurationForm_Load);

		}
		#endregion

		private void ConfigurationForm_Load(object sender, System.EventArgs e)
		{
		
			
		}

		private void SaveButton_Click(object sender, System.EventArgs e)
		{
			if(ServertextBox.Text.Trim() == string.Empty ||
				DatbaseTextBox.Text.Trim() == string.Empty ||
				dbUserNametextBox.Text.Trim() == string.Empty ||
				DbSifre.Text.Trim() == string.Empty ||
				kilometretextbox.Text.Trim() == string.Empty||
				plasiyerKodutextBox.Text.Trim() == string.Empty ||
				OnlineIptextBox.Text.Trim() == string.Empty)
			{
				MessageBox.Show("Ayarlar boþ býrakýlamaz!");

			}
			else
			{
				config.CreateConfigFile(DatbaseTextBox.Text.Trim(),
					ServertextBox.Text.Trim(),dbUserNametextBox.Text.Trim(),
					DbSifre.Text.Trim(),plasiyerKodutextBox.Text.Trim(),kilometretextbox.Text.Trim(),OnlineIptextBox.Text);
				config.SetProertyes();
				MessageBox.Show("Ýþlem Tamam");
			}
		
		}
	}
}
