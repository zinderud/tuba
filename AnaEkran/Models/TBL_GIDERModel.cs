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
    
    public partial class TBL_GIDER_MODEL  :ModelBase<TBL_GIDER_MODEL>
    {
    	 
        public  int  TBL_GIDER_ID { get { return _tBL_GIDER_ID; } set { if (!Equals(value, _tBL_GIDER_ID)) { _tBL_GIDER_ID = value;  NotifyPropertyChanged(m=>m.TBL_GIDER_ID);} } }
    	private  int  _tBL_GIDER_ID;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public string GİDER_ADI { get { return _gİDER_ADI; } set { if (!Equals(value, _gİDER_ADI)) { _gİDER_ADI = value;  NotifyPropertyChanged(m=>m.GİDER_ADI);} } }
    	private string _gİDER_ADI;
    
    	 
        public string GİDER_ACIKLAMA { get { return _gİDER_ACIKLAMA; } set { if (!Equals(value, _gİDER_ACIKLAMA)) { _gİDER_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.GİDER_ACIKLAMA);} } }
    	private string _gİDER_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
