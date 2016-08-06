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
     
     
     
     
     
     
     
     
     
     
     
    public partial class TBL_URUNDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; } } }
    	private int _tBL_URUN_ID;
    
    	
     	[DataMember]
        public string URUN_ADI { get { return _uRUN_ADI; } set { if (!Equals(value, _uRUN_ADI)) { _uRUN_ADI = value; } } }
    	private string _uRUN_ADI;
    
    	
     	[DataMember]
        public string URUN_KODU { get { return _uRUN_KODU; } set { if (!Equals(value, _uRUN_KODU)) { _uRUN_KODU = value; } } }
    	private string _uRUN_KODU;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_TIPI_ID { get { return _tBL_URUN_TIPI_ID; } set { if (!Equals(value, _tBL_URUN_TIPI_ID)) { _tBL_URUN_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_URUN_TIPI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_CINSI_ID { get { return _tBL_URUN_CINSI_ID; } set { if (!Equals(value, _tBL_URUN_CINSI_ID)) { _tBL_URUN_CINSI_ID = value; } } }
    	private Nullable<int> _tBL_URUN_CINSI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_MARKA_ID { get { return _tBL_URUN_MARKA_ID; } set { if (!Equals(value, _tBL_URUN_MARKA_ID)) { _tBL_URUN_MARKA_ID = value; } } }
    	private Nullable<int> _tBL_URUN_MARKA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_BIRIM_ID { get { return _tBL_URUN_BIRIM_ID; } set { if (!Equals(value, _tBL_URUN_BIRIM_ID)) { _tBL_URUN_BIRIM_ID = value; } } }
    	private Nullable<int> _tBL_URUN_BIRIM_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_KDV_ID { get { return _tBL_KDV_ID; } set { if (!Equals(value, _tBL_KDV_ID)) { _tBL_KDV_ID = value; } } }
    	private Nullable<int> _tBL_KDV_ID;
    
    	
     	[DataMember]
        public string URUN_DURUM { get { return _uRUN_DURUM; } set { if (!Equals(value, _uRUN_DURUM)) { _uRUN_DURUM = value; } } }
    	private string _uRUN_DURUM;
    
    	
     	[DataMember]
        public string URUN_ALIS_FIYATI { get { return _uRUN_ALIS_FIYATI; } set { if (!Equals(value, _uRUN_ALIS_FIYATI)) { _uRUN_ALIS_FIYATI = value; } } }
    	private string _uRUN_ALIS_FIYATI;
    
    	
     	[DataMember]
        public string URUN_SATIS_FIYATI { get { return _uRUN_SATIS_FIYATI; } set { if (!Equals(value, _uRUN_SATIS_FIYATI)) { _uRUN_SATIS_FIYATI = value; } } }
    	private string _uRUN_SATIS_FIYATI;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
