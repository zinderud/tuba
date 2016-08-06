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
     
     
     
     
    public partial class TBL_DEPODTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value; } } }
    	private int _tBL_DEPO_ID;
    
    	
     	[DataMember]
        public string DEPO_ADI { get { return _dEPO_ADI; } set { if (!Equals(value, _dEPO_ADI)) { _dEPO_ADI = value; } } }
    	private string _dEPO_ADI;
    
    	
     	[DataMember]
        public string DEPO_ACIKLAMA { get { return _dEPO_ACIKLAMA; } set { if (!Equals(value, _dEPO_ACIKLAMA)) { _dEPO_ACIKLAMA = value; } } }
    	private string _dEPO_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
