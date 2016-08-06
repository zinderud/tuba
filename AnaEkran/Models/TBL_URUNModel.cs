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
    
    public partial class TBL_URUN_MODEL  :ModelBase<TBL_URUN_MODEL>
    {
    	 
        public  int  TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private  int  _tBL_URUN_ID;
    
    	 
        public string URUN_ADI { get { return _uRUN_ADI; } set { if (!Equals(value, _uRUN_ADI)) { _uRUN_ADI = value;  NotifyPropertyChanged(m=>m.URUN_ADI);} } }
    	private string _uRUN_ADI;
    
    	 
        public string URUN_KODU { get { return _uRUN_KODU; } set { if (!Equals(value, _uRUN_KODU)) { _uRUN_KODU = value;  NotifyPropertyChanged(m=>m.URUN_KODU);} } }
    	private string _uRUN_KODU;
    
    	 
        public Nullable<int> TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_TIPI_ID);} } }
    	private Nullable<int> _tBL_URUN_TIPI_ID;
    
    	 
        public Nullable<int> TBL_URUN_CINSI_ID { get { return _tBL_URUN_CINSI_ID; } set { if (!Equals(value, _tBL_URUN_CINSI_ID)) { _tBL_URUN_CINSI_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_CINSI_ID);} } }
    	private Nullable<int> _tBL_URUN_CINSI_ID;
    
    	 
        public Nullable<int> TBL_URUN_MARKA_ID { get { return _tBL_URUN_MARKA_ID; } set { if (!Equals(value, _tBL_URUN_MARKA_ID)) { _tBL_URUN_MARKA_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_MARKA_ID);} } }
    	private Nullable<int> _tBL_URUN_MARKA_ID;
    
    	 
        public Nullable<int> TBL_URUN_BIRIM_ID { get { return _tBL_URUN_BIRIM_ID; } set { if (!Equals(value, _tBL_URUN_BIRIM_ID)) { _tBL_URUN_BIRIM_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_BIRIM_ID);} } }
    	private Nullable<int> _tBL_URUN_BIRIM_ID;
    
    	 
        public Nullable<int> TBL_KDV_ID { get { return _tBL_KDV_ID; } set { if (!Equals(value, _tBL_KDV_ID)) { _tBL_KDV_ID = value;  NotifyPropertyChanged(m=>m.TBL_KDV_ID);} } }
    	private Nullable<int> _tBL_KDV_ID;
    
    	 
        public string URUN_DURUM { get { return _uRUN_DURUM; } set { if (!Equals(value, _uRUN_DURUM)) { _uRUN_DURUM = value;  NotifyPropertyChanged(m=>m.URUN_DURUM);} } }
    	private string _uRUN_DURUM;
    
    	 
        public string URUN_ALIS_FIYATI { get { return _uRUN_ALIS_FIYATI; } set { if (!Equals(value, _uRUN_ALIS_FIYATI)) { _uRUN_ALIS_FIYATI = value;  NotifyPropertyChanged(m=>m.URUN_ALIS_FIYATI);} } }
    	private string _uRUN_ALIS_FIYATI;
    
    	 
        public string URUN_SATIS_FIYATI { get { return _uRUN_SATIS_FIYATI; } set { if (!Equals(value, _uRUN_SATIS_FIYATI)) { _uRUN_SATIS_FIYATI = value;  NotifyPropertyChanged(m=>m.URUN_SATIS_FIYATI);} } }
    	private string _uRUN_SATIS_FIYATI;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
