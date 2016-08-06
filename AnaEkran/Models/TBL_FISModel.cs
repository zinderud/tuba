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
    
    public partial class TBL_FIS_MODEL  :ModelBase<TBL_FIS_MODEL>
    {
    	 
        public  int  TBL_FIS_ID { get { return _tBL_FIS_ID; } set { if (!Equals(value, _tBL_FIS_ID)) { _tBL_FIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_FIS_ID);} } }
    	private  int  _tBL_FIS_ID;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
