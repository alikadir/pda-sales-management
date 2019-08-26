    CREATE TABLE SiparisBaslik ( 
					 Musteri_Kodu nvarchar (15), 
					 Siparis_No int ,
					 Musteri_Adi nvarchar (60) , 
					 Plasiyer_Kodu nvarchar (15), 
					 Siparis_Tarihi datetime,  
					 Teslim_Tarihi datetime, 
					 Vade_Gunu int, 
					 Odeme_Sekli nvarchar (1))

GO


				
				CREATE TABLE siparisDetay( 
					 Grup_Kodu nvarchar (15), 
					 Siparis_No int, 
					 Sicil_Kodu nvarchar (15), 
					 Plasiyer_Kodu nvarchar (15), 
					 Sicil_Adi nvarchar (70), 
					 Miktar float, 
					 Birim nvarchar (10), 
					 Birim_Fiyat float, 
					 Tutar float, 
					 iskonto1 float, 
					 iskonto2 float, 
					 iskonto3 float, 
					 iskonto4 float, 
					 iskonto5 float, 
					 kolimiktar float)
GO

			
 CREATE TABLE TahsilatBaslik ( 
					 Cari_No nvarchar (15), 
					 Makbuz_No int  ,
					 Plasiyer_Kodu nvarchar (15), 
					 Tahsilat_Tarihi datetime )

GO


				 CREATE TABLE TahsilatDetay ( 
					 Makbuz_No int ,
					 Tahsilat_Turu nvarchar(1),
					 Tahsilat_Tutari float, 
					 Para_cinsi nvarchar (3), 
					 Vadesi datetime, 
					 Borclu nvarchar (60), 
					 Tanzim_Tarihi datetime, 
					 Tanzim_Yeri nvarchar (15), 
					 Banka nvarchar (15), 
					 Banka_Sube nvarchar (15), 					
					 KKart_No nvarchar (19), 
					 Plasiyer_Kodu nvarchar(25),
					 Cari_No nvarchar (15)
					 )
GO
			
				
                
				 CREATE TABLE Ziyaret ( 
					 Cari_No nvarchar (15), 
					 Ziyaret_turu nvarchar (250),
					 Kilometre float, 
					 Ziyaret_Tarih datetime,
					Plasiyer_Kodu nvarchar (15))
