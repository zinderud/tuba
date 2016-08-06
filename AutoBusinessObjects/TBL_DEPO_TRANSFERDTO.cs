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
     
    public partial class TBL_DEPO_TRANSFERDTO 
    {
    	
     	[DataMember]
        public int TBL_DEPO_TRANSFER_ID { get { return _tBL_DEPO_TRANSFER_ID; } set { if (!Equals(value, _tBL_DEPO_TRANSFER_ID)) { _tBL_DEPO_TRANSFER_ID = value; } } }
    	private int _tBL_DEPO_TRANSFER_ID;
    
    	
     	[DataMember]
        public string DEPO_TRANSFER_ADI { get { return _dEPO_TRANSFER_ADI; } set { if (!Equals(value, _dEPO_TRANSFER_ADI)) { _dEPO_TRANSFER_ADI = value; } } }
    	private string _dEPO_TRANSFER_ADI;
    
    	
     	[DataMember]
        public string DEPO_TRANSFER_TARIHI { get { return _dEPO_TRANSFER_TARIHI; } set { if (!Equals(value, _dEPO_TRANSFER_TARIHI)) { _dEPO_TRANSFER_TARIHI = value; } } }
    	private string _dEPO_TRANSFER_TARIHI;
    
    	
     	[DataMember]
        public string DEPO_TRANSFER_NEREDEN { get { return _dEPO_TRANSFER_NEREDEN; } set { if (!Equals(value, _dEPO_TRANSFER_NEREDEN)) { _dEPO_TRANSFER_NEREDEN = value; } } }
    	private string _dEPO_TRANSFER_NEREDEN;
    
    	
     	[DataMember]
        public string DEPO_TRANSFER_NEREYE { get { return _dEPO_TRANSFER_NEREYE; } set { if (!Equals(value, _dEPO_TRANSFER_NEREYE)) { _dEPO_TRANSFER_NEREYE = value; } } }
    	private string _dEPO_TRANSFER_NEREYE;
    
    	
     	[DataMember]
        public Nullable<int> TBL_URUN_ID { get { return _tBL_URUN_ID; } set { if (!Equals(value, _tBL_URUN_ID)) { _tBL_URUN_ID = value; } } }
    	private Nullable<int> _tBL_URUN_ID;
    
    	
     	[DataMember]
        public string DEPO_TRANSFER_ACIKLAMA { get { return _dEPO_TRANSFER_ACIKLAMA; } set { if (!Equals(value, _dEPO_TRANSFER_ACIKLAMA)) { _dEPO_TRANSFER_ACIKLAMA = value; } } }
    	private string _dEPO_TRANSFER_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
