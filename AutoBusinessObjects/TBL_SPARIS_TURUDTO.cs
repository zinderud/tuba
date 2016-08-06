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
     
    public partial class TBL_SPARIS_TURUDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SPARIS_TURU_ID { get { return _tBL_SPARIS_TURU_ID; } set { if (!Equals(value, _tBL_SPARIS_TURU_ID)) { _tBL_SPARIS_TURU_ID = value; } } }
    	private int _tBL_SPARIS_TURU_ID;
    
    	
     	[DataMember]
        public string SPARIS_TURU_ADI { get { return _sPARIS_TURU_ADI; } set { if (!Equals(value, _sPARIS_TURU_ADI)) { _sPARIS_TURU_ADI = value; } } }
    	private string _sPARIS_TURU_ADI;
    
    	
     	[DataMember]
        public string SPARIS_TURU_ACIKLAMA { get { return _sPARIS_TURU_ACIKLAMA; } set { if (!Equals(value, _sPARIS_TURU_ACIKLAMA)) { _sPARIS_TURU_ACIKLAMA = value; } } }
    	private string _sPARIS_TURU_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
