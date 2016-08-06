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
    
    public partial class TBL_DEPO_TRANSFER_MODEL  :ModelBase<TBL_DEPO_TRANSFER_MODEL>
    {
    	 
        public  int  TBL_DEPO_TRANSFER_ID { get { return _tBL_DEPO_TRANSFER_ID; } set { if (!Equals(value, _tBL_DEPO_TRANSFER_ID)) { _tBL_DEPO_TRANSFER_ID = value;  NotifyPropertyChanged(m=>m.TBL_DEPO_TRANSFER_ID);} } }
    	private  int  _tBL_DEPO_TRANSFER_ID;
    
    	 
        public string DEPO_TRANSFER_ADI { get { return _dEPO_TRANSFER_ADI; } set { if (!Equals(value, _dEPO_TRANSFER_ADI)) { _dEPO_TRANSFER_ADI = value;  NotifyPropertyChanged(m=>m.DEPO_TRANSFER_ADI);} } }
    	private string _dEPO_TRANSFER_ADI;
    
    	 
        public string DEPO_TRANSFER_TARIHI { get { return _dEPO_TRANSFER_TARIHI; } set { if (!Equals(value, _dEPO_TRANSFER_TARIHI)) { _dEPO_TRANSFER_TARIHI = value;  NotifyPropertyChanged(m=>m.DEPO_TRANSFER_TARIHI);} } }
    	private string _dEPO_TRANSFER_TARIHI;
    
    	 
        public string DEPO_TRANSFER_NEREDEN { get { return _dEPO_TRANSFER_NEREDEN; } set { if (!Equals(value, _dEPO_TRANSFER_NEREDEN)) { _dEPO_TRANSFER_NEREDEN = value;  NotifyPropertyChanged(m=>m.DEPO_TRANSFER_NEREDEN);} } }
    	private string _dEPO_TRANSFER_NEREDEN;
    
    	 
        public string DEPO_TRANSFER_NEREYE { get { return _dEPO_TRANSFER_NEREYE; } set { if (!Equals(value, _dEPO_TRANSFER_NEREYE)) { _dEPO_TRANSFER_NEREYE = value;  NotifyPropertyChanged(m=>m.DEPO_TRANSFER_NEREYE);} } }
    	private string _dEPO_TRANSFER_NEREYE;
    
    	 
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value;  NotifyPropertyChanged(m=>m.TBL_URUN_ID);} } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	 
        public string DEPO_TRANSFER_ACIKLAMA { get { return _dEPO_TRANSFER_ACIKLAMA; } set { if (!Equals(value, _dEPO_TRANSFER_ACIKLAMA)) { _dEPO_TRANSFER_ACIKLAMA = value;  NotifyPropertyChanged(m=>m.DEPO_TRANSFER_ACIKLAMA);} } }
    	private string _dEPO_TRANSFER_ACIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
