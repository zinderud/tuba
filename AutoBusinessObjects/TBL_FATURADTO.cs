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
     
     
     
     
     
     
     
     
     
    public partial class TBL_FATURADTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_FATURA_ID { get { return _tBL_FATURA_ID; } set { if (!Equals(value, _tBL_FATURA_ID)) { _tBL_FATURA_ID = value; } } }
    	private int _tBL_FATURA_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_FATURA_TURU_ID { get { return _tBL_FATURA_TURU_ID; } set { if (!Equals(value, _tBL_FATURA_TURU_ID)) { _tBL_FATURA_TURU_ID = value; } } }
    	private Nullable<int> _tBL_FATURA_TURU_ID;
    
    	
     	[DataMember]
        public string FATURA_TARIH { get { return _fATURA_TARIH; } set { if (!Equals(value, _fATURA_TARIH)) { _fATURA_TARIH = value; } } }
    	private string _fATURA_TARIH;
    
    	
     	[DataMember]
        public string FATURA_VADE_TARIH { get { return _fATURA_VADE_TARIH; } set { if (!Equals(value, _fATURA_VADE_TARIH)) { _fATURA_VADE_TARIH = value; } } }
    	private string _fATURA_VADE_TARIH;
    
    	
     	[DataMember]
        public string FATURA_FATURA_SERI_NO { get { return _fATURA_FATURA_SERI_NO; } set { if (!Equals(value, _fATURA_FATURA_SERI_NO)) { _fATURA_FATURA_SERI_NO = value; } } }
    	private string _fATURA_FATURA_SERI_NO;
    
    	
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
        public string ACIKLAMA { get { return _aCIKLAMA; } set { if (!Equals(value, _aCIKLAMA)) { _aCIKLAMA = value; } } }
    	private string _aCIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SPARIS_ID { get { return _tBL_SPARIS_ID; } set { if (!Equals(value, _tBL_SPARIS_ID)) { _tBL_SPARIS_ID = value; } } }
    	private Nullable<int> _tBL_SPARIS_ID;
    
    
    }
}
