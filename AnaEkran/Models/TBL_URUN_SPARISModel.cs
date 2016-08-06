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
    
    public partial class TBL_URUN_SPARIS_MODEL  :ModelBase<TBL_URUN_SPARIS_MODEL>
    {
    	 
        public  int  TBL_URUN_SPARIS_ID { get { return _tBL_URUN_SPARIS_ID; } set { if (!Equals(value, _tBL_URUN_SPARIS_ID)) { _tBL_URUN_SPARIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_SPARIS_ID);} } }
    	private  int  _tBL_URUN_SPARIS_ID;
    
    	 
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	 
        public Nullable<int> TBL_SIPARIS_ID { get { return _tBL_SIPARIS_ID; } set { if (!Equals(value, _tBL_SIPARIS_ID)) { _tBL_SIPARIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIPARIS_ID);} } }
    	private Nullable<int> _tBL_SIPARIS_ID;
    
    	 
        public string URUN_SIPARIS_MIKTAR { get { return _uRUN_SIPARIS_MIKTAR; } set { if (!Equals(value, _uRUN_SIPARIS_MIKTAR)) { _uRUN_SIPARIS_MIKTAR = value;  NotifyPropertyChanged(m=>m.URUN_SIPARIS_MIKTAR);} } }
    	private string _uRUN_SIPARIS_MIKTAR;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
