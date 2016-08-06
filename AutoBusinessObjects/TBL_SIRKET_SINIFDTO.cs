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
     
    public partial class TBL_SIRKET_SINIFDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SIRKET_SINIF_ID { get { return _tBL_SIRKET_SINIF_ID; } set { if (!Equals(value, _tBL_SIRKET_SINIF_ID)) { _tBL_SIRKET_SINIF_ID = value; } } }
    	private int _tBL_SIRKET_SINIF_ID;
    
    	
     	[DataMember]
        public string SIRKET_SINIF_ADI { get { return _sIRKET_SINIF_ADI; } set { if (!Equals(value, _sIRKET_SINIF_ADI)) { _sIRKET_SINIF_ADI = value; } } }
    	private string _sIRKET_SINIF_ADI;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
