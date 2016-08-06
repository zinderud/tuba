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
     
     
     
     
     
     
     
     
     
    public partial class TBL_SPARISDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SPARIS_ID { get { return _tBL_SPARIS_ID; } set { if (!Equals(value, _tBL_SPARIS_ID)) { _tBL_SPARIS_ID = value; } } }
    	private int _tBL_SPARIS_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SPARIS_TURU_ID { get { return _tBL_SPARIS_TURU_ID; } set { if (!Equals(value, _tBL_SPARIS_TURU_ID)) { _tBL_SPARIS_TURU_ID = value; } } }
    	private Nullable<int> _tBL_SPARIS_TURU_ID;
    
    	
     	[DataMember]
        public string SPARIS_TARIH { get { return _sPARIS_TARIH; } set { if (!Equals(value, _sPARIS_TARIH)) { _sPARIS_TARIH = value; } } }
    	private string _sPARIS_TARIH;
    
    	
     	[DataMember]
        public string SPARIS_VADE_TARIH { get { return _sPARIS_VADE_TARIH; } set { if (!Equals(value, _sPARIS_VADE_TARIH)) { _sPARIS_VADE_TARIH = value; } } }
    	private string _sPARIS_VADE_TARIH;
    
    	
     	[DataMember]
        public string SPARIS_FATURA_SERI_NO { get { return _sPARIS_FATURA_SERI_NO; } set { if (!Equals(value, _sPARIS_FATURA_SERI_NO)) { _sPARIS_FATURA_SERI_NO = value; } } }
    	private string _sPARIS_FATURA_SERI_NO;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_ODEME_TIPI_ID { get { return _tBL_ODEME_TIPI_ID; } set { if (!Equals(value, _tBL_ODEME_TIPI_ID)) { _tBL_ODEME_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_ODEME_TIPI_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_KASA_ID { get { return _tBL_KASA_ID; } set { if (!Equals(value, _tBL_KASA_ID)) { _tBL_KASA_ID = value; } } }
    	private Nullable<int> _tBL_KASA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_DEPO_ID { get { return _tBL_DEPO_ID; } set { if (!Equals(value, _tBL_DEPO_ID)) { _tBL_DEPO_ID = value; } } }
    	private Nullable<int> _tBL_DEPO_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PERSONEL_ID { get { return _tBL_PERSONEL_ID; } set { if (!Equals(value, _tBL_PERSONEL_ID)) { _tBL_PERSONEL_ID = value; } } }
    	private Nullable<int> _tBL_PERSONEL_ID;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
