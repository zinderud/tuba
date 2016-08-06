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
    
    public partial class TBL_FATURA_MODEL  :ModelBase<TBL_FATURA_MODEL>
    {
    	 
        public  int  TBL_FATURA_ID { get { return _tBL_FATURA_ID; } set { if (!Equals(value, _tBL_FATURA_ID)) { _tBL_FATURA_ID = value;  NotifyPropertyChanged(m=>m.TBL_FATURA_ID);} } }
    	private  int  _tBL_FATURA_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_ID);} } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	 
        public Nullable<int> TBL_FATURA_TURU_ID { get { return _tBL_FATURA_TURU_ID; } set { if (!Equals(value, _tBL_FATURA_TURU_ID)) { _tBL_FATURA_TURU_ID = value;  NotifyPropertyChanged(m=>m.TBL_FATURA_TURU_ID);} } }
    	private Nullable<int> _tBL_FATURA_TURU_ID;
    
    	 
        public string FATURA_TARIH { get { return _fATURA_TARIH; } set { if (!Equals(value, _fATURA_TARIH)) { _fATURA_TARIH = value;  NotifyPropertyChanged(m=>m.FATURA_TARIH);} } }
    	private string _fATURA_TARIH;
    
    	 
        public string FATURA_VADE_TARIH { get { return _fATURA_VADE_TARIH; } set { if (!Equals(value, _fATURA_VADE_TARIH)) { _fATURA_VADE_TARIH = value;  NotifyPropertyChanged(m=>m.FATURA_VADE_TARIH);} } }
    	private string _fATURA_VADE_TARIH;
    
    	 
        public string FATURA_FATURA_SERI_NO { get { return _fATURA_FATURA_SERI_NO; } set { if (!Equals(value, _fATURA_FATURA_SERI_NO)) { _fATURA_FATURA_SERI_NO = value;  NotifyPropertyChanged(m=>m.FATURA_FATURA_SERI_NO);} } }
    	private string _fATURA_FATURA_SERI_NO;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public Nullable<int> TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_TIPI_ID);} } }
    	private Nullable<int> _tBL_ODEME_TIPI_ID;
    
    	 
        public Nullable<int> TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value;  NotifyPropertyChanged(m=>m.TBL_KASA_ID);} } }
    	private Nullable<int> _tBL_KASA_ID;
    
    	 
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_ID);} } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	 
        public Nullable<int> TBL_PERSONEL_ID { get { return _tBL_PERSONEL_ID; } set { if (!Equals(value, _tBL_PERSONEL_ID)) { _tBL_PERSONEL_ID = value;  NotifyPropertyChanged(m=>m.TBL_PERSONEL_ID);} } }
    	private Nullable<int> _tBL_PERSONEL_ID;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    	 
        public Nullable<int> TBL_SPARIS_ID { get { return _tBL_SPARIS_ID; } set { if (!Equals(value, _tBL_SPARIS_ID)) { _tBL_SPARIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_SPARIS_ID);} } }
    	private Nullable<int> _tBL_SPARIS_ID;
    
    
    
    }
}
