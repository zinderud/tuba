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
     
     
     
    public partial class TBL_URUN_MARKADTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_URUN_MARKA_ID { get { return _tBL_URUN_MARKA_ID; } set { if (!Equals(value, _tBL_URUN_MARKA_ID)) { _tBL_URUN_MARKA_ID = value; } } }
    	private int _tBL_URUN_MARKA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_URUN_TIPI_ID;
    
    	
     	[DataMember]
        public int TBL_URUN_CINSI_ID { get { return _tBL_URUN_CINSI_ID; } set { if (!Equals(value, _tBL_URUN_CINSI_ID)) { _tBL_URUN_CINSI_ID = value; } } }
    	private int _tBL_URUN_CINSI_ID;
    
    	
     	[DataMember]
        public string URUN_MARKA_ADI { get { return _uRUN_MARKA_ADI; } set { if (!Equals(value, _uRUN_MARKA_ADI)) { _uRUN_MARKA_ADI = value; } } }
    	private string _uRUN_MARKA_ADI;
    
    	
     	[DataMember]
        public string URUN_MARKA_ACIKLAMA { get { return _uRUN_MARKA_ACIKLAMA; } set { if (!Equals(value, _uRUN_MARKA_ACIKLAMA)) { _uRUN_MARKA_ACIKLAMA = value; } } }
    	private string _uRUN_MARKA_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
