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
     
    public partial class TBL_KDVDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_KDV_ID { get { return _tBL_KDV_ID; } set { if (!Equals(value, _tBL_KDV_ID)) { _tBL_KDV_ID = value; } } }
    	private int _tBL_KDV_ID;
    
    	
     	[DataMember]
        public Nullable<int> KDV_YUZDESI { get { return _kDV_YUZDESI; } set { if (!Equals(value, _kDV_YUZDESI)) { _kDV_YUZDESI = value; } } }
    	private Nullable<int> _kDV_YUZDESI;
    
    	
     	[DataMember]
        public string KDV_ACIKLAMA { get { return _kDV_ACIKLAMA; } set { if (!Equals(value, _kDV_ACIKLAMA)) { _kDV_ACIKLAMA = value; } } }
    	private string _kDV_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
