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
    
    public partial class TBL_KDV_MODEL  :ModelBase<TBL_KDV_MODEL>
    {
    	 
        public  int  TBL_KDV_ID { get { return _tBL_KDV_ID; } set { if (!Equals(value, _tBL_KDV_ID)) { _tBL_KDV_ID = value;  NotifyPropertyChanged(m=>m.TBL_KDV_ID);} } }
    	private  int  _tBL_KDV_ID;
    
    	 
        public Nullable<int> KDV_YUZDESI { get { return _kDV_YUZDESI; } set { if (!Equals(value, _kDV_YUZDESI)) { _kDV_YUZDESI = value;  NotifyPropertyChanged(m=>m.KDV_YUZDESI);} } }
    	private Nullable<int> _kDV_YUZDESI;
    
    	 
        public string KDV_ACIKLAMA { get { return _kDV_ACIKLAMA; } set { if (!Equals(value, _kDV_ACIKLAMA)) { _kDV_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.KDV_ACIKLAMA);} } }
    	private string _kDV_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
