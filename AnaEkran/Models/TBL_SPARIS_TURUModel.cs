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
    
    public partial class TBL_SPARIS_TURU_MODEL  :ModelBase<TBL_SPARIS_TURU_MODEL>
    {
    	 
        public  int  TBL_SPARIS_TURU_ID { get { return _tBL_SPARIS_TURU_ID; } set { if (!Equals(value, _tBL_SPARIS_TURU_ID)) { _tBL_SPARIS_TURU_ID = value;  NotifyPropertyChanged(m=>m.TBL_SPARIS_TURU_ID);} } }
    	private  int  _tBL_SPARIS_TURU_ID;
    
    	 
        public string SPARIS_TURU_ADI { get { return _sPARIS_TURU_ADI; } set { if (!Equals(value, _sPARIS_TURU_ADI)) { _sPARIS_TURU_ADI = value;  NotifyPropertyChanged(m=>m.SPARIS_TURU_ADI);} } }
    	private string _sPARIS_TURU_ADI;
    
    	 
        public string SPARIS_TURU_ACIKLAMA { get { return _sPARIS_TURU_ACIKLAMA; } set { if (!Equals(value, _sPARIS_TURU_ACIKLAMA)) { _sPARIS_TURU_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.SPARIS_TURU_ACIKLAMA);} } }
    	private string _sPARIS_TURU_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
