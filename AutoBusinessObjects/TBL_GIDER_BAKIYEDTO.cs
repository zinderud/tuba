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
     
     
     
    public partial class TBL_GIDER_BAKIYEDTO 
    {
    	
     	[DataMember]
        public int TBL_GIDER_BAKIYE_ID { get { return _tBL_GIDER_BAKIYE_ID; } set { if (!Equals(value, _tBL_GIDER_BAKIYE_ID)) { _tBL_GIDER_BAKIYE_ID = value; } } }
    	private int _tBL_GIDER_BAKIYE_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_GIDER_ID { get { return _tBL_GIDER_ID; } set { if (!Equals(value, _tBL_GIDER_ID)) { _tBL_GIDER_ID = value; } } }
    	private Nullable<int> _tBL_GIDER_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_FIS_ID { get { return _tBL_FIS_ID; } set { if (!Equals(value, _tBL_FIS_ID)) { _tBL_FIS_ID = value; } } }
    	private Nullable<int> _tBL_FIS_ID;
    
    	
     	[DataMember]
        public string KUR { get { return _kUR; } set { if (!Equals(value, _kUR)) { _kUR = value; } } }
    	private string _kUR;
    
    	
     	[DataMember]
        public string TARIH { get { return _tARIH; } set { if (!Equals(value, _tARIH)) { _tARIH = value; } } }
    	private string _tARIH;
    
    	
     	[DataMember]
        public string TUTAR { get { return _tUTAR; } set { if (!Equals(value, _tUTAR)) { _tUTAR = value; } } }
    	private string _tUTAR;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
