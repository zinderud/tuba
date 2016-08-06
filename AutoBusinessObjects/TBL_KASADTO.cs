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
     
     
     
     
     
    public partial class TBL_KASADTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value; } } }
    	private int _tBL_KASA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public string KASA_ADI { get { return _kASA_ADI; } set { if (!Equals(value, _kASA_ADI)) { _kASA_ADI = value; } } }
    	private string _kASA_ADI;
    
    	
     	[DataMember]
        public string KASA_ACIKLAMA { get { return _kASA_ACIKLAMA; } set { if (!Equals(value, _kASA_ACIKLAMA)) { _kASA_ACIKLAMA = value; } } }
    	private string _kASA_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
