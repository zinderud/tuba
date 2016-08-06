//===================================================================================
//  Murat onur karadeniz mvvm model a
//  s
//===================================================================================

#region

 
 using SimpleMvvmToolkit;

#endregion

namespace AnaEkran.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PERSONEL_MODEL  :ModelBase<TBL_PERSONEL_MODEL>
    {
    	 
        public  int  TBL_PERSONEL_ID { get { return _tBL_PERSONEL_ID; } set { if (!Equals(value, _tBL_PERSONEL_ID)) { _tBL_PERSONEL_ID = value;  NotifyPropertyChanged(m=>m.TBL_PERSONEL_ID);} } }
    	private  int  _tBL_PERSONEL_ID;
    
    	 
        public string PERSONEL_AD_SOYAD { get { return _pERSONEL_AD_SOYAD; } set { if (!Equals(value, _pERSONEL_AD_SOYAD)) { _pERSONEL_AD_SOYAD = value;  NotifyPropertyChanged(m=>m.PERSONEL_AD_SOYAD);} } }
    	private string _pERSONEL_AD_SOYAD;
    
    	 
        public string YETKI_SEVIYESI { get { return _yETKI_SEVIYESI; } set { if (!Equals(value, _yETKI_SEVIYESI)) { _yETKI_SEVIYESI = value;  NotifyPropertyChanged(m=>m.YETKI_SEVIYESI);} } }
    	private string _yETKI_SEVIYESI;
    
    	 
        public string SIFRE { get { return _sIFRE; } set { if (!Equals(value, _sIFRE)) { _sIFRE = value;  NotifyPropertyChanged(m=>m.SIFRE);} } }
    	private string _sIFRE;
    
    	 
        public string BARKOD_ID { get { return _bARKOD_ID; } set { if (!Equals(value, _bARKOD_ID)) { _bARKOD_ID = value;  NotifyPropertyChanged(m=>m.BARKOD_ID);} } }
    	private string _bARKOD_ID;
    
    	 
        public string PERSONEL_GOREVI { get { return _pERSONEL_GOREVI; } set { if (!Equals(value, _pERSONEL_GOREVI)) { _pERSONEL_GOREVI = value;  NotifyPropertyChanged(m=>m.PERSONEL_GOREVI);} } }
    	private string _pERSONEL_GOREVI;
    
    	 
        public string PERSONEL_TELEFON1 { get { return _pERSONEL_TELEFON1; } set { if (!Equals(value, _pERSONEL_TELEFON1)) { _pERSONEL_TELEFON1 = value;  NotifyPropertyChanged(m=>m.PERSONEL_TELEFON1);} } }
    	private string _pERSONEL_TELEFON1;
    
    	 
        public string PERSONEL_TELEFON2 { get { return _pERSONEL_TELEFON2; } set { if (!Equals(value, _pERSONEL_TELEFON2)) { _pERSONEL_TELEFON2 = value;  NotifyPropertyChanged(m=>m.PERSONEL_TELEFON2);} } }
    	private string _pERSONEL_TELEFON2;
    
    	 
        public string PERSONEL_MAIL { get { return _pERSONEL_MAIL; } set { if (!Equals(value, _pERSONEL_MAIL)) { _pERSONEL_MAIL = value;  NotifyPropertyChanged(m=>m.PERSONEL_MAIL);} } }
    	private string _pERSONEL_MAIL;
    
    	 
        public string PERSONEL_CALISMA_DURUMU { get { return _pERSONEL_CALISMA_DURUMU; } set { if (!Equals(value, _pERSONEL_CALISMA_DURUMU)) { _pERSONEL_CALISMA_DURUMU = value;  NotifyPropertyChanged(m=>m.PERSONEL_CALISMA_DURUMU);} } }
    	private string _pERSONEL_CALISMA_DURUMU;
    
    	 
        public string PERSONEL_ISE_BASLAMA_TARIHI { get { return _pERSONEL_ISE_BASLAMA_TARIHI; } set { if (!Equals(value, _pERSONEL_ISE_BASLAMA_TARIHI)) { _pERSONEL_ISE_BASLAMA_TARIHI = value;  NotifyPropertyChanged(m=>m.PERSONEL_ISE_BASLAMA_TARIHI);} } }
    	private string _pERSONEL_ISE_BASLAMA_TARIHI;
    
    	 
        public string PERSONEL_ISTEN_AYRILMA_TARIHI { get { return _pERSONEL_ISTEN_AYRILMA_TARIHI; } set { if (!Equals(value, _pERSONEL_ISTEN_AYRILMA_TARIHI)) { _pERSONEL_ISTEN_AYRILMA_TARIHI = value;  NotifyPropertyChanged(m=>m.PERSONEL_ISTEN_AYRILMA_TARIHI);} } }
    	private string _pERSONEL_ISTEN_AYRILMA_TARIHI;
    
    	 
        public string PERSONEL_ISE_GELIS_SAATI { get { return _pERSONEL_ISE_GELIS_SAATI; } set { if (!Equals(value, _pERSONEL_ISE_GELIS_SAATI)) { _pERSONEL_ISE_GELIS_SAATI = value;  NotifyPropertyChanged(m=>m.PERSONEL_ISE_GELIS_SAATI);} } }
    	private string _pERSONEL_ISE_GELIS_SAATI;
    
    	 
        public string PERSONEL_ISTEN_CIKIS_SAATI { get { return _pERSONEL_ISTEN_CIKIS_SAATI; } set { if (!Equals(value, _pERSONEL_ISTEN_CIKIS_SAATI)) { _pERSONEL_ISTEN_CIKIS_SAATI = value;  NotifyPropertyChanged(m=>m.PERSONEL_ISTEN_CIKIS_SAATI);} } }
    	private string _pERSONEL_ISTEN_CIKIS_SAATI;
    
    	 
        public string PERSONEL_SSK_NO { get { return _pERSONEL_SSK_NO; } set { if (!Equals(value, _pERSONEL_SSK_NO)) { _pERSONEL_SSK_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_SSK_NO);} } }
    	private string _pERSONEL_SSK_NO;
    
    	 
        public string PERSONEL_CINSIYET { get { return _pERSONEL_CINSIYET; } set { if (!Equals(value, _pERSONEL_CINSIYET)) { _pERSONEL_CINSIYET = value;  NotifyPropertyChanged(m=>m.PERSONEL_CINSIYET);} } }
    	private string _pERSONEL_CINSIYET;
    
    	 
        public string PERSONEL_KIMLIK_NO { get { return _pERSONEL_KIMLIK_NO; } set { if (!Equals(value, _pERSONEL_KIMLIK_NO)) { _pERSONEL_KIMLIK_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_KIMLIK_NO);} } }
    	private string _pERSONEL_KIMLIK_NO;
    
    	 
        public string PERSONEL_DOGUM_TARIHI { get { return _pERSONEL_DOGUM_TARIHI; } set { if (!Equals(value, _pERSONEL_DOGUM_TARIHI)) { _pERSONEL_DOGUM_TARIHI = value;  NotifyPropertyChanged(m=>m.PERSONEL_DOGUM_TARIHI);} } }
    	private string _pERSONEL_DOGUM_TARIHI;
    
    	 
        public string PERSONEL_DOGUM_YERI { get { return _pERSONEL_DOGUM_YERI; } set { if (!Equals(value, _pERSONEL_DOGUM_YERI)) { _pERSONEL_DOGUM_YERI = value;  NotifyPropertyChanged(m=>m.PERSONEL_DOGUM_YERI);} } }
    	private string _pERSONEL_DOGUM_YERI;
    
    	 
        public string PERSONEL_EGITIM_DURUMU { get { return _pERSONEL_EGITIM_DURUMU; } set { if (!Equals(value, _pERSONEL_EGITIM_DURUMU)) { _pERSONEL_EGITIM_DURUMU = value;  NotifyPropertyChanged(m=>m.PERSONEL_EGITIM_DURUMU);} } }
    	private string _pERSONEL_EGITIM_DURUMU;
    
    	 
        public string PERSONEL_ACIKLAMA { get { return _pERSONEL_ACIKLAMA; } set { if (!Equals(value, _pERSONEL_ACIKLAMA)) { _pERSONEL_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.PERSONEL_ACIKLAMA);} } }
    	private string _pERSONEL_ACIKLAMA;
    
    	 
        public string PERSONEL_AYAKKABI_NO { get { return _pERSONEL_AYAKKABI_NO; } set { if (!Equals(value, _pERSONEL_AYAKKABI_NO)) { _pERSONEL_AYAKKABI_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_AYAKKABI_NO);} } }
    	private string _pERSONEL_AYAKKABI_NO;
    
    	 
        public string PERSONEL_GOMLEK_NO { get { return _pERSONEL_GOMLEK_NO; } set { if (!Equals(value, _pERSONEL_GOMLEK_NO)) { _pERSONEL_GOMLEK_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_GOMLEK_NO);} } }
    	private string _pERSONEL_GOMLEK_NO;
    
    	 
        public string PERSONEL_MONT_NO { get { return _pERSONEL_MONT_NO; } set { if (!Equals(value, _pERSONEL_MONT_NO)) { _pERSONEL_MONT_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_MONT_NO);} } }
    	private string _pERSONEL_MONT_NO;
    
    	 
        public string PERSONEL_PANTOLON_NO { get { return _pERSONEL_PANTOLON_NO; } set { if (!Equals(value, _pERSONEL_PANTOLON_NO)) { _pERSONEL_PANTOLON_NO = value;  NotifyPropertyChanged(m=>m.PERSONEL_PANTOLON_NO);} } }
    	private string _pERSONEL_PANTOLON_NO;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
