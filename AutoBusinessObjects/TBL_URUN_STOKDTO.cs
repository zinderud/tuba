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
     
     
    public partial class TBL_URUN_STOKDTO 
    {
    	
     	[DataMember]
        public int TBL_URUN_STOK_ID { get { return _tBL_URUN_STOK_ID; } set { if (!Equals(value, _tBL_URUN_STOK_ID)) { _tBL_URUN_STOK_ID = value; } } }
    	private int _tBL_URUN_STOK_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; } } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value; } } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	
     	[DataMember]
        public Nullable<int> URUN_BIRIM_MIKTARI { get { return _uRUN_BIRIM_MIKTARI; } set { if (!Equals(value, _uRUN_BIRIM_MIKTARI)) { _uRUN_BIRIM_MIKTARI = value; } } }
    	private Nullable<int> _uRUN_BIRIM_MIKTARI;
    
    	
     	[DataMember]
        public string STOK_DURUM { get { return _sTOK_DURUM; } set { if (!Equals(value, _sTOK_DURUM)) { _sTOK_DURUM = value; } } }
    	private string _sTOK_DURUM;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
