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
    
    public partial class TBL_SIRKET_SINIF_MODEL  :ModelBase<TBL_SIRKET_SINIF_MODEL>
    {
    	 
        public  int  TBL_SIRKET_SINIF_ID { get { return _tBL_SIRKET_SINIF_ID; } set { if (!Equals(value, _tBL_SIRKET_SINIF_ID)) { _tBL_SIRKET_SINIF_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_SINIF_ID);} } }
    	private  int  _tBL_SIRKET_SINIF_ID;
    
    	 
        public string SIRKET_SINIF_ADI { get { return _sIRKET_SINIF_ADI; } set { if (!Equals(value, _sIRKET_SINIF_ADI)) { _sIRKET_SINIF_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_SINIF_ADI);} } }
    	private string _sIRKET_SINIF_ADI;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
