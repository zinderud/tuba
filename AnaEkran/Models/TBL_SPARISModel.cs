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
    
    public partial class TBL_SPARIS_MODEL  :ModelBase<TBL_SPARIS_MODEL>
    {
    	 
        public  int  TBL_SPARIS_ID { get { return _tBL_SPARIS_ID; } set { if (!Equals(value, _tBL_SPARIS_ID)) { _tBL_SPARIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_SPARIS_ID);} } }
    	private  int  _tBL_SPARIS_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_ID);} } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	 
        public Nullable<int> TBL_SPARIS_TURU_ID { get { return _tBL_SPARIS_TURU_ID; } set { if (!Equals(value, _tBL_SPARIS_TURU_ID)) { _tBL_SPARIS_TURU_ID = value;  NotifyPropertyChanged(m=>m.TBL_SPARIS_TURU_ID);} } }
    	private Nullable<int> _tBL_SPARIS_TURU_ID;
    
    	 
        public string SPARIS_TARIH { get { return _sPARIS_TARIH; } set { if (!Equals(value, _sPARIS_TARIH)) { _sPARIS_TARIH = value;  NotifyPropertyChanged(m=>m.SPARIS_TARIH);} } }
    	private string _sPARIS_TARIH;
    
    	 
        public string SPARIS_VADE_TARIH { get { return _sPARIS_VADE_TARIH; } set { if (!Equals(value, _sPARIS_VADE_TARIH)) { _sPARIS_VADE_TARIH = value;  NotifyPropertyChanged(m=>m.SPARIS_VADE_TARIH);} } }
    	private string _sPARIS_VADE_TARIH;
    
    	 
        public string SPARIS_FATURA_SERI_NO { get { return _sPARIS_FATURA_SERI_NO; } set { if (!Equals(value, _sPARIS_FATURA_SERI_NO)) { _sPARIS_FATURA_SERI_NO = value;  NotifyPropertyChanged(m=>m.SPARIS_FATURA_SERI_NO);} } }
    	private string _sPARIS_FATURA_SERI_NO;
    
    	 
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
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
