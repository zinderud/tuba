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
     
     
     
     
     
    public partial class TBL_ODEMEDTO 
    {
    	
     	[DataMember]
        public int TBL_ODEME_ID { get { return _tBL_ODEME_ID; } set { if (!Equals(value, _tBL_ODEME_ID)) { _tBL_ODEME_ID = value; } } }
    	private int _tBL_ODEME_ID;
    
    	
     	[DataMember]
        public string ODEME_KAYIT_TARIHI { get { return _oDEME_KAYIT_TARIHI; } set { if (!Equals(value, _oDEME_KAYIT_TARIHI)) { _oDEME_KAYIT_TARIHI = value; } } }
    	private string _oDEME_KAYIT_TARIHI;
    
    	
     	[DataMember]
        public string ODEME_VADE_TARIHI { get { return _oDEME_VADE_TARIHI; } set { if (!Equals(value, _oDEME_VADE_TARIHI)) { _oDEME_VADE_TARIHI = value; } } }
    	private string _oDEME_VADE_TARIHI;
    
    	
     	[DataMember]
        public Nullable<int> TBL_ODEME_TURU_ID { get { return _tBL_ODEME_TURU_ID; } set { if (!Equals(value, _tBL_ODEME_TURU_ID)) { _tBL_ODEME_TURU_ID = value; } } }
    	private Nullable<int> _tBL_ODEME_TURU_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_ODEME_TIPI_ID;
    
    	
     	[DataMember]
        public string BELGE_NO { get { return _bELGE_NO; } set { if (!Equals(value, _bELGE_NO)) { _bELGE_NO = value; } } }
    	private string _bELGE_NO;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	
     	[DataMember]
        public string TUTAR { get { return _tUTAR; } set { if (!Equals(value, _tUTAR)) { _tUTAR = value; } } }
    	private string _tUTAR;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value; } } }
    	private Nullable<int> _tBL_KASA_ID;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
