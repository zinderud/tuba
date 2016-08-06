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
     
     
    public partial class TBL_GIDERDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_GIDER_ID { get { return _tBL_GIDER_ID; } set { if (!Equals(value, _tBL_GIDER_ID)) { _tBL_GIDER_ID = value; } } }
    	private int _tBL_GIDER_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public string GİDER_ADI { get { return _gİDER_ADI; } set { if (!Equals(value, _gİDER_ADI)) { _gİDER_ADI = value; } } }
    	private string _gİDER_ADI;
    
    	
     	[DataMember]
        public string GİDER_ACIKLAMA { get { return _gİDER_ACIKLAMA; } set { if (!Equals(value, _gİDER_ACIKLAMA)) { _gİDER_ACIKLAMA = value; } } }
    	private string _gİDER_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
