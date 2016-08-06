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
     
     
     
     
     
     
     
    public partial class TBL_SIRKETDTO 
    {
     
        
    
    	
     	[DataMember]
        public int TBL_SIRKET_ID { get { return _tBL_SIRKET_ID; } set { if (!Equals(value, _tBL_SIRKET_ID)) { _tBL_SIRKET_ID = value; } } }
    	private int _tBL_SIRKET_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_GRUB_ID { get { return _tBL_SIRKET_GRUB_ID; } set { if (!Equals(value, _tBL_SIRKET_GRUB_ID)) { _tBL_SIRKET_GRUB_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_GRUB_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_SINIF_ID { get { return _tBL_SIRKET_SINIF_ID; } set { if (!Equals(value, _tBL_SIRKET_SINIF_ID)) { _tBL_SIRKET_SINIF_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_SINIF_ID;
    
    	
     	[DataMember]
        public Nullable<int> TBL_SIRKET_TIPI_ID { get { return _tBL_SIRKET_TIPI_ID; } set { if (!Equals(value, _tBL_SIRKET_TIPI_ID)) { _tBL_SIRKET_TIPI_ID = value; } } }
    	private Nullable<int> _tBL_SIRKET_TIPI_ID;
    
    	
     	[DataMember]
        public string SIRKET_ADI { get { return _sIRKET_ADI; } set { if (!Equals(value, _sIRKET_ADI)) { _sIRKET_ADI = value; } } }
    	private string _sIRKET_ADI;
    
    	
     	[DataMember]
        public string SIRKET_TELEFON_1 { get { return _sIRKET_TELEFON_1; } set { if (!Equals(value, _sIRKET_TELEFON_1)) { _sIRKET_TELEFON_1 = value; } } }
    	private string _sIRKET_TELEFON_1;
    
    	
     	[DataMember]
        public string SIRKET_TELEFON_2 { get { return _sIRKET_TELEFON_2; } set { if (!Equals(value, _sIRKET_TELEFON_2)) { _sIRKET_TELEFON_2 = value; } } }
    	private string _sIRKET_TELEFON_2;
    
    	
     	[DataMember]
        public string SIRKET_FAX_1 { get { return _sIRKET_FAX_1; } set { if (!Equals(value, _sIRKET_FAX_1)) { _sIRKET_FAX_1 = value; } } }
    	private string _sIRKET_FAX_1;
    
    	
     	[DataMember]
        public string SIRKET_FAX_2 { get { return _sIRKET_FAX_2; } set { if (!Equals(value, _sIRKET_FAX_2)) { _sIRKET_FAX_2 = value; } } }
    	private string _sIRKET_FAX_2;
    
    	
     	[DataMember]
        public string SIRKET_MAIL_1 { get { return _sIRKET_MAIL_1; } set { if (!Equals(value, _sIRKET_MAIL_1)) { _sIRKET_MAIL_1 = value; } } }
    	private string _sIRKET_MAIL_1;
    
    	
     	[DataMember]
        public string SIRKET_MAIL_2 { get { return _sIRKET_MAIL_2; } set { if (!Equals(value, _sIRKET_MAIL_2)) { _sIRKET_MAIL_2 = value; } } }
    	private string _sIRKET_MAIL_2;
    
    	
     	[DataMember]
        public string SIRKET_WEB_ADRES { get { return _sIRKET_WEB_ADRES; } set { if (!Equals(value, _sIRKET_WEB_ADRES)) { _sIRKET_WEB_ADRES = value; } } }
    	private string _sIRKET_WEB_ADRES;
    
    	
     	[DataMember]
        public string SIRKET_VERGI_DAIRESI { get { return _sIRKET_VERGI_DAIRESI; } set { if (!Equals(value, _sIRKET_VERGI_DAIRESI)) { _sIRKET_VERGI_DAIRESI = value; } } }
    	private string _sIRKET_VERGI_DAIRESI;
    
    	
     	[DataMember]
        public string SIRKET_VERGI_NO { get { return _sIRKET_VERGI_NO; } set { if (!Equals(value, _sIRKET_VERGI_NO)) { _sIRKET_VERGI_NO = value; } } }
    	private string _sIRKET_VERGI_NO;
    
    	
     	[DataMember]
        public string SIRKET_ADRES { get { return _sIRKET_ADRES; } set { if (!Equals(value, _sIRKET_ADRES)) { _sIRKET_ADRES = value; } } }
    	private string _sIRKET_ADRES;
    
    	
     	[DataMember]
        public string SIRKET_IL { get { return _sIRKET_IL; } set { if (!Equals(value, _sIRKET_IL)) { _sIRKET_IL = value; } } }
    	private string _sIRKET_IL;
    
    	
     	[DataMember]
        public string SIRKET_ILCE { get { return _sIRKET_ILCE; } set { if (!Equals(value, _sIRKET_ILCE)) { _sIRKET_ILCE = value; } } }
    	private string _sIRKET_ILCE;
    
    	
     	[DataMember]
        public string SIRKET_POSTA_KODU { get { return _sIRKET_POSTA_KODU; } set { if (!Equals(value, _sIRKET_POSTA_KODU)) { _sIRKET_POSTA_KODU = value; } } }
    	private string _sIRKET_POSTA_KODU;
    
    	
     	[DataMember]
        public string SIRKET_BANKA_ADI { get { return _sIRKET_BANKA_ADI; } set { if (!Equals(value, _sIRKET_BANKA_ADI)) { _sIRKET_BANKA_ADI = value; } } }
    	private string _sIRKET_BANKA_ADI;
    
    	
     	[DataMember]
        public string SIRKET_BANKA_SUBE_ADI { get { return _sIRKET_BANKA_SUBE_ADI; } set { if (!Equals(value, _sIRKET_BANKA_SUBE_ADI)) { _sIRKET_BANKA_SUBE_ADI = value; } } }
    	private string _sIRKET_BANKA_SUBE_ADI;
    
    	
     	[DataMember]
        public string SIRKET_HESAP_NO { get { return _sIRKET_HESAP_NO; } set { if (!Equals(value, _sIRKET_HESAP_NO)) { _sIRKET_HESAP_NO = value; } } }
    	private string _sIRKET_HESAP_NO;
    
    	
     	[DataMember]
        public string SIRKET_IBAN { get { return _sIRKET_IBAN; } set { if (!Equals(value, _sIRKET_IBAN)) { _sIRKET_IBAN = value; } } }
    	private string _sIRKET_IBAN;
    
    	
     	[DataMember]
        public string SIRKET_ACIKLAMA { get { return _sIRKET_ACIKLAMA; } set { if (!Equals(value, _sIRKET_ACIKLAMA)) { _sIRKET_ACIKLAMA = value; } } }
    	private string _sIRKET_ACIKLAMA;
    
    	
     	[DataMember]
        public string YEDEK { get { return _yEDEK; } set { if (!Equals(value, _yEDEK)) { _yEDEK = value; } } }
    	private string _yEDEK;
    
    
    }
}
