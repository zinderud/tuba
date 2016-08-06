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
     
     
     
     
    public partial class TBL_FISDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_FIS_ID { get { return _tBL_FIS_ID; } set { if (!Equals(value, _tBL_FIS_ID)) { _tBL_FIS_ID = value; } } }
    	private int _tBL_FIS_ID;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
