using System;
using System.Data;
using System.Data.SqlServerCe;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for Cari.
	/// </summary>
	public class Cari
	{
		SqlCeConnection Ceconn;
		
		
		public string cariadi ;
		public string carino;
		public string cariadres1;
		public string cariadres2;
		public string caritel;
		public string borcbakiye;
		public string ortalamavade;
		public string vergidairesi;
		public string vergino;
		public string risklimiti;
		public string toplamrisk;
		DataSet cr ;


		public DataSet CariData
		{
			get
			{
			
				string sql = "select * from CarDat where HS_NO = '"+carino+"' order by TARIH";
				SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
				SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
				DataSet ds = new DataSet();
				ad.Fill(ds,"CarDat");                
			
				return ds;
 			}
		}


		public DataSet CariDataSet
		{
			get
			{
			
				string sql = "select * from CARI where CR_CARI_NO= '"+carino+"'";
				SqlCeCommand cmd = new SqlCeCommand(sql,Ceconn);
				SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
				DataSet ds = new DataSet();
				ad.Fill(ds,"CarDat");                
			
				return ds;
			}
		}
		

		public Cari(string carino, Config config)
		{
			Ceconn =config.CeConn;
			this.carino= carino;
			cr = CariDataSet;
			SetPropertyies();
			
		
		}

		void SetPropertyies()
		{

			DataTable dt = cr.Tables["CarDat"];		
			
			cariadi=dt.Rows[0]["CR_CARI_ADI1"].ToString();
			cariadres1=dt.Rows[0]["CR_ADRES1"].ToString();
			cariadres2=dt.Rows[0]["CR_ADRES2"].ToString();
			caritel=dt.Rows[0]["CR_TEL1"].ToString();
			vergidairesi=dt.Rows[0]["CR_VERGI_DA"].ToString();
			vergino=dt.Rows[0]["CR_VERGI_NO"].ToString();
			borcbakiye=dt.Rows[0]["borc_bakiye"].ToString();
			ortalamavade=dt.Rows[0]["ort_vade"].ToString();
			risklimiti=dt.Rows[0]["CR_RISK_LIM"].ToString();
			toplamrisk=dt.Rows[0]["CR_TOPLAM_RISK"].ToString();				
		}	

	}
}
