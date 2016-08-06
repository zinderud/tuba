using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_SIRKET
    {
        public TBL_SIRKET()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_ODEME = new List<TBL_ODEME>();
            this.TBL_SIRKET_BAKIYE = new List<TBL_SIRKET_BAKIYE>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
        }

        public int TBL_SIRKET_ID { get; set; }
        public Nullable<int> TBL_SIRKET_GRUB_ID { get; set; }
        public Nullable<int> TBL_SIRKET_SINIF_ID { get; set; }
        public Nullable<int> TBL_SIRKET_TIPI_ID { get; set; }
        public string SIRKET_ADI { get; set; }
        public string SIRKET_TELEFON_1 { get; set; }
        public string SIRKET_TELEFON_2 { get; set; }
        public string SIRKET_FAX_1 { get; set; }
        public string SIRKET_FAX_2 { get; set; }
        public string SIRKET_MAIL_1 { get; set; }
        public string SIRKET_MAIL_2 { get; set; }
        public string SIRKET_WEB_ADRES { get; set; }
        public string SIRKET_VERGI_DAIRESI { get; set; }
        public string SIRKET_VERGI_NO { get; set; }
        public string SIRKET_ADRES { get; set; }
        public string SIRKET_IL { get; set; }
        public string SIRKET_ILCE { get; set; }
        public string SIRKET_POSTA_KODU { get; set; }
        public string SIRKET_BANKA_ADI { get; set; }
        public string SIRKET_BANKA_SUBE_ADI { get; set; }
        public string SIRKET_HESAP_NO { get; set; }
        public string SIRKET_IBAN { get; set; }
        public string SIRKET_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        public virtual ICollection<TBL_SIRKET_BAKIYE> TBL_SIRKET_BAKIYE { get; set; }
        public virtual TBL_SIRKET_GRUB TBL_SIRKET_GRUB { get; set; }
        public virtual TBL_SIRKET_SINIF TBL_SIRKET_SINIF { get; set; }
        public virtual TBL_SIRKET_TIPI TBL_SIRKET_TIPI { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
    }
}
