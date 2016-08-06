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
    
    public partial class TBL_URUN_FATURA_MODEL  :ModelBase<TBL_URUN_FATURA_MODEL>
    {
    	 
        public  int  TBL_URUN_FATURA_ID { get { return _tBL_URUN_FATURA_ID; } set { if (!Equals(value, _tBL_URUN_FATURA_ID)) { _tBL_URUN_FATURA_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_FATURA_ID);} } }
    	private  int  _tBL_URUN_FATURA_ID;
    
    	 
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	 
        public Nullable<int> TBL_FATURA_ID { get { return _tBL_FATURA_ID; } set { if (!Equals(value, _tBL_FATURA_ID)) { _tBL_FATURA_ID = value;  NotifyPropertyChanged(m=>m.TBL_FATURA_ID);} } }
    	private Nullable<int> _tBL_FATURA_ID;
    
    	 
        public string URUN_FATURA_MIKTAR { get { return _uRUN_FATURA_MIKTAR; } set { if (!Equals(value, _uRUN_FATURA_MIKTAR)) { _uRUN_FATURA_MIKTAR = value;  NotifyPropertyChanged(m=>m.URUN_FATURA_MIKTAR);} } }
    	private string _uRUN_FATURA_MIKTAR;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
