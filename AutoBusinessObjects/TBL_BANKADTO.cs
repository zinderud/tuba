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
     
     
    public partial class TBL_BANKADTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_BANKA_ID { get { return _tBL_BANKA_ID; } set { if (!Equals(value, _tBL_BANKA_ID)) { _tBL_BANKA_ID = value; } } }
    	private int _tBL_BANKA_ID;
    
    	
     	[DataMember]
        public string BANKA_ADI { get { return _bANKA_ADI; } set { if (!Equals(value, _bANKA_ADI)) { _bANKA_ADI = value; } } }
    	private string _bANKA_ADI;
    
    	
     	[DataMember]
        public string BANKA_SUBE_ADI { get { return _bANKA_SUBE_ADI; } set { if (!Equals(value, _bANKA_SUBE_ADI)) { _bANKA_SUBE_ADI = value; } } }
    	private string _bANKA_SUBE_ADI;
    
    	
     	[DataMember]
        public string BANKA_IBAN_NO { get { return _bANKA_IBAN_NO; } set { if (!Equals(value, _bANKA_IBAN_NO)) { _bANKA_IBAN_NO = value; } } }
    	private string _bANKA_IBAN_NO;
    
    	
     	[DataMember]
        public Nullable<int> TBL_PARA_TIPI_ID { get { return _tBL_PARA_TIPI_ID; } set { if (!Equals(value, _tBL_PARA_TIPI_ID)) { _tBL_PARA_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_PARA_TIPI_ID;
    
    	
     	[DataMember]
        public string BANKA_TELEFON_1 { get { return _bANKA_TELEFON_1; } set { if (!Equals(value, _bANKA_TELEFON_1)) { _bANKA_TELEFON_1 = value; } } }
    	private string _bANKA_TELEFON_1;
    
    	
     	[DataMember]
        public string BANKA_TELEFON_2 { get { return _bANKA_TELEFON_2; } set { if (!Equals(value, _bANKA_TELEFON_2)) { _bANKA_TELEFON_2 = value; } } }
    	private string _bANKA_TELEFON_2;
    
    	
     	[DataMember]
        public string BANKA_ADRES { get { return _bANKA_ADRES; } set { if (!Equals(value, _bANKA_ADRES)) { _bANKA_ADRES = value; } } }
    	private string _bANKA_ADRES;
    
    	
     	[DataMember]
        public string BANKA_IL { get { return _bANKA_IL; } set { if (!Equals(value, _bANKA_IL)) { _bANKA_IL = value; } } }
    	private string _bANKA_IL;
    
    	
     	[DataMember]
        public string BANKA_ILCE { get { return _bANKA_ILCE; } set { if (!Equals(value, _bANKA_ILCE)) { _bANKA_ILCE = value; } } }
    	private string _bANKA_ILCE;
    
    	
     	[DataMember]
        public string BANKA_MAIL { get { return _bANKA_MAIL; } set { if (!Equals(value, _bANKA_MAIL)) { _bANKA_MAIL = value; } } }
    	private string _bANKA_MAIL;
    
    	
     	[DataMember]
        public string BANKA_ACIKLAMA { get { return _bANKA_ACIKLAMA; } set { if (!Equals(value, _bANKA_ACIKLAMA)) { _bANKA_ACIKLAMA = value; } } }
    	private string _bANKA_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
