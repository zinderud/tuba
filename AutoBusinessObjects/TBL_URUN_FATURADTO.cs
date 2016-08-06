//===================================================================================
// sade
//===================================================================================

#region


using System.Runtime.Serialization;

#endregion

namespace AutoBusinessObjects
{
    using System;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
     
     
    public partial class TBL_URUN_FATURADTO 
    {
    	
     	[DataMember]
        public int TBL_URUN_FATURA_ID { get { return _tBL_URUN_FATURA_ID; } set { if (!Equals(value, _tBL_URUN_FATURA_ID)) { _tBL_URUN_FATURA_ID = value; } } }
    	private int _tBL_URUN_FATURA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; } } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_FATURA_ID { get { return _tBL_FATURA_ID; } set { if (!Equals(value, _tBL_FATURA_ID)) { _tBL_FATURA_ID = value; } } }
    	private Nullable<int> _tBL_FATURA_ID;
    
    	
     	[DataMember]
        public string URUN_FATURA_MIKTAR { get { return _uRUN_FATURA_MIKTAR; } set { if (!Equals(value, _uRUN_FATURA_MIKTAR)) { _uRUN_FATURA_MIKTAR = value; } } }
    	private string _uRUN_FATURA_MIKTAR;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
