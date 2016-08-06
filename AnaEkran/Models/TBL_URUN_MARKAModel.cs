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
    
    public partial class TBL_URUN_MARKA_MODEL  :ModelBase<TBL_URUN_MARKA_MODEL>
    {
    	 
        public  int  TBL_URUN_MARKA_ID { get { return _tBL_URUN_MARKA_ID; } set { if (!Equals(value, _tBL_URUN_MARKA_ID)) { _tBL_URUN_MARKA_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_MARKA_ID);} } }
    	private  int  _tBL_URUN_MARKA_ID;
    
    	 
        public Nullable<int> TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_TIPI_ID);} } }
    	private Nullable<int> _tBL_URUN_TIPI_ID;
    
    	 
        public  int  TBL_URUN_CINSI_ID { get { return _tBL_URUN_CINSI_ID; } set { if (!Equals(value, _tBL_URUN_CINSI_ID)) { _tBL_URUN_CINSI_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_CINSI_ID);} } }
    	private  int  _tBL_URUN_CINSI_ID;
    
    	 
        public string URUN_MARKA_ADI { get { return _uRUN_MARKA_ADI; } set { if (!Equals(value, _uRUN_MARKA_ADI)) { _uRUN_MARKA_ADI = value;  NotifyPropertyChanged(m=>m.URUN_MARKA_ADI);} } }
    	private string _uRUN_MARKA_ADI;
    
    	 
        public string URUN_MARKA_ACIKLAMA { get { return _uRUN_MARKA_ACIKLAMA; } set { if (!Equals(value, _uRUN_MARKA_ACIKLAMA)) { _uRUN_MARKA_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.URUN_MARKA_ACIKLAMA);} } }
    	private string _uRUN_MARKA_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
