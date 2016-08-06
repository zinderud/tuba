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
    
    public partial class TBL_ODEME_MODEL  :ModelBase<TBL_ODEME_MODEL>
    {
    	 
        public  int  TBL_ODEME_ID { get { return _tBL_ODEME_ID; } set { if (!Equals(value, _tBL_ODEME_ID)) { _tBL_ODEME_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_ID);} } }
    	private  int  _tBL_ODEME_ID;
    
    	 
        public string ODEME_KAYIT_TARIHI { get { return _oDEME_KAYIT_TARIHI; } set { if (!Equals(value, _oDEME_KAYIT_TARIHI)) { _oDEME_KAYIT_TARIHI = value;  NotifyPropertyChanged(m=>m.ODEME_KAYIT_TARIHI);} } }
    	private string _oDEME_KAYIT_TARIHI;
    
    	 
        public string ODEME_VADE_TARIHI { get { return _oDEME_VADE_TARIHI; } set { if (!Equals(value, _oDEME_VADE_TARIHI)) { _oDEME_VADE_TARIHI = value;  NotifyPropertyChanged(m=>m.ODEME_VADE_TARIHI);} } }
    	private string _oDEME_VADE_TARIHI;
    
    	 
        public Nullable<int> TBL_ODEME_TURU_ID { get { return _tBL_ODEME_TURU_ID; } set { if (!Equals(value, _tBL_ODEME_TURU_ID)) { _tBL_ODEME_TURU_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_TURU_ID);} } }
    	private Nullable<int> _tBL_ODEME_TURU_ID;
    
    	 
        public Nullable<int> TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_ODEME_TIPI_ID);} } }
    	private Nullable<int> _tBL_ODEME_TIPI_ID;
    
    	 
        public string BELGE_NO { get { return _bELGE_NO; } set { if (!Equals(value, _bELGE_NO)) { _bELGE_NO = value;  NotifyPropertyChanged(m=>m.BELGE_NO);} } }
    	private string _bELGE_NO;
    
    	 
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value;  NotifyPropertyChanged(m=>m.TBL_SIRKET_ID);} } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	 
        public string TUTAR { get { return _tUTAR; } set { if (!Equals(value, _tUTAR)) { _tUTAR = value;  NotifyPropertyChanged(m=>m.TUTAR);} } }
    	private string _tUTAR;
    
    	 
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value;  NotifyPropertyChanged(m=>m.TBL_PARA_TIPI_ID);} } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	 
        public Nullable<int> TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value;  NotifyPropertyChanged(m=>m.TBL_KASA_ID);} } }
    	private Nullable<int> _tBL_KASA_ID;
    
    	 
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value;  NotifyPropertyChanged(m=>m.YEDEK);} } }
    	private string _yEDEK;
    
    
    
    }
}
