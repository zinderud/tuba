//===================================================================================
// sade
//===================================================================================

#region


using System.Runtime.Serialization;

#endregion

namespace AutoBusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
     
     
    public partial class TBL_PERSONELDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_PERSONEL_ID { get { return _tBL_PERSONEL_ID; } set { if (!Equals(value, _tBL_PERSONEL_ID)) { _tBL_PERSONEL_ID = value; } } }
    	private int _tBL_PERSONEL_ID;
    
    	
     	[DataMember]
        public string PERSONEL_AD_SOYAD { get { return _pERSONEL_AD_SOYAD; } set { if (!Equals(value, _pERSONEL_AD_SOYAD)) { _pERSONEL_AD_SOYAD = value; } } }
    	private string _pERSONEL_AD_SOYAD;
    
    	
     	[DataMember]
        public string YETKI_SEVIYESI { get { return _yETKI_SEVIYESI; } set { if (!Equals(value, _yETKI_SEVIYESI)) { _yETKI_SEVIYESI = value; } } }
    	private string _yETKI_SEVIYESI;
    
    	
     	[DataMember]
        public string SIFRE { get { return _sIFRE; } set { if (!Equals(value, _sIFRE)) { _sIFRE = value; } } }
    	private string _sIFRE;
    
    	
     	[DataMember]
        public string BARKOD_ID { get { return _bARKOD_ID; } set { if (!Equals(value, _bARKOD_ID)) { _bARKOD_ID = value; } } }
    	private string _bARKOD_ID;
    
    	
     	[DataMember]
        public string PERSONEL_GOREVI { get { return _pERSONEL_GOREVI; } set { if (!Equals(value, _pERSONEL_GOREVI)) { _pERSONEL_GOREVI = value; } } }
    	private string _pERSONEL_GOREVI;
    
    	
     	[DataMember]
        public string PERSONEL_TELEFON1 { get { return _pERSONEL_TELEFON1; } set { if (!Equals(value, _pERSONEL_TELEFON1)) { _pERSONEL_TELEFON1 = value; } } }
    	private string _pERSONEL_TELEFON1;
    
    	
     	[DataMember]
        public string PERSONEL_TELEFON2 { get { return _pERSONEL_TELEFON2; } set { if (!Equals(value, _pERSONEL_TELEFON2)) { _pERSONEL_TELEFON2 = value; } } }
    	private string _pERSONEL_TELEFON2;
    
    	
     	[DataMember]
        public string PERSONEL_MAIL { get { return _pERSONEL_MAIL; } set { if (!Equals(value, _pERSONEL_MAIL)) { _pERSONEL_MAIL = value; } } }
    	private string _pERSONEL_MAIL;
    
    	
     	[DataMember]
        public string PERSONEL_CALISMA_DURUMU { get { return _pERSONEL_CALISMA_DURUMU; } set { if (!Equals(value, _pERSONEL_CALISMA_DURUMU)) { _pERSONEL_CALISMA_DURUMU = value; } } }
    	private string _pERSONEL_CALISMA_DURUMU;
    
    	
     	[DataMember]
        public string PERSONEL_ISE_BASLAMA_TARIHI { get { return _pERSONEL_ISE_BASLAMA_TARIHI; } set { if (!Equals(value, _pERSONEL_ISE_BASLAMA_TARIHI)) { _pERSONEL_ISE_BASLAMA_TARIHI = value; } } }
    	private string _pERSONEL_ISE_BASLAMA_TARIHI;
    
    	
     	[DataMember]
        public string PERSONEL_ISTEN_AYRILMA_TARIHI { get { return _pERSONEL_ISTEN_AYRILMA_TARIHI; } set { if (!Equals(value, _pERSONEL_ISTEN_AYRILMA_TARIHI)) { _pERSONEL_ISTEN_AYRILMA_TARIHI = value; } } }
    	private string _pERSONEL_ISTEN_AYRILMA_TARIHI;
    
    	
     	[DataMember]
        public string PERSONEL_ISE_GELIS_SAATI { get { return _pERSONEL_ISE_GELIS_SAATI; } set { if (!Equals(value, _pERSONEL_ISE_GELIS_SAATI)) { _pERSONEL_ISE_GELIS_SAATI = value; } } }
    	private string _pERSONEL_ISE_GELIS_SAATI;
    
    	
     	[DataMember]
        public string PERSONEL_ISTEN_CIKIS_SAATI { get { return _pERSONEL_ISTEN_CIKIS_SAATI; } set { if (!Equals(value, _pERSONEL_ISTEN_CIKIS_SAATI)) { _pERSONEL_ISTEN_CIKIS_SAATI = value; } } }
    	private string _pERSONEL_ISTEN_CIKIS_SAATI;
    
    	
     	[DataMember]
        public string PERSONEL_SSK_NO { get { return _pERSONEL_SSK_NO; } set { if (!Equals(value, _pERSONEL_SSK_NO)) { _pERSONEL_SSK_NO = value; } } }
    	private string _pERSONEL_SSK_NO;
    
    	
     	[DataMember]
        public string PERSONEL_CINSIYET { get { return _pERSONEL_CINSIYET; } set { if (!Equals(value, _pERSONEL_CINSIYET)) { _pERSONEL_CINSIYET = value; } } }
    	private string _pERSONEL_CINSIYET;
    
    	
     	[DataMember]
        public string PERSONEL_KIMLIK_NO { get { return _pERSONEL_KIMLIK_NO; } set { if (!Equals(value, _pERSONEL_KIMLIK_NO)) { _pERSONEL_KIMLIK_NO = value; } } }
    	private string _pERSONEL_KIMLIK_NO;
    
    	
     	[DataMember]
        public string PERSONEL_DOGUM_TARIHI { get { return _pERSONEL_DOGUM_TARIHI; } set { if (!Equals(value, _pERSONEL_DOGUM_TARIHI)) { _pERSONEL_DOGUM_TARIHI = value; } } }
    	private string _pERSONEL_DOGUM_TARIHI;
    
    	
     	[DataMember]
        public string PERSONEL_DOGUM_YERI { get { return _pERSONEL_DOGUM_YERI; } set { if (!Equals(value, _pERSONEL_DOGUM_YERI)) { _pERSONEL_DOGUM_YERI = value; } } }
    	private string _pERSONEL_DOGUM_YERI;
    
    	
     	[DataMember]
        public string PERSONEL_EGITIM_DURUMU { get { return _pERSONEL_EGITIM_DURUMU; } set { if (!Equals(value, _pERSONEL_EGITIM_DURUMU)) { _pERSONEL_EGITIM_DURUMU = value; } } }
    	private string _pERSONEL_EGITIM_DURUMU;
    
    	
     	[DataMember]
        public string PERSONEL_ACIKLAMA { get { return _pERSONEL_ACIKLAMA; } set { if (!Equals(value, _pERSONEL_ACIKLAMA)) { _pERSONEL_ACIKLAMA = value; } } }
    	private string _pERSONEL_ACIKLAMA;
    
    	
     	[DataMember]
        public string PERSONEL_AYAKKABI_NO { get { return _pERSONEL_AYAKKABI_NO; } set { if (!Equals(value, _pERSONEL_AYAKKABI_NO)) { _pERSONEL_AYAKKABI_NO = value; } } }
    	private string _pERSONEL_AYAKKABI_NO;
    
    	
     	[DataMember]
        public string PERSONEL_GOMLEK_NO { get { return _pERSONEL_GOMLEK_NO; } set { if (!Equals(value, _pERSONEL_GOMLEK_NO)) { _pERSONEL_GOMLEK_NO = value; } } }
    	private string _pERSONEL_GOMLEK_NO;
    
    	
     	[DataMember]
        public string PERSONEL_MONT_NO { get { return _pERSONEL_MONT_NO; } set { if (!Equals(value, _pERSONEL_MONT_NO)) { _pERSONEL_MONT_NO = value; } } }
    	private string _pERSONEL_MONT_NO;
    
    	
     	[DataMember]
        public string PERSONEL_PANTOLON_NO { get { return _pERSONEL_PANTOLON_NO; } set { if (!Equals(value, _pERSONEL_PANTOLON_NO)) { _pERSONEL_PANTOLON_NO = value; } } }
    	private string _pERSONEL_PANTOLON_NO;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
