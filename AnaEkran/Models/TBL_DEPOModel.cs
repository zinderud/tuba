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
    
    public partial class TBL_DEPO_MODEL  :ModelBase<TBL_DEPO_MODEL>
    {
    	 
        public  int  TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_ID);} } }
    	private  int  _tBL_DEPO_ID;
    
    	 
        public string DEPO_ADI { get { return _dEPO_ADI; } set { if (!Equals(value, _dEPO_ADI)) { _dEPO_ADI = value;  NotifyPropertyChanged(m=>m.DEPO_ADI);} } }
    	private string _dEPO_ADI;
    
    	 
        public string DEPO_ACIKLAMA { get { return _dEPO_ACIKLAMA; } set { if (!Equals(value, _dEPO_ACIKLAMA)) { _dEPO_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.DEPO_ACIKLAMA);} } }
    	private string _dEPO_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
