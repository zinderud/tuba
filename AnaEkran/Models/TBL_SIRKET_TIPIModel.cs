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
    
    public partial class TBL_SIRKET_TIPI_MODEL  :ModelBase<TBL_SIRKET_TIPI_MODEL>
    {
    	 
        public  int  TBL_SIRKET_TIPI_ID { get { return _tBL_SIRKET_TIPI_ID; } set { if (!Equals(value, _tBL_SIRKET_TIPI_ID)) { _tBL_SIRKET_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_TIPI_ID);} } }
    	private  int  _tBL_SIRKET_TIPI_ID;
    
    	 
        public string SIRKET_TIPI_ADI { get { return _sIRKET_TIPI_ADI; } set { if (!Equals(value, _sIRKET_TIPI_ADI)) { _sIRKET_TIPI_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_TIPI_ADI);} } }
    	private string _sIRKET_TIPI_ADI;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
