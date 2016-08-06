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
    
    public partial class TBL_SIRKET_MODEL  :ModelBase<TBL_SIRKET_MODEL>
    {
    	 
        public  int  TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_ID);} } }
    	private  int  _tBL_SIRKET_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_GRUB_ID { get { return _tBL_SIRKET_GRUB_ID; } set { if (!Equals(value, _tBL_SIRKET_GRUB_ID)) { _tBL_SIRKET_GRUB_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_GRUB_ID);} } }
    	private Nullable<int> _tBL_SIRKET_GRUB_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_SINIF_ID { get { return _tBL_SIRKET_SINIF_ID; } set { if (!Equals(value, _tBL_SIRKET_SINIF_ID)) { _tBL_SIRKET_SINIF_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_SINIF_ID);} } }
    	private Nullable<int> _tBL_SIRKET_SINIF_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_TIPI_ID { get { return _tBL_SIRKET_TIPI_ID; } set { if (!Equals(value, _tBL_SIRKET_TIPI_ID)) { _tBL_SIRKET_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_TIPI_ID);} } }
    	private Nullable<int> _tBL_SIRKET_TIPI_ID;
    
    	 
        public string SIRKET_ADI { get { return _sIRKET_ADI; } set { if (!Equals(value, _sIRKET_ADI)) { _sIRKET_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_ADI);} } }
    	private string _sIRKET_ADI;
    
    	 
        public string SIRKET_TELEFON_1 { get { return _sIRKET_TELEFON_1; } set { if (!Equals(value, _sIRKET_TELEFON_1)) { _sIRKET_TELEFON_1 = value;  NotifyPropertyChanged(m=>m.SIRKET_TELEFON_1);} } }
    	private string _sIRKET_TELEFON_1;
    
    	 
        public string SIRKET_TELEFON_2 { get { return _sIRKET_TELEFON_2; } set { if (!Equals(value, _sIRKET_TELEFON_2)) { _sIRKET_TELEFON_2 = value;  NotifyPropertyChanged(m=>m.SIRKET_TELEFON_2);} } }
    	private string _sIRKET_TELEFON_2;
    
    	 
        public string SIRKET_FAX_1 { get { return _sIRKET_FAX_1; } set { if (!Equals(value, _sIRKET_FAX_1)) { _sIRKET_FAX_1 = value;  NotifyPropertyChanged(m=>m.SIRKET_FAX_1);} } }
    	private string _sIRKET_FAX_1;
    
    	 
        public string SIRKET_FAX_2 { get { return _sIRKET_FAX_2; } set { if (!Equals(value, _sIRKET_FAX_2)) { _sIRKET_FAX_2 = value;  NotifyPropertyChanged(m=>m.SIRKET_FAX_2);} } }
    	private string _sIRKET_FAX_2;
    
    	 
        public string SIRKET_MAIL_1 { get { return _sIRKET_MAIL_1; } set { if (!Equals(value, _sIRKET_MAIL_1)) { _sIRKET_MAIL_1 = value;  NotifyPropertyChanged(m=>m.SIRKET_MAIL_1);} } }
    	private string _sIRKET_MAIL_1;
    
    	 
        public string SIRKET_MAIL_2 { get { return _sIRKET_MAIL_2; } set { if (!Equals(value, _sIRKET_MAIL_2)) { _sIRKET_MAIL_2 = value;  NotifyPropertyChanged(m=>m.SIRKET_MAIL_2);} } }
    	private string _sIRKET_MAIL_2;
    
    	 
        public string SIRKET_WEB_ADRES { get { return _sIRKET_WEB_ADRES; } set { if (!Equals(value, _sIRKET_WEB_ADRES)) { _sIRKET_WEB_ADRES = value;  NotifyPropertyChanged(m=>m.SIRKET_WEB_ADRES);} } }
    	private string _sIRKET_WEB_ADRES;
    
    	 
        public string SIRKET_VERGI_DAIRESI { get { return _sIRKET_VERGI_DAIRESI; } set { if (!Equals(value, _sIRKET_VERGI_DAIRESI)) { _sIRKET_VERGI_DAIRESI = value;  NotifyPropertyChanged(m=>m.SIRKET_VERGI_DAIRESI);} } }
    	private string _sIRKET_VERGI_DAIRESI;
    
    	 
        public string SIRKET_VERGI_NO { get { return _sIRKET_VERGI_NO; } set { if (!Equals(value, _sIRKET_VERGI_NO)) { _sIRKET_VERGI_NO = value;  NotifyPropertyChanged(m=>m.SIRKET_VERGI_NO);} } }
    	private string _sIRKET_VERGI_NO;
    
    	 
        public string SIRKET_ADRES { get { return _sIRKET_ADRES; } set { if (!Equals(value, _sIRKET_ADRES)) { _sIRKET_ADRES = value;  NotifyPropertyChanged(m=>m.SIRKET_ADRES);} } }
    	private string _sIRKET_ADRES;
    
    	 
        public string SIRKET_IL { get { return _sIRKET_IL; } set { if (!Equals(value, _sIRKET_IL)) { _sIRKET_IL = value;  NotifyPropertyChanged(m=>m.SIRKET_IL);} } }
    	private string _sIRKET_IL;
    
    	 
        public string SIRKET_ILCE { get { return _sIRKET_ILCE; } set { if (!Equals(value, _sIRKET_ILCE)) { _sIRKET_ILCE = value;  NotifyPropertyChanged(m=>m.SIRKET_ILCE);} } }
    	private string _sIRKET_ILCE;
    
    	 
        public string SIRKET_POSTA_KODU { get { return _sIRKET_POSTA_KODU; } set { if (!Equals(value, _sIRKET_POSTA_KODU)) { _sIRKET_POSTA_KODU = value;  NotifyPropertyChanged(m=>m.SIRKET_POSTA_KODU);} } }
    	private string _sIRKET_POSTA_KODU;
    
    	 
        public string SIRKET_BANKA_ADI { get { return _sIRKET_BANKA_ADI; } set { if (!Equals(value, _sIRKET_BANKA_ADI)) { _sIRKET_BANKA_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_BANKA_ADI);} } }
    	private string _sIRKET_BANKA_ADI;
    
    	 
        public string SIRKET_BANKA_SUBE_ADI { get { return _sIRKET_BANKA_SUBE_ADI; } set { if (!Equals(value, _sIRKET_BANKA_SUBE_ADI)) { _sIRKET_BANKA_SUBE_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_BANKA_SUBE_ADI);} } }
    	private string _sIRKET_BANKA_SUBE_ADI;
    
    	 
        public string SIRKET_HESAP_NO { get { return _sIRKET_HESAP_NO; } set { if (!Equals(value, _sIRKET_HESAP_NO)) { _sIRKET_HESAP_NO = value;  NotifyPropertyChanged(m=>m.SIRKET_HESAP_NO);} } }
    	private string _sIRKET_HESAP_NO;
    
    	 
        public string SIRKET_IBAN { get { return _sIRKET_IBAN; } set { if (!Equals(value, _sIRKET_IBAN)) { _sIRKET_IBAN = value;  NotifyPropertyChanged(m=>m.SIRKET_IBAN);} } }
    	private string _sIRKET_IBAN;
    
    	 
        public string SIRKET_ACIKLAMA { get { return _sIRKET_ACIKLAMA; } set { if (!Equals(value, _sIRKET_ACIKLAMA)) { _sIRKET_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.SIRKET_ACIKLAMA);} } }
    	private string _sIRKET_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
