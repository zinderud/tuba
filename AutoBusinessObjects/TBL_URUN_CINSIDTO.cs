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
     
     
     
    public partial class TBL_URUN_CINSIDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_URUN_CINSI_ID { get { return _tBL_URUN_CINSI_ID; } set { if (!Equals(value, _tBL_URUN_CINSI_ID)) { _tBL_URUN_CINSI_ID = value; } } }
    	private int _tBL_URUN_CINSI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_URUN_TIPI_ID;
    
    	
     	[DataMember]
        public string URUN_CINSI_ADI { get { return _uRUN_CINSI_ADI; } set { if (!Equals(value, _uRUN_CINSI_ADI)) { _uRUN_CINSI_ADI = value; } } }
    	private string _uRUN_CINSI_ADI;
    
    	
     	[DataMember]
        public string URUN_CINSI_ACIKLAMA { get { return _uRUN_CINSI_ACIKLAMA; } set { if (!Equals(value, _uRUN_CINSI_ACIKLAMA)) { _uRUN_CINSI_ACIKLAMA = value; } } }
    	private string _uRUN_CINSI_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
