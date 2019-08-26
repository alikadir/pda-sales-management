using System;
using System.Data.SqlServerCe;
using System.Data;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for Siparis.
	/// </summary>
	public class SiparisIslemleri
	{
		public Config config;
		public Cari cari;
		public int SiparisNo;
		public SqlCeConnection CeConn;
		SqlCeCommand cmd = new SqlCeCommand();

		public SiparisIslemleri(int SiparisNo, Config config, Cari cari)
		{
			this.SiparisNo=SiparisNo;
			this.config=config;
			this.cari=cari;
			CeConn = config.CeConn;
			cmd.Connection=CeConn;


				
		}

		public SiparisIslemleri(Config config, Cari cari)
		{
			
			this.config=config;
			this.cari=cari;
			CeConn = config.CeConn;
			CeConn.Open();
			cmd.Connection=CeConn;

				
		}
		public SiparisIslemleri(Config config)
		{
			
			this.config=config;
			this.cari=cari;
			CeConn = config.CeConn;
			cmd.Connection=CeConn;

				
		}

		
		public float Miktar(string Grup_Kodu, int Siparis_no)
		{
			string sql = "select sum(kolimiktar) from siparisDetay where  siparis_no ="+Siparis_no+" And "+
				" Grup_Kodu = '"+Grup_Kodu+"'";
			object o = new SqlCeCommand(sql,CeConn).ExecuteScalar();
					
			if(o != System.DBNull.Value)
				return Convert.ToSingle(o);
			else
				return 0;
		}	
		

				
		public DataSet Siparisler
		{
			get
			{
				string sql  = "select * from siparisbaslik";
				//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
				cmd.CommandText=sql;
				SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
				DataSet ds = new DataSet();
				ad.Fill(ds,"Siparisler");			
				return ds;            
			}
		}

		
		public DataSet SiparisDetaylari
		{		
			get
			{
				string sql  = "select * from siparisDetay where siparis_no ="+SiparisNo+"";
				//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
				cmd.CommandText=sql;
				SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
				DataSet ds = new DataSet();
				ad.Fill(ds,"Siparisler");			
				return ds;            
			}
		}

		public DataSet TumSiparisDetaylari
		{		
			get
			{
				string sql  = "SELECT     *, SiparisBaslik.Siparis_No  "+
							"FROM         SiparisBaslik INNER JOIN "+
							"SiparisDetay ON SiparisBaslik.Siparis_No = SiparisDetay.Siparis_no ";
				//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
				cmd.CommandText=sql;
				SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
				DataSet ds = new DataSet();
				ad.Fill(ds,"Siparisler");			
				return ds;            
			}
		}

		public DataSet TumSiparisDetaylariSorgu(string Musteri_Kodu)
		{	
			string sql  = "SELECT     *, SiparisBaslik.Siparis_No  "+
				"FROM         SiparisBaslik INNER JOIN "+
				"SiparisDetay ON SiparisBaslik.Siparis_No = SiparisDetay.Siparis_no "+
				" where Musteri_Kodu = '"+Musteri_Kodu+"'";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Siparisler");	
			return ds;			
		}

		/// <summary>
		/// Sipariþ baþlýk tablosundan seçilen sipariþ no ya göre Sipariþ detaylarýný döndürür
		/// </summary>
		/// <param name="Siparis_no"></param>
		/// <returns></returns>
		public DataSet TumSiparisDetaylariSorgu(int Siparis_no)
		{	
			string sql  = "SELECT     *, SiparisBaslik.Siparis_No  "+
				"FROM         SiparisBaslik INNER JOIN "+
				"SiparisDetay ON SiparisBaslik.Siparis_No = SiparisDetay.Siparis_no "+
				" where SiparisDetay.Siparis_no = "+Siparis_no+"";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Siparisler");	
			return ds;			
		}
		
		/// <summary>
		/// Sipariþ baþýk tablsounun tümünü döndürür
		/// </summary>
		/// <returns></returns>
		public DataSet SiparisBaslik()
		{	
			string sql  = "SELECT  *  FROM   SiparisBaslik ";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			SqlCeDataAdapter ad = new SqlCeDataAdapter(cmd);
			DataSet ds = new DataSet();
			ad.Fill(ds,"Siparisler");	
			return ds;			
		}


		/// <summary>
		/// Sipariþ detay tablosundaki tüm sipariþlerin toplamýný alýr
		/// </summary>
		/// <returns></returns>
		public float tumSiparisTutarlari()
		{
			string sql  = "SELECT  sum(Tutar) FROM   SiparisDetay ";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			
			Object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return  Convert.ToSingle(o);
			else return 0;
		}

		
		/// <summary>
		/// Seçili sipariþ numarasýna göre siðpariþ detaydaki tutarlarýn toplamýný döndürü
		/// </summary>
		/// <param name="Siparis_No">Sipariþ baþlýk tablsoundaki sipariþ no</param>
		/// <returns></returns>
		public float tumSiparisTutarlari(int Siparis_No)
		{
			string sql  = "SELECT  sum(Tutar) FROM   SiparisDetay where Siparis_no = "+Siparis_No+"";
			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			
			Object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return  Convert.ToSingle(o);
			else return 0;		
			

		}

		/// <summary>
		/// Seçili cari koduna göre siðpariþ detaydaki tutarlarýn toplamýný döndürü
		/// </summary>
		/// <param name="Siparis_No">Sipariþ baþlýk tablsoundaki sipariþ no</param>
		/// <returns></returns>
		public float tumSiparisTutarlari(string Musteri_Kodu)
		{
			string sql  =  "SELECT     sum(SiparisDetay.Tutar)  "+
				"FROM         SiparisBaslik INNER JOIN "+
				"SiparisDetay ON SiparisBaslik.Siparis_No = SiparisDetay.Siparis_no "+
				" where SiparisBaslik.Musteri_Kodu='"+Musteri_Kodu+"'";

			//SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			cmd.CommandText=sql;
			
			Object o = cmd.ExecuteScalar();
			if(o != System.DBNull.Value)
				return  Convert.ToSingle(o);
			else return 0;		
			

		}



		public void InsertSiparisDetay(
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
			float	iskonto5 ,
			float	kolimiktar

			)
		{	

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
				" '"+Sicil_Adi.Replace("'","''")+"'	,	"+
				" "+Miktar.ToString().Replace(",",".")+"		,	"+
				" '"+Birim+"'		,	"+
				" "+Birim_Fiyat.ToString().Replace(",",".")+"	,	"+
				" "+Tutar.ToString().Replace(",",".")+"			,	"+
				" "+iskonto1.ToString().Replace(",",".")+"		,	"+
				" "+iskonto2.ToString().Replace(",",".")+"		,	"+				
				" "+iskonto3.ToString().Replace(",",".")+"		,	"+
				" "+iskonto4.ToString().Replace(",",".")+"		,	"+
				" "+iskonto5.ToString().Replace(",",".")+"		,	"+
				" "+kolimiktar.ToString().Replace(",",".")+"	)	";		
			
			cmd.CommandText= sql;
			cmd.ExecuteNonQuery();			
						
		}



		public void UpdateSiparisDetay(
            
			int SiparisDetayNo,		
			float	Miktar,
			string	Birim ,
			float	Birim_Fiyat ,
			float	Tutar ,
			float	iskonto1 ,
			float	iskonto2 ,
			float	iskonto3 ,
			float	iskonto4 ,
			float	iskonto5 ,
			float	kolimiktar

			)
		{	

			string sql = "UPDATE siparisDetay  SET"+
			
				" Miktar 		="+Miktar.ToString().Replace(",",".")+"	,	"+
				" Birim			='"+Birim+"'	,	"+
				" Birim_Fiyat	="+Birim_Fiyat.ToString().Replace(",",".")+"	,	"+
				" Tutar			= "+Tutar.ToString().Replace(",",".")+"	,	"+
				" iskonto1		="+iskonto1.ToString().Replace(",",".")+"	,	"+
				" iskonto2		="+iskonto2.ToString().Replace(",",".")+"	,	"+
				" iskonto3		="+iskonto3.ToString().Replace(",",".")+"	,	"+
				" iskonto4		="+iskonto4.ToString().Replace(",",".")+" 	,	"+
				" iskonto5		="+iskonto5.ToString().Replace(",",".")+"	,	"+
				" kolimiktar	="+kolimiktar.ToString().Replace(",",".")+"	"+
				" where siparisdetay_no ="+SiparisDetayNo+" ";			
			
			cmd.CommandText= sql;
			cmd.ExecuteNonQuery();			
						
		}

		/// <summary>
		/// sipariþ detayýný siler
		/// </summary>
		/// <param name="siparisdetay_no">sipariþ detayý no su veri tabanýndaki otomatik numara</param>
		public void SiparisDetaySil(string siparisdetay_no)
		{
			string sql = "delete from siparisdetay where siparisdetay_no = '"+siparisdetay_no+"'";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();					
		}

		/// <summary>
		/// Sipariþi detaylarý ile bilrlikte siler
		/// </summary>
		public void SiparisSil(string SiparisNo)
		{
			string sql = "delete  from siparisdetay  where siparis_no = '"+SiparisNo+"'";
			cmd.CommandText= sql;
			cmd.ExecuteNonQuery();
			sql = "delete from siparisBaslik where Siparis_No ='"+SiparisNo+"'";
			cmd.CommandText=sql;
			cmd.ExecuteNonQuery();
			
		}

		public void InsertZiyaret(string Cari_No, string Ziyaret_Turu, float Kilometre, string Plasiyer_Kodu)
		{
			string bcount = "select count(*) from Ziyaret where ziyaret_turu = 'Baþarýlý' AND Cari_No = '"+Cari_No+"'";
            SqlCeCommand cmd = new SqlCeCommand(bcount,CeConn);
			int i =  Convert.ToInt16(cmd.ExecuteScalar().ToString());
			if(i == 0)
			{
				string sql = "INSERT INTO Ziyaret (Cari_No,Ziyaret_turu,Kilometre,Ziyaret_Tarih, Plasiyer_Kodu) values ( "+
					"'"+Cari_No+"','"+Ziyaret_Turu+"',"+Kilometre+",'"+DateTime.Now.ToString("MM/dd/yyyy")+"','"+Plasiyer_Kodu+"' )";
				cmd.CommandText=sql;
				cmd.ExecuteNonQuery();
			}
			
					
		}



	
	}
}
