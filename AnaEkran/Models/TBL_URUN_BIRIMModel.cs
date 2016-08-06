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
    
    public partial class TBL_URUN_BIRIM_MODEL  :ModelBase<TBL_URUN_BIRIM_MODEL>
    {
    	 
        public  int  TBL_URUN_BIRIM_ID { get { return _tBL_URUN_BIRIM_ID; } set { if (!Equals(value, _tBL_URUN_BIRIM_ID)) { _tBL_URUN_BIRIM_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_BIRIM_ID);} } }
    	private  int  _tBL_URUN_BIRIM_ID;
    
    	 
        public string URUN_BIRIM_ADI { get { return _uRUN_BIRIM_ADI; } set { if (!Equals(value, _uRUN_BIRIM_ADI)) { _uRUN_BIRIM_ADI = value;  NotifyPropertyChanged(m=>m.URUN_BIRIM_ADI);} } }
    	private string _uRUN_BIRIM_ADI;
    
    	 
        public string URUN_BIRIM_ACIKLAMA { get { return _uRUN_BIRIM_ACIKLAMA; } set { if (!Equals(value, _uRUN_BIRIM_ACIKLAMA)) { _uRUN_BIRIM_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.URUN_BIRIM_ACIKLAMA);} } }
    	private string _uRUN_BIRIM_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
