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
    
    public partial class TBL_URUN_STOK_MODEL  :ModelBase<TBL_URUN_STOK_MODEL>
    {
    	 
        public  int  TBL_URUN_STOK_ID { get { return _tBL_URUN_STOK_ID; } set { if (!Equals(value, _tBL_URUN_STOK_ID)) { _tBL_URUN_STOK_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_STOK_ID);} } }
    	private  int  _tBL_URUN_STOK_ID;
    
    	 
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	 
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_ID);} } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	 
        public Nullable<int> URUN_BIRIM_MIKTARI { get { return _uRUN_BIRIM_MIKTARI; } set { if (!Equals(value, _uRUN_BIRIM_MIKTARI)) { _uRUN_BIRIM_MIKTARI = value;  NotifyPropertyChanged(m=>m.URUN_BIRIM_MIKTARI);} } }
    	private Nullable<int> _uRUN_BIRIM_MIKTARI;
    
    	 
        public string STOK_DURUM { get { return _sTOK_DURUM; } set { if (!Equals(value, _sTOK_DURUM)) { _sTOK_DURUM = value;  NotifyPropertyChanged(m=>m.STOK_DURUM);} } }
    	private string _sTOK_DURUM;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
