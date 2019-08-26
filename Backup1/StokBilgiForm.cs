using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for StokBilgiForm.
	/// </summary>
	public class StokBilgiForm : System.Windows.Forms.Form
	{
		Config c;
		public StokBilgiForm(Config c)
		{
			this.c=c;
            StokBilgileri sb = new StokBilgileri(c);
			sb.Fill("AD0001");
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
			// 
			// StokBilgiForm
			// 
			this.Text = "StokBilgiForm";
			this.Load += new System.EventHandler(this.StokBilgiForm_Load);

		}
		#endregion

		private void StokBilgiForm_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
