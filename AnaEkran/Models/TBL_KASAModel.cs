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
    
    public partial class TBL_KASA_MODEL  :ModelBase<TBL_KASA_MODEL>
    {
    	 
        public  int  TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value;  NotifyPropertyChanged(m=>m.TBL_KASA_ID);} } }
    	private  int  _tBL_KASA_ID;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public string KASA_ADI { get { return _kASA_ADI; } set { if (!Equals(value, _kASA_ADI)) { _kASA_ADI = value;  NotifyPropertyChanged(m=>m.KASA_ADI);} } }
    	private string _kASA_ADI;
    
    	 
        public string KASA_ACIKLAMA { get { return _kASA_ACIKLAMA; } set { if (!Equals(value, _kASA_ACIKLAMA)) { _kASA_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.KASA_ACIKLAMA);} } }
    	private string _kASA_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
