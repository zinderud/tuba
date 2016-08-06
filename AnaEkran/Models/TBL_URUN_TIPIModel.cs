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
    
    public partial class TBL_URUN_TIPI_MODEL  :ModelBase<TBL_URUN_TIPI_MODEL>
    {
    	 
        public  int  TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_TIPI_ID);} } }
    	private  int  _tBL_URUN_TIPI_ID;
    
    	 
        public string URUN_TIPI_ADI { get { return _uRUN_TIPI_ADI; } set { if (!Equals(value, _uRUN_TIPI_ADI)) { _uRUN_TIPI_ADI = value;  NotifyPropertyChanged(m=>m.URUN_TIPI_ADI);} } }
    	private string _uRUN_TIPI_ADI;
    
    	 
        public string URUN_TIPI_ACIKLAMA { get { return _uRUN_TIPI_ACIKLAMA; } set { if (!Equals(value, _uRUN_TIPI_ACIKLAMA)) { _uRUN_TIPI_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.URUN_TIPI_ACIKLAMA);} } }
    	private string _uRUN_TIPI_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
