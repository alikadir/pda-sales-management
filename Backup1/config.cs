using System;
using System.Xml;
using System.IO;
using System.Data;
using System.Data.SqlServerCe;




namespace EnterpriceMobile
{

	enum XmlNodes
	{
		DatabaseName,
		DatabaseUserName,
		DatabasePwd,
		DatabaseServer,
		PlasiyerKodu,
		Km
	}
	/// <summary>
	/// Summary description forgn plasiyer.
	/// </summary>
	public class Config
	{	

		string _Database = string.Empty;
		string _Server = string.Empty;
		string _Uid = string.Empty;
		string _Pwd = string.Empty;
		string _PlasiyerKodu = string.Empty;
		string _KM = string.Empty;
		string _OnlineIp = string.Empty;
		const string file = "config.xml";
		const string VadeConfigFile = "VadeConfig.Xml";
		const string MiktarConfigFile = "MiktarConfig.Xml";
		bool _kilometre = false;
		

		public SqlCeConnection CeConn = new SqlCeConnection("data source=ankara.sdf");

		public bool IsDbExist
		{
			get
			{
				return File.Exists("ankara.sdf");
			}
		}

		public bool kilometre
		{
			get
			{
				if(!_kilometre)
				{
					_kilometre = km();
					return _kilometre;
				}
				else
				{
					return _kilometre;
				}			
			}			
		}

		bool km()
		{
						
			string sql = "SELECT count(*) as adet FROM Ziyaret where ziyaret_turu='gb'";
			SqlCeCommand cmd = new SqlCeCommand(sql,CeConn);
			object o = cmd.ExecuteScalar();		

			if(o == null)
				return false;
			else
			{
                return Convert.ToInt16(o.ToString()) > 0;				
			}
                        
		}




		public string ConnectionString
		{
			get
			{
				if(isOffline)
                return "DataBase="+DataBase+";uid='"+Uid+"';pwd='"+Pwd+"';Server="+_Server+"";
				else
					return "DataBase="+DataBase+";uid='"+Uid+"';pwd='"+Pwd+"';Server="+_OnlineIp+"";
			}
		}



		XmlDocument Doc = new XmlDocument();

		public Config()
		{
            
					
		}



		public bool IsConfigured
		{
			get
			{
				return File.Exists(file);
			}
		}

		public void SetProertyes()
		{
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(file);
			XmlNodeList nl    = xmlDoc.ChildNodes[1].ChildNodes;
			
			for(int i = 0; i < nl.Count; i++)
			{
				switch(nl[i].Name)
				{
					case	"DatabaseName":
						_Database = nl[i].InnerText;
						break;
					case "DatabasePwd":
						_Pwd = nl[i].InnerText;
						break;
					case "DatabaseServer":
						_Server = nl[i].InnerText;
						break;
					case "DatabaseUserName":
						_Uid = nl[i].InnerText;
						break;
					case "PlasiyerKodu":
						_PlasiyerKodu = nl[i].InnerText.ToString();
						break;
					case "Km": 
						_KM = nl[i].InnerText;
						break;
					case "OnlineIp": 
						_OnlineIp = nl[i].InnerText;
						break;
				}

			}
			
		}

		public string GetVadeField(string OdemeSekli, out int MaxValue)
		{
			string Field = "";
			OdemeSekli = OdemeSekli.ToLower();
			MaxValue = 0;
			XmlDocument Xmldoc = new XmlDocument();
			Xmldoc.Load(VadeConfigFile);
			XmlNodeList nl    = Xmldoc.ChildNodes[1].ChildNodes;
			int count = nl.Count;

			for(int i = 0; i < count ; i++)
			{
				if(nl[i].Name == OdemeSekli)
				{
					for(int k = 0 ; k < nl[i].ChildNodes.Count ; k++)
					{
						switch (nl[i].ChildNodes[k].Name)
						{
							case "Maximum":
								MaxValue = Convert.ToInt16(nl[i].ChildNodes[k].InnerText);
								break;
							case "Field":
								Field = nl[i].ChildNodes[k].InnerText;
								break;
						}
					}
				}
			}
			
			
			return Field;

		}


		public string GetAlisFiyatiField(float miktar)
		{						
			XmlDocument Xmldoc = new XmlDocument();
			Xmldoc.Load(MiktarConfigFile);
			XmlNodeList nl    = Xmldoc.ChildNodes[1].ChildNodes;
			int count = nl.Count;
			for(int i = 0; i  < count; i++)
			{				
                int min = Convert.ToInt16(nl[i].ChildNodes[0].InnerText);
				int max = Convert.ToInt16(nl[i].ChildNodes[1].InnerText);					
				if( miktar >= min && miktar <= max)
					return nl[i].ChildNodes[2].InnerText;
                    				
			}


			return string.Empty;
		}

		public void  CreateConfigFile(string Database, string Server, string Uid,
			string Pwd, string PlasiyerKodu,string Km, string onlieip)
		{
			
				string xml ="<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n"+
					"<Conifg>\r\n"+
					"	<DatabaseName>"+Database+"</DatabaseName>\r\n"+
					"	<DatabaseUserName>"+Uid+"</DatabaseUserName>\r\n"+
					"	<DatabasePwd>"+Pwd+"</DatabasePwd>\r\n"+
					"	<DatabaseServer>"+Server+"</DatabaseServer>\r\n"+
					"	<PlasiyerKodu>"+PlasiyerKodu+"</PlasiyerKodu>\r\n"+
					"	<OnlineIp>"+onlieip+"</OnlineIp>\r\n"+
					"	<Km>"+Km+"</Km>\r\n"+

					"</Conifg>";
				StreamWriter sw = new StreamWriter(file);
				sw.WriteLine(xml);
				sw.Close();
		}




		public string DataBase
		{
			get
			{
				return _Database;
			}
		}
		public string Server
		{
			get
			{
				return _Server;
			}
		}

		public string Uid
		{
			get
			{
				return _Uid;
			}
		}
		public string Pwd
		{
			get
			{
				return _Pwd;
			}
		}

		public string PlasiyerKodu
		{
			get
			{
				return _PlasiyerKodu;
			}
		}
		public string Km
		{
			get
			{
				return _KM;
			}
		}
		public string OnlineIp
		{
			get
			{
				return _OnlineIp;
			}
		}
		public bool isOffline = true;
		
	}
}
