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
     
    public partial class TBL_URUN_BIRIMDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_URUN_BIRIM_ID { get { return _tBL_URUN_BIRIM_ID; } set { if (!Equals(value, _tBL_URUN_BIRIM_ID)) { _tBL_URUN_BIRIM_ID = value; } } }
    	private int _tBL_URUN_BIRIM_ID;
    
    	
     	[DataMember]
        public string URUN_BIRIM_ADI { get { return _uRUN_BIRIM_ADI; } set { if (!Equals(value, _uRUN_BIRIM_ADI)) { _uRUN_BIRIM_ADI = value; } } }
    	private string _uRUN_BIRIM_ADI;
    
    	
     	[DataMember]
        public string URUN_BIRIM_ACIKLAMA { get { return _uRUN_BIRIM_ACIKLAMA; } set { if (!Equals(value, _uRUN_BIRIM_ACIKLAMA)) { _uRUN_BIRIM_ACIKLAMA = value; } } }
    	private string _uRUN_BIRIM_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
