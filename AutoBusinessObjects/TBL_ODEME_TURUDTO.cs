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
     
    public partial class TBL_ODEME_TURUDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_ODEME_TURU_ID { get { return _tBL_ODEME_TURU_ID; } set { if (!Equals(value, _tBL_ODEME_TURU_ID)) { _tBL_ODEME_TURU_ID = value; } } }
    	private int _tBL_ODEME_TURU_ID;
    
    	
     	[DataMember]
        public string ODEME_TURU_ADI { get { return _oDEME_TURU_ADI; } set { if (!Equals(value, _oDEME_TURU_ADI)) { _oDEME_TURU_ADI = value; } } }
    	private string _oDEME_TURU_ADI;
    
    	
     	[DataMember]
        public string ODEME_TURU_ACIKLAMA { get { return _oDEME_TURU_ACIKLAMA; } set { if (!Equals(value, _oDEME_TURU_ACIKLAMA)) { _oDEME_TURU_ACIKLAMA = value; } } }
    	private string _oDEME_TURU_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
