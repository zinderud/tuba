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
     
     
     
    public partial class TBL_ODEME_TIPIDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value; } } }
    	private int _tBL_ODEME_TIPI_ID;
    
    	
     	[DataMember]
        public string ODEME_TIPI_ADI { get { return _oDEME_TIPI_ADI; } set { if (!Equals(value, _oDEME_TIPI_ADI)) { _oDEME_TIPI_ADI = value; } } }
    	private string _oDEME_TIPI_ADI;
    
    	
     	[DataMember]
        public string ODEME_TIPI_ACIKLAMA { get { return _oDEME_TIPI_ACIKLAMA; } set { if (!Equals(value, _oDEME_TIPI_ACIKLAMA)) { _oDEME_TIPI_ACIKLAMA = value; } } }
    	private string _oDEME_TIPI_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
