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
    
    public partial class TBL_ODEME_TIPI_MODEL  :ModelBase<TBL_ODEME_TIPI_MODEL>
    {
    	 
        public  int  TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_TIPI_ID);} } }
    	private  int  _tBL_ODEME_TIPI_ID;
    
    	 
        public string ODEME_TIPI_ADI { get { return _oDEME_TIPI_ADI; } set { if (!Equals(value, _oDEME_TIPI_ADI)) { _oDEME_TIPI_ADI = value;  NotifyPropertyChanged(m=>m.ODEME_TIPI_ADI);} } }
    	private string _oDEME_TIPI_ADI;
    
    	 
        public string ODEME_TIPI_ACIKLAMA { get { return _oDEME_TIPI_ACIKLAMA; } set { if (!Equals(value, _oDEME_TIPI_ACIKLAMA)) { _oDEME_TIPI_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.ODEME_TIPI_ACIKLAMA);} } }
    	private string _oDEME_TIPI_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
