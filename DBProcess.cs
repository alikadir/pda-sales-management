using System;
using System.IO;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace EnterpriceMobile
{
	/// <summary>
	/// Summary description for DB.
	/// </summary>
	public class DB
	{
		SqlCeConnection CeConn;
		SqlConnection SqlConn = new SqlConnection();		
		Config config;
		
		
		public DB(Config c)
		{
			this.config=c;
			
			SqlConn.ConnectionString=config.ConnectionString;
		
			

			if(!IsDbExist())
			{
				CreateDB();
				CeConn = new SqlCeConnection("DataSource=ankara.sdf");
				
				CreateTables();	
			
			}
			else
			{
				File.Delete("ankara.sdf");
				CreateDB();
				CeConn = new SqlCeConnection("DataSource=ankara.sdf");
				
				CreateTables();
			}
		
						
			//stokOkuYaz();
			//CariOkuYaz(config.PlasiyerKodu);
			//CariDataOkuYaz(config.PlasiyerKodu);
		


		}

		bool IsDbExist()
		{
			return File.Exists("ankara.sdf");
		}

		public DB(Config c,bool isnull)
		{
			config = c;		
			CeConn = new SqlCeConnection("DataSource=ankara.sdf");						
			SqlConn.ConnectionString=config.ConnectionString;

			
		}

		
		


		public static void CreateDB()
		{
				SqlCeEngine Engine= new SqlCeEngine("DataSource=ankara.sdf");
				Engine.CreateDatabase();
			
		}
		#region Tablolarý yaratýr
		void CreateTables()
		{	
			CeConn.Open();
			
			try
			{
				
				string CreateCariTableSql =" CREATE TABLE CARI ( "+
					" CR_CARI_NO nvarchar (10), "+
					" CR_CARI_ADI1 nvarchar (37), "+
					" CR_ADRES1	nvarchar (38), "+
					" CR_ADRES2 nvarchar (26), "+
					" CR_TEL1 nvarchar (12), "+
					" CR_VERGI_DA nvarchar (14), "+
					" CR_VERGI_NO nvarchar (10), "+
					" CR_RISK_LIM float , "+
					" CR_TOPLAM_RISK float , "+
					" CR_PLAS_HS nvarchar (10), "+
					" rg_pt float, "+
					" rg_sl float, "+
					" rg_cr float, "+
					" rg_pr float, "+
					" rg_cm float, "+
					" rg_ct float, "+
					" borc_bakiye float,"+
					" ort_vade datetime ,"+
					" rg_pz float) ";	 
			
			
				SqlCeCommand cmd = new SqlCeCommand(CreateCariTableSql,CeConn);
				cmd.ExecuteNonQuery();

				string CreateStokTabeString = " CREATE TABLE Stok ("+
					" GRUP_KODU nvarchar (12), "+
					" SICIL_KODU nvarchar (13), "+
					" SICIL_ADI nvarchar (70), "+
					" SF1 float,"+
					" SF2 float,"+
					" SF3 float,"+
					" SF4 float,"+
					" SF5 float,"+
					" AF1 float,"+
					" AF2 float,"+
					" AF3 float,"+
					" AF4 float,"+
					" AF5 float,"+
					" SATIS_KDVY float,"+
					" IND1 float,"+
					" IND2 float,"+
					" IND3 float,"+
					" IND4 float,"+
					" IND5 float,"+
					" ISK_ENGEL nvarchar (11),"+
					" ISKOD3 nvarchar (7),"+
					" BIRIM nvarchar (8),"+
					" BIRIM1A nvarchar (8),"+
					" BIRIM1C float) "; 


				cmd.CommandText = CreateStokTabeString;
				cmd.ExecuteNonQuery();

				string CreateCarDatTableString = "CREATE TABLE CarDat ( "+
					" TARIH datetime, "+
					" HS_NO nvarchar (10), "+
					" BELGE_NO nvarchar (9),"+
					" BORC float ,"+
					" ALAC float ,"+
					" OZKOD2 nvarchar (19),"+
					" VADE datetime ,"+
					" CR_PLAS_HS nvarchar (10))";			

				cmd.CommandText = CreateCarDatTableString;
				cmd.ExecuteNonQuery();


				string CreateSBaslikTableString = "CREATE TABLE SiparisBaslik ( "+
					" Musteri_Kodu nvarchar (15)," +
					" Siparis_No int IDENTITY (1, 1),"+
					" Musteri_Adi nvarchar (60) ," +
					" Plasiyer_Kodu nvarchar (15)," +
					" Siparis_Tarihi datetime, " +
					" Teslim_Tarihi datetime, "+
					" Vade_Gunu int, "+
					" Odeme_Sekli nvarchar (1))";

				cmd.CommandText = CreateSBaslikTableString;
				cmd.ExecuteNonQuery();

				string SiparisDetayTableString = "CREATE TABLE siparisDetay( "+
					" Grup_Kodu nvarchar (15), "+
					" Siparis_No int, "+
					" SiparisDetay_No int IDENTITY (1, 1),"+
					" Sicil_Kodu nvarchar (15), "+
					" Plasiyer_Kodu nvarchar (15), "+
					" Sicil_Adi nvarchar (70), "+
					" Miktar float, "+
					" Birim nvarchar (10), "+
					" Birim_Fiyat float, "+
					" Tutar float, "+
					" iskonto1 float, "+
					" iskonto2 float, "+
					" iskonto3 float, "+
					" iskonto4 float, "+
					" iskonto5 float, "+
					" kolimiktar float)";

				cmd.CommandText = SiparisDetayTableString;
				cmd.ExecuteNonQuery();

				string TahsilatTableString = "CREATE TABLE TahsilatBaslik ( "+
					" Cari_No nvarchar (15), "+
					" Makbuz_No int IDENTITY (1,1) ,"+
					" Plasiyer_Kodu nvarchar (15), "+
					" Tahsilat_Tarihi datetime )";

				cmd.CommandText = TahsilatTableString;
				cmd.ExecuteNonQuery();


				string TahsilatDetayString 	= "CREATE TABLE TahsilatDetay ( "+
					" Makbuz_No int ,"+
					" Tahsilat_Turu nvarchar(1),"+
					" Tahsilat_Tutari float, "+
					" Para_cinsi nvarchar (3), "+
					" Vadesi datetime, "+
					" Borclu nvarchar (60), "+
					" Tanzim_Tarihi datetime, "+
					" Tanzim_Yeri nvarchar (15), "+
					" Banka nvarchar (15), "+
					" Banka_Sube nvarchar (15), "+
					" Belge_No int IDENTITY (1,1), "+
					" KKart_No nvarchar (19),"+
					" Plasiyer_Kodu nvarchar(15), "+
					" Cari_No nvarchar(15)) ";
                                                                                                                                                             
				
				cmd.CommandText = TahsilatDetayString;
				cmd.ExecuteNonQuery();
				
                
				string ZiyaretTableString = "CREATE TABLE Ziyaret ( "+
					" Cari_No nvarchar (15), "+
					" Ziyaret_turu nvarchar (250),"+
					" Kilometre float, "+
					" Ziyaret_Tarih datetime,"+
					" Plasiyer_Kodu nvarchar (15))";

				cmd.CommandText = ZiyaretTableString;
				cmd.ExecuteNonQuery();			
			
			}
			catch(SqlCeException ex)
			{
				
				

			}
			CeConn.Close();
			
		}

		#endregion

		#region Stok sicil bilgileri aktarma
		public void stokOkuYaz(System.Windows.Forms.Label lb)
		{
			SqlConn.Open();		
			CeConn.Open();
		
			string sql = "delete from stok ";
			new SqlCeCommand(sql,CeConn).ExecuteNonQuery();

			string StokSelect = "select * from stok";
			string stokadet = "select count (*) as adet from stok";
			SqlCommand cmd =new SqlCommand(stokadet,SqlConn);
			int i =Convert.ToInt16(cmd.ExecuteScalar().ToString());
			
			cmd.CommandText= StokSelect;
			int k = 0;
			
			SqlDataReader rdr = cmd.ExecuteReader();
			
			while(rdr.Read())
			{
				
				StokYaz(
					rdr["GRUP_KODU"].ToString().Replace("'","''"),
					rdr["SICIL_KODU"].ToString().Replace("'","''"),
					rdr["SICIL_ADI"].ToString().Replace("'","''"), 
					
					((float)Convert.ToDouble(rdr["SF1"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["SF2"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["SF3"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["SF4"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["SF5"].ToString().Replace(",","."))),

					((float)Convert.ToDouble(rdr["AF1"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["AF2"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["AF3"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["AF4"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["AF5"].ToString().Replace(",","."))),

					((float)Convert.ToDouble(rdr["SATIS_KDVY"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["IND1"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["IND2"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["IND3"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["IND4"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["IND5"].ToString().Replace(",","."))),
					rdr["ISK_ENGEL"].ToString().Replace("'","''"),
					rdr["ISKOD3"].ToString().Replace("'","''"),
					rdr["BIRIM"].ToString().Replace("'","''"),
					rdr["BIRIM1A"].ToString().Replace("'","''"),
					((float)Convert.ToDouble(rdr["BIRIM1C"].ToString().Replace(",","."))));		
				lb.Text= i.ToString() + "/" + k.ToString();
				System.Windows.Forms.Application.DoEvents();
				k +=1;
				
			}
			rdr.Close();
			SqlConn.Close();
			CeConn.Close();
		
			
		
		}

		void StokYaz(
			string GRUP_KODU,
			string SICIL_KODU,
			string SICIL_ADI, 
			float SF1,
			float SF2,
			float SF3,
			float SF4,
			float SF5,
			float AF1,
			float AF2,
			float AF3,
			float AF4,
			float AF5,
			
			float SATIS_KDVY,float IND1,float IND2,
			float IND3,float IND4,float IND5,string ISK_ENGEL,string ISKOD3,
			string BIRIM, string  BIRIM1A, 
			float BIRIM1C)
		{         
			string InsertStok = "INSERT INTO Stok "+
				"(GRUP_KODU, SICIL_KODU, SICIL_ADI, SF1, SF2, SF3, SF4, SF5,AF1, AF2, AF3, AF4, AF5, SATIS_KDVY, IND1, IND2, IND3, IND4, IND5, ISK_ENGEL, ISKOD3, BIRIM, BIRIM1A, "+
				"    BIRIM1C)"+
				" VALUES     "+
				" ('"+GRUP_KODU+"','"+ SICIL_KODU+"','"+SICIL_ADI+"',"+SF1+","+SF2+","+SF3+","+SF4+","+SF5+","+AF1+","+AF2+","+AF3+","+AF4+","+AF5+","+SATIS_KDVY+","+IND1+","+IND2+","+IND3+","+IND4+","+IND5+",'"+ISK_ENGEL+"','"+ISKOD3 +"','"+ BIRIM+"','"+ BIRIM1A+"',"+ BIRIM1C+")";	

			SqlCeCommand cmd = new SqlCeCommand(InsertStok,CeConn);
			cmd.ExecuteNonQuery();	
		
		}
		#endregion

		#region cari bilgileri aktarma
		public void CariOkuYaz(string PlasiyerKodu, System.Windows.Forms.Label lb)
		{
            
			SqlConn.Open();		
			CeConn.Open();
		
			string sql = "delete from CARI";
			new SqlCeCommand(sql,CeConn).ExecuteNonQuery();
			
			string cariadet = "select count(*) from CARI where CR_PLAS_HS = '"+PlasiyerKodu+"'";
			SqlCommand cmd = new SqlCommand(cariadet,SqlConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
		//	pr1.Maximum = i;

			sql = "select * from CARI where CR_PLAS_HS = '"+PlasiyerKodu+"'";
			cmd.CommandText=sql;
			int k=0;
			SqlDataReader rdr = cmd.ExecuteReader();
			while(rdr.Read())
			{
				CariYaz(
					rdr["CR_CARI_NO"].ToString().Replace("'","''"), 
					rdr["CR_CARI_ADI1"].ToString().Replace("'","''"),
					rdr["CR_ADRES1"].ToString().Replace("'","''"), 
					rdr["CR_ADRES2"].ToString().Replace("'","''"), 
					rdr["CR_TEL1"].ToString().Replace("'","''"), 
					rdr["CR_VERGI_DA"].ToString().Replace("'","''"), 
					rdr["CR_VERGI_NO"].ToString().Replace("'","''"), 
					((float)Convert.ToDouble(rdr["CR_RISK_LIM"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["CR_TOPLAM_RISK"].ToString().Replace(",","."))), 
					rdr["CR_PLAS_HS"].ToString().Replace("'","''"), 
					((float)Convert.ToDouble(rdr["rg_pt"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_sl"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_pr"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_cm"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_cr"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_ct"].ToString().Replace(",","."))), 
					((float)Convert.ToDouble(rdr["rg_pz"].ToString().Replace(",","."))),
					((float)Convert.ToDouble(rdr["borc_bakiye"].ToString().Replace(",","."))),
					Convert.ToDateTime(rdr["ort_vade"].ToString())
					);

				//pr1.Value += 1;
				//pr1.Invalidate();
				
				lb.Text= i.ToString() + "/" + k.ToString();
				System.Windows.Forms.Application.DoEvents();
				k +=1;
				
				
                
			}
		
			SqlConn.Close();
			CeConn.Close();
			
			
		
		}


		void CariYaz(
			string CR_CARI_NO, 
			string CR_CARI_ADI1,
			string CR_ADRES1, 
			string CR_ADRES2, 
			string CR_TEL1, 
			string CR_VERGI_DA, 
			string CR_VERGI_NO, 
			float CR_RISK_LIM, 
			float CR_TOPLAM_RISK, 
			string CR_PLAS_HS, 
			float rg_pt, 
			float rg_sl, 
			float rg_pr, 
			float rg_cm, 
			float rg_cr, 
			float rg_ct, 
			float rg_pz		,
			float borc_bakiye,
			DateTime ort_vade
			)
		{
		
			string vd  = ort_vade.ToString("MM/dd/yyyy");
			string sql = " INSERT INTO CARI "+
				" (CR_CARI_NO, CR_CARI_ADI1, CR_ADRES1, CR_ADRES2, CR_TEL1, CR_VERGI_DA, CR_VERGI_NO, CR_RISK_LIM, CR_TOPLAM_RISK, CR_PLAS_HS,"+ 
				" rg_pt, rg_sl, rg_pr, rg_cm, rg_cr, rg_ct, rg_pz,borc_bakiye, ort_vade) "+
				" VALUES  "+
				" ('"+CR_CARI_NO+"','"+ CR_CARI_ADI1+"','"+ CR_ADRES1+"','"+
				CR_ADRES2+"','"+ CR_TEL1+"','"+
				CR_VERGI_DA+"','"+ CR_VERGI_NO+"',"+ CR_RISK_LIM+","+ CR_TOPLAM_RISK+",'"+ CR_PLAS_HS+"',"+ 
				rg_pt+","+rg_sl+","+ rg_pr+","+ rg_cm+","+ rg_cr+","+ rg_ct+","+rg_pz+","+borc_bakiye+",'"+vd+"')";
			new SqlCeCommand(sql,CeConn).ExecuteNonQuery();

		}
		#endregion

		#region Cari datalarý aktarma
		public void CariDataOkuYaz(string PlasiyerKodu, System.Windows.Forms.Label label)
		{
			
			
			SqlConn.Open();	
			CeConn.Open();
		
			string sql ="delete from cardat";
			new SqlCeCommand (sql,CeConn).ExecuteNonQuery();

			sql = "select count(*) from CarDat  where CR_PLAS_HS = '"+config.PlasiyerKodu+"'";
			
			SqlCommand cmd = new SqlCommand(sql,SqlConn);

			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
		
			sql = "select * from CarDat  where CR_PLAS_HS = '"+config.PlasiyerKodu+"'";
			cmd.CommandText=sql;
			SqlDataReader rdr = cmd.ExecuteReader();		
			
			int k = 0;
			while(rdr.Read())
				{
					CariDataYaz(
						((float)Convert.ToDouble(rdr["BORC"].ToString().Replace(",","."))), 
						((float)Convert.ToDouble(rdr["ALAC"].ToString().Replace(",","."))), 
						((float)Convert.ToDouble(rdr["BELGE_NO"].ToString().Replace(",","."))),						
						Convert.ToDateTime(rdr["TARIH"].ToString()), 
						Convert.ToDateTime(rdr["VADE"].ToString()), 
						rdr["CR_PLAS_HS"].ToString().Replace("'","''"),

						rdr["OZKOD2"].ToString().Replace("'","''"), 
						rdr["HS_NO"].ToString().Replace("'","''")
						);
			
				
				label.Text = i.ToString() +"/" + k;
				System.Windows.Forms.Application.DoEvents();
				k +=1;
				}
							
			SqlConn.Close();
			CeConn.Close();		
		}


		void CariDataYaz(
			float BORC, 
			float ALAC, 
			float BELGE_NO, 
			DateTime TARIH, 
			DateTime VADE, 
			string CR_PLAS_HS, 
			string OZKOD2, 
			string HS_NO
			)
		{
			string tr = TARIH.ToString("MM/dd/yyyy");
			string vd  = VADE.ToString("MM/dd/yyyy");

			string sql = "INSERT INTO CarDat "+
                      " (BORC, ALAC, BELGE_NO, TARIH, VADE, CR_PLAS_HS, OZKOD2, HS_NO)"+
						"VALUES     "+
				" ("+BORC+","+ ALAC+","+ BELGE_NO+",'"+tr+"','"+vd+"','"+ CR_PLAS_HS+"','"+ OZKOD2+"','"+ HS_NO+"')";
			new SqlCeCommand(sql,CeConn).ExecuteNonQuery();

		}
		#endregion


		#region PDA dan sql servera
		public void PdaSiparisBaslikOku(System.Windows.Forms.Label label)
		{
			SqlConn.Open();
			CeConn.Open();
			

			string sql = " select count(*) from SiparisBaslik";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            
			
			sql = " select * from SiparisBaslik";
			cmd.CommandText=sql;
				
			
			SqlCeDataReader rdr = cmd.ExecuteReader();
			int k = 0;
			while(rdr.Read())
			{
                PdaSiparisBaslikYaz(
					rdr["Musteri_Kodu"].ToString(),
					rdr["Musteri_Adi"].ToString(),
					rdr["Plasiyer_Kodu"].ToString(),
					Convert.ToDateTime(rdr["Teslim_Tarihi"].ToString()),
					Convert.ToInt16(rdr["Vade_Gunu"].ToString()),
					rdr["Odeme_Sekli"].ToString().ToLower(),
					Convert.ToDateTime(rdr["Siparis_Tarihi"].ToString()),
					Convert.ToInt16(rdr["Siparis_No"].ToString()));
				label.Text = i.ToString() +"/"+ k.ToString();
				System.Windows.Forms.Application.DoEvents();
				k +=1;
			}
			sql = "delete from SiparisBaslik";
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			CeConn.Close();
			SqlConn.Close();
		}

		void PdaSiparisBaslikYaz(string MusteriKodu, string MusteriAdi, string PlasiyerKodu,
			DateTime teslimTarihi, int vadeGunu, string odemeSekli, DateTime siparisTarihi,int siparisNo)
		{
			
			string dt = siparisTarihi.ToString("MM/dd/yyyy"); 
			string tsdt = teslimTarihi.ToString("MM/dd/yyyy"); 	
			string sql = "insert into SiparisBaslik "+
				"(Musteri_Kodu, Musteri_Adi, Plasiyer_Kodu,Siparis_Tarihi, Teslim_Tarihi, "+
				" Vade_Gunu, Odeme_Sekli,Siparis_No)"+
				" VALUES ("+
				" '"+MusteriKodu+"',"+
				" '"+MusteriAdi+"',"+
				" '"+PlasiyerKodu+"',"+
				" '"+dt+"',"+
				" '"+tsdt+"',"+
				" "+vadeGunu+","+
				" '"+odemeSekli+"',"+
				" "+siparisNo+""+
				")";
			SqlCommand  cmd = new SqlCommand(sql,SqlConn);
			cmd.ExecuteNonQuery();		

		}




		public void PdaSiparisDetayOku(System.Windows.Forms.Label label)
		{
			SqlConn.Open();
			CeConn.Open();
			string sql = " select count(*) from siparisDetay";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            
			
			sql = " select * from siparisDetay";
			cmd.CommandText=sql;
				
			
			SqlCeDataReader rdr = cmd.ExecuteReader();
			int k = 0;
			while(rdr.Read())
			{
				PdaInsertSiparisDetay(
					rdr["Grup_Kodu"].ToString(),
					Convert.ToInt16(rdr["Siparis_No"].ToString()),
					rdr["Sicil_Kodu"].ToString(),
					rdr["Plasiyer_Kodu"].ToString(),
					rdr["Sicil_Adi"].ToString(),
					Convert.ToSingle(rdr["Miktar"].ToString()),
					rdr["Birim"].ToString(),
					Convert.ToSingle(rdr["Birim_Fiyat"].ToString()),
					Convert.ToSingle(rdr["Tutar"].ToString()),
					Convert.ToSingle(rdr["iskonto1"].ToString()),
					Convert.ToSingle(rdr["iskonto2"].ToString()),
					Convert.ToSingle(rdr["iskonto3"].ToString()),
					Convert.ToSingle(rdr["iskonto4"].ToString()),
					Convert.ToSingle(rdr["iskonto5"].ToString()),
					Convert.ToSingle(rdr["kolimiktar"].ToString()));
				
				k +=1;
				label.Text = i.ToString()+"/"+ k.ToString();
				System.Windows.Forms.Application.DoEvents();
			
			}
			sql = "delete from siparisDetay";
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			CeConn.Close();
			SqlConn.Close();

		}


		 void PdaInsertSiparisDetay(
			string  Grup_Kodu,
			int		Siparis_No,					
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
			
			SqlCommand cmd = new SqlCommand(sql,SqlConn);			
			cmd.ExecuteNonQuery();			
						
		}

		public void PdaTahsilatBaslikOku(System.Windows.Forms.Label label)
		{
			SqlConn.Open();
			CeConn.Open();
			string sql = " select count(*) from TahsilatBaslik";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            
			
			sql = " select * from TahsilatBaslik";
			cmd.CommandText=sql;
				
			
			SqlCeDataReader rdr = cmd.ExecuteReader();
			int k = 0;
			while(rdr.Read())
			{
				PdaTahsilatBaslikYaz(
					rdr["Cari_No"].ToString(),
					Convert.ToInt16(rdr["Makbuz_No"].ToString()),
                    rdr["Plasiyer_Kodu"].ToString(),
					Convert.ToDateTime(rdr["Tahsilat_Tarihi"].ToString()));
				
				
				k +=1;
				label.Text = i.ToString() +"/"+ k.ToString();
				System.Windows.Forms.Application.DoEvents();				
			}
			sql = "delete from TahsilatBaslik";
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			CeConn.Close();
			SqlConn.Close();
		}


		void PdaTahsilatBaslikYaz(
			string Cari_No,  int MakbuzNo, string Plasiyer_No, DateTime Tahsilat_Tarihi)
		{
			
			string sql = "";
			string tt = Tahsilat_Tarihi.ToString("MM/dd/yyyy");		
			sql ="Insert Into TahsilatBaslik (Cari_No,Plasiyer_Kodu,Tahsilat_Tarihi, Makbuz_No) ";
			sql += " VALUES('"+Cari_No+"','"+Plasiyer_No+"','"+tt+"',"+MakbuzNo+")";
			SqlCommand cmd = new SqlCommand(sql,SqlConn);		
			cmd.ExecuteNonQuery();	
			
		}


		public void PdaTahsilatDetayOku(System.Windows.Forms.Label label)
		{
			SqlConn.Open();
			CeConn.Open();
			string sql = " select count(*) from TahsilatDetay";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            
			
			sql = " select * from TahsilatDetay";
			cmd.CommandText=sql;
				
			
			SqlCeDataReader rdr = cmd.ExecuteReader();
			int k = 0;
			while(rdr.Read())
			{
				PdaTahsilatDetay(
					rdr["Tahsilat_turu"].ToString(),
					Convert.ToSingle(rdr["Tahsilat_tutari"].ToString()),
					rdr["Para_cinsi"].ToString(),
					Convert.ToDateTime(rdr["Vadesi"].ToString()),
					rdr["Borclu"].ToString(),
					Convert.ToDateTime(rdr["Tanzim_Tarihi"].ToString()),
					rdr["Tanzim_Yeri"].ToString(),
					rdr["Banka"].ToString(),
					rdr["Banka_sube"].ToString(),
					rdr["KKart_No"].ToString(),
					Convert.ToUInt16(rdr["Makbuz_No"].ToString()),
					rdr["Plasiyer_Kodu"].ToString(),
					rdr["Cari_No"].ToString());								
				
				k +=1;
				label.Text = i.ToString() +"/"+ k.ToString();
				System.Windows.Forms.Application.DoEvents();				
			}
			sql = "delete from TahsilatDetay";
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			CeConn.Close();
			SqlConn.Close();
		}




		void PdaTahsilatDetay(
			string Tahsilat_turu,
			float Tahsilat_tutari,
			string Para_cinsi,
			DateTime Vadesi,
			string borclu,
			DateTime Tanzim_tarihi,
			string Tanzim_Yeri,
			string Banka,
			string Banka_Sube,			
			string Kkart_no,
			int Makbuz_no,
			string Plasiyer_Kodu,
			string Cari_No
			)
		{

			string sql = "INSERT INTO  TahsilatDetay (Tahsilat_turu, Tahsilat_tutari, "+
				" Para_Cinsi, Vadesi, Borclu, Tanzim_Tarihi, Tanzim_Yeri, Banka, Banka_sube, "+
				" KKart_no, makbuz_no, Plasiyer_Kodu, Cari_No) Values ( "+
				" '"+Tahsilat_turu+"' ," +
				" "+Tahsilat_tutari+" ," +
				" '"+Para_cinsi+"' ," +
				" '"+Vadesi.ToString("MM/dd/yyyy")+"' ," +
				" '"+borclu+"' ," +
				" '"+Tanzim_tarihi.ToString("MM/dd/yyyy")+"' ," +
				" '"+Tanzim_Yeri+"' ," +
				" '"+Banka+"' ," +
				" '"+Banka_Sube+"' ," +				
				" '"+Kkart_no+"' ," +
				" "+Makbuz_no+" ,"+
				" '"+Plasiyer_Kodu+"', "+
				" '"+Cari_No+"' )";
			
			SqlCommand cmd = new SqlCommand(sql,SqlConn);
			cmd.ExecuteNonQuery();	
			
		}


		

		public void PdaZiyaretOku(System.Windows.Forms.Label label)
		{
			SqlConn.Open();
			CeConn.Open();
			string sql = " select count(*) from Ziyaret";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			int i = Convert.ToInt16(cmd.ExecuteScalar().ToString());
            
			
			sql = " select * from Ziyaret";
			cmd.CommandText=sql;
				
			
			SqlCeDataReader rdr = cmd.ExecuteReader();
			int k = 0;
			while(rdr.Read())
			{
				string km = rdr["kilometre"].ToString();
				if(km == string.Empty || km == "")
					km = "0";
				PdaZiyaretYaz(
					rdr["Cari_No"].ToString(),
					rdr["Ziyaret_Turu"].ToString(),
					Convert.ToSingle(km),
					rdr["Plasiyer_Kodu"].ToString(),
					Convert.ToDateTime(rdr["Ziyaret_Tarih"].ToString()));								
				
				k +=1;
				label.Text = i.ToString() +"/"+ k.ToString();
				System.Windows.Forms.Application.DoEvents();				
			}
			sql = "delete from Ziyaret";
			cmd.CommandText = sql;
			cmd.ExecuteNonQuery();
			CeConn.Close();
			SqlConn.Close();

		}


		
		void PdaZiyaretYaz(string Cari_No, string Ziyaret_Turu, float Kilometre, string Plasiyer_Kodu, DateTime ZiyaretTarihi)
		{
			string sql = "INSERT INTO Ziyaret (Cari_No,Ziyaret_turu,Kilometre,Ziyaret_Tarih,Plasiyer_Kodu) values ( "+
				"'"+Cari_No+"','"+Ziyaret_Turu+"',"+Kilometre+",'"+ZiyaretTarihi.ToString("MM/dd/yyyy")+"','"+Plasiyer_Kodu+"' )";
			SqlCommand cmd = new SqlCommand(sql,SqlConn);
			cmd.ExecuteNonQuery();					
		}

		#endregion




		
	}



}
