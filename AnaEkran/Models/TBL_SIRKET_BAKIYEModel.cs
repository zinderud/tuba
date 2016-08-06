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
    
    public partial class TBL_SIRKET_BAKIYE_MODEL  :ModelBase<TBL_SIRKET_BAKIYE_MODEL>
    {
    	 
        public  int  TBL_SIRKET_BAKIYE_ID { get { return _tBL_SIRKET_BAKIYE_ID; } set { if (!Equals(value, _tBL_SIRKET_BAKIYE_ID)) { _tBL_SIRKET_BAKIYE_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_BAKIYE_ID);} } }
    	private  int  _tBL_SIRKET_BAKIYE_ID;
    
    	 
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_ID);} } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public Nullable<int> TBL_FIS_ID { get { return _tBL_FIS_ID; } set { if (!Equals(value, _tBL_FIS_ID)) { _tBL_FIS_ID = value;  NotifyPropertyChanged(m=>m.TBL_FIS_ID);} } }
    	private Nullable<int> _tBL_FIS_ID;
    
    	 
        public string KUR { get { return _kUR; } set { if (!Equals(value, _kUR)) { _kUR = value;  NotifyPropertyChanged(m=>m.KUR);} } }
    	private string _kUR;
    
    	 
        public string TARIH { get { return _tARIH; } set { if (!Equals(value, _tARIH)) { _tARIH = value;  NotifyPropertyChanged(m=>m.TARIH);} } }
    	private string _tARIH;
    
    	 
        public string TUTAR { get { return _tUTAR; } set { if (!Equals(value, _tUTAR)) { _tUTAR = value;  NotifyPropertyChanged(m=>m.TUTAR);} } }
    	private string _tUTAR;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
