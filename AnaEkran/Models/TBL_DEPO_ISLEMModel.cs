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
    
    public partial class TBL_DEPO_ISLEM_MODEL  :ModelBase<TBL_DEPO_ISLEM_MODEL>
    {
    	 
        public  int  TBL_DEPO_ISLEM_ID { get { return _tBL_DEPO_ISLEM_ID; } set { if (!Equals(value, _tBL_DEPO_ISLEM_ID)) { _tBL_DEPO_ISLEM_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_ISLEM_ID);} } }
    	private  int  _tBL_DEPO_ISLEM_ID;
    
    	 
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_ID);} } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	 
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	 
        public string DEPO_ISLEM_ADI { get { return _dEPO_ISLEM_ADI; } set { if (!Equals(value, _dEPO_ISLEM_ADI)) { _dEPO_ISLEM_ADI = value;  NotifyPropertyChanged(m=>m.DEPO_ISLEM_ADI);} } }
    	private string _dEPO_ISLEM_ADI;
    
    	 
        public string URUN_MIKTAR { get { return _uRUN_MIKTAR; } set { if (!Equals(value, _uRUN_MIKTAR)) { _uRUN_MIKTAR = value;  NotifyPropertyChanged(m=>m.URUN_MIKTAR);} } }
    	private string _uRUN_MIKTAR;
    
    	 
        public string DEPO_ONAY { get { return _dEPO_ONAY; } set { if (!Equals(value, _dEPO_ONAY)) { _dEPO_ONAY = value;  NotifyPropertyChanged(m=>m.DEPO_ONAY);} } }
    	private string _dEPO_ONAY;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
