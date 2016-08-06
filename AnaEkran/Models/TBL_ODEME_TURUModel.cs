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
    
    public partial class TBL_ODEME_TURU_MODEL  :ModelBase<TBL_ODEME_TURU_MODEL>
    {
    	 
        public  int  TBL_ODEME_TURU_ID { get { return _tBL_ODEME_TURU_ID; } set { if (!Equals(value, _tBL_ODEME_TURU_ID)) { _tBL_ODEME_TURU_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_TURU_ID);} } }
    	private  int  _tBL_ODEME_TURU_ID;
    
    	 
        public string ODEME_TURU_ADI { get { return _oDEME_TURU_ADI; } set { if (!Equals(value, _oDEME_TURU_ADI)) { _oDEME_TURU_ADI = value;  NotifyPropertyChanged(m=>m.ODEME_TURU_ADI);} } }
    	private string _oDEME_TURU_ADI;
    
    	 
        public string ODEME_TURU_ACIKLAMA { get { return _oDEME_TURU_ACIKLAMA; } set { if (!Equals(value, _oDEME_TURU_ACIKLAMA)) { _oDEME_TURU_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.ODEME_TURU_ACIKLAMA);} } }
    	private string _oDEME_TURU_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
