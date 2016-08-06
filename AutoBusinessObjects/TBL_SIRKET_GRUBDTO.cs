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
     
    public partial class TBL_SIRKET_GRUBDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SIRKET_GRUB_ID { get { return _tBL_SIRKET_GRUB_ID; } set { if (!Equals(value, _tBL_SIRKET_GRUB_ID)) { _tBL_SIRKET_GRUB_ID = value; } } }
    	private int _tBL_SIRKET_GRUB_ID;
    
    	
     	[DataMember]
        public string SIRKET_GRUP_ADI { get { return _sIRKET_GRUP_ADI; } set { if (!Equals(value, _sIRKET_GRUP_ADI)) { _sIRKET_GRUP_ADI = value; } } }
    	private string _sIRKET_GRUP_ADI;
    
    	
     	[DataMember]
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
