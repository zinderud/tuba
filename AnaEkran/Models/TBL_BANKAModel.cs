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
    
    public partial class TBL_BANKA_MODEL  :ModelBase<TBL_BANKA_MODEL>
    {
    	 
        public  int  TBL_BANKA_ID { get { return _tBL_BANKA_ID; } set { if (!Equals(value, _tBL_BANKA_ID)) { _tBL_BANKA_ID = value;  NotifyPropertyChanged(m=>m.TBL_BANKA_ID);} } }
    	private  int  _tBL_BANKA_ID;
    
    	 
        public string BANKA_ADI { get { return _bANKA_ADI; } set { if (!Equals(value, _bANKA_ADI)) { _bANKA_ADI = value;  NotifyPropertyChanged(m=>m.BANKA_ADI);} } }
    	private string _bANKA_ADI;
    
    	 
        public string BANKA_SUBE_ADI { get { return _bANKA_SUBE_ADI; } set { if (!Equals(value, _bANKA_SUBE_ADI)) { _bANKA_SUBE_ADI = value;  NotifyPropertyChanged(m=>m.BANKA_SUBE_ADI);} } }
    	private string _bANKA_SUBE_ADI;
    
    	 
        public string BANKA_IBAN_NO { get { return _bANKA_IBAN_NO; } set { if (!Equals(value, _bANKA_IBAN_NO)) { _bANKA_IBAN_NO = value;  NotifyPropertyChanged(m=>m.BANKA_IBAN_NO);} } }
    	private string _bANKA_IBAN_NO;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public string BANKA_TELEFON_1 { get { return _bANKA_TELEFON_1; } set { if (!Equals(value, _bANKA_TELEFON_1)) { _bANKA_TELEFON_1 = value;  NotifyPropertyChanged(m=>m.BANKA_TELEFON_1);} } }
    	private string _bANKA_TELEFON_1;
    
    	 
        public string BANKA_TELEFON_2 { get { return _bANKA_TELEFON_2; } set { if (!Equals(value, _bANKA_TELEFON_2)) { _bANKA_TELEFON_2 = value;  NotifyPropertyChanged(m=>m.BANKA_TELEFON_2);} } }
    	private string _bANKA_TELEFON_2;
    
    	 
        public string BANKA_ADRES { get { return _bANKA_ADRES; } set { if (!Equals(value, _bANKA_ADRES)) { _bANKA_ADRES = value;  NotifyPropertyChanged(m=>m.BANKA_ADRES);} } }
    	private string _bANKA_ADRES;
    
    	 
        public string BANKA_IL { get { return _bANKA_IL; } set { if (!Equals(value, _bANKA_IL)) { _bANKA_IL = value;  NotifyPropertyChanged(m=>m.BANKA_IL);} } }
    	private string _bANKA_IL;
    
    	 
        public string BANKA_ILCE { get { return _bANKA_ILCE; } set { if (!Equals(value, _bANKA_ILCE)) { _bANKA_ILCE = value;  NotifyPropertyChanged(m=>m.BANKA_ILCE);} } }
    	private string _bANKA_ILCE;
    
    	 
        public string BANKA_MAIL { get { return _bANKA_MAIL; } set { if (!Equals(value, _bANKA_MAIL)) { _bANKA_MAIL = value;  NotifyPropertyChanged(m=>m.BANKA_MAIL);} } }
    	private string _bANKA_MAIL;
    
    	 
        public string BANKA_ACIKLAMA { get { return _bANKA_ACIKLAMA; } set { if (!Equals(value, _bANKA_ACIKLAMA)) { _bANKA_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.BANKA_ACIKLAMA);} } }
    	private string _bANKA_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
