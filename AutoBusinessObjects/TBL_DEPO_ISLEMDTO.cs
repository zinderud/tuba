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
     
     
    public partial class TBL_DEPO_ISLEMDTO 
    {
    	
     	[DataMember]
        public int TBL_DEPO_ISLEM_ID { get { return _tBL_DEPO_ISLEM_ID; } set { if (!Equals(value, _tBL_DEPO_ISLEM_ID)) { _tBL_DEPO_ISLEM_ID = value; } } }
    	private int _tBL_DEPO_ISLEM_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value; } } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; } } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	
     	[DataMember]
        public string DEPO_ISLEM_ADI { get { return _dEPO_ISLEM_ADI; } set { if (!Equals(value, _dEPO_ISLEM_ADI)) { _dEPO_ISLEM_ADI = value; } } }
    	private string _dEPO_ISLEM_ADI;
    
    	
     	[DataMember]
        public string URUN_MIKTAR { get { return _uRUN_MIKTAR; } set { if (!Equals(value, _uRUN_MIKTAR)) { _uRUN_MIKTAR = value; } } }
    	private string _uRUN_MIKTAR;
    
    	
     	[DataMember]
        public string DEPO_ONAY { get { return _dEPO_ONAY; } set { if (!Equals(value, _dEPO_ONAY)) { _dEPO_ONAY = value; } } }
    	private string _dEPO_ONAY;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
