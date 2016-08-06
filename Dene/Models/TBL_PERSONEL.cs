using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_PERSONEL
    {
        public TBL_PERSONEL()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
        }

        public int TBL_PERSONEL_ID { get; set; }
        public string PERSONEL_AD_SOYAD { get; set; }
        public string YETKI_SEVIYESI { get; set; }
        public string SIFRE { get; set; }
        public string BARKOD_ID { get; set; }
        public string PERSONEL_GOREVI { get; set; }
        public string PERSONEL_TELEFON1 { get; set; }
        public string PERSONEL_TELEFON2 { get; set; }
        public string PERSONEL_MAIL { get; set; }
        public string PERSONEL_CALISMA_DURUMU { get; set; }
        public string PERSONEL_ISE_BASLAMA_TARIHI { get; set; }
        public string PERSONEL_ISTEN_AYRILMA_TARIHI { get; set; }
        public string PERSONEL_ISE_GELIS_SAATI { get; set; }
        public string PERSONEL_ISTEN_CIKIS_SAATI { get; set; }
        public string PERSONEL_SSK_NO { get; set; }
        public string PERSONEL_CINSIYET { get; set; }
        public string PERSONEL_KIMLIK_NO { get; set; }
        public string PERSONEL_DOGUM_TARIHI { get; set; }
        public string PERSONEL_DOGUM_YERI { get; set; }
        public string PERSONEL_EGITIM_DURUMU { get; set; }
        public string PERSONEL_ACIKLAMA { get; set; }
        public string PERSONEL_AYAKKABI_NO { get; set; }
        public string PERSONEL_GOMLEK_NO { get; set; }
        public string PERSONEL_MONT_NO { get; set; }
        public string PERSONEL_PANTOLON_NO { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
    }
}
