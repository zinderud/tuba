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
    
    public partial class TBL_SIRKET_GRUB_MODEL  :ModelBase<TBL_SIRKET_GRUB_MODEL>
    {
    	 
        public  int  TBL_SIRKET_GRUB_ID { get { return _tBL_SIRKET_GRUB_ID; } set { if (!Equals(value, _tBL_SIRKET_GRUB_ID)) { _tBL_SIRKET_GRUB_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_GRUB_ID);} } }
    	private  int  _tBL_SIRKET_GRUB_ID;
    
    	 
        public string SIRKET_GRUP_ADI { get { return _sIRKET_GRUP_ADI; } set { if (!Equals(value, _sIRKET_GRUP_ADI)) { _sIRKET_GRUP_ADI = value;  NotifyPropertyChanged(m=>m.SIRKET_GRUP_ADI);} } }
    	private string _sIRKET_GRUP_ADI;
    
    	 
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value;  NotifyPropertyChanged(m=>m.ACIKLAMA);} } }
    	private string _aCIKLAMA;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
