using System;
using System.Data;
using System.Data.SqlServerCe;


namespace EnterpriceMobile
{
	
	public class StokBilgileri
	{
		Config config;
		SqlCeCommand cmd = new SqlCeCommand();
		public string StokSicilNo;
		public string StokAdi;
		public float Kdv;
		public float sf1;
		public float sf2;
		public float sf3;
		public float sf4;
		public float sf5;
		public float af1;
		public float af2;
		public float af3;
		public float af4;
		public float af5;
		public string Birim1a;
		public float birim1c;


		
		public StokBilgileri(Config c)
		{
			this.config=c;
            cmd.Connection=c.CeConn;			
		}

		public void Fill(string SicilKodu)
		{
			string sql = "select * from stok where SICIL_KODU = '"+SicilKodu+"'";
			cmd.CommandText=sql;
		
			SqlCeDataReader rdr = cmd.ExecuteReader();
			while(rdr.Read())
			{
				StokAdi = rdr["SICIL_ADI"].ToString();
				Kdv = Convert.ToSingle(rdr["SATIS_KDVY"].ToString());
				sf1 = Convert.ToSingle(rdr["SF1"].ToString());
				sf2 = Convert.ToSingle(rdr["SF2"].ToString());
				sf3 = Convert.ToSingle(rdr["SF3"].ToString());
				sf4 = Convert.ToSingle(rdr["SF4"].ToString());
				sf5 = Convert.ToSingle(rdr["SF5"].ToString());

				af1 = Convert.ToSingle(rdr["AF1"].ToString());
				af2 = Convert.ToSingle(rdr["AF2"].ToString());
				af3 = Convert.ToSingle(rdr["AF3"].ToString());
				af4 = Convert.ToSingle(rdr["AF4"].ToString());
				af5 = Convert.ToSingle(rdr["AF5"].ToString());

				Birim1a = rdr["BIRIM1A"].ToString();
				birim1c = Convert.ToSingle(rdr["BIRIM1C"].ToString());



			}
		
		}




	}
}
