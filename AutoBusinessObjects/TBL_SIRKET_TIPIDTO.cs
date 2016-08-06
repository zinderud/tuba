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
     
    public partial class TBL_SIRKET_TIPIDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SIRKET_TIPI_ID { get { return _tBL_SIRKET_TIPI_ID; } set { if (!Equals(value, _tBL_SIRKET_TIPI_ID)) { _tBL_SIRKET_TIPI_ID = value; } } }
    	private int _tBL_SIRKET_TIPI_ID;
    
    	
     	[DataMember]
        public string SIRKET_TIPI_ADI { get { return _sIRKET_TIPI_ADI; } set { if (!Equals(value, _sIRKET_TIPI_ADI)) { _sIRKET_TIPI_ADI = value; } } }
    	private string _sIRKET_TIPI_ADI;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
