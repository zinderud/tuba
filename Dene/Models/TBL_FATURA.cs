using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_FATURA
    {
        public TBL_FATURA()
        {
            this.TBL_URUN_FATURA = new List<TBL_URUN_FATURA>();
        }

        public int TBL_FATURA_ID { get; set; }
        public Nullable<int> TBL_SIRKET_ID { get; set; }
        public Nullable<int> TBL_FATURA_TURU_ID { get; set; }
        public string FATURA_TARIH { get; set; }
        public string FATURA_VADE_TARIH { get; set; }
        public string FATURA_FATURA_SERI_NO { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public Nullable<int> TBL_ODEME_TIPI_ID { get; set; }
        public Nullable<int> TBL_KASA_ID { get; set; }
        public Nullable<int> TBL_DEPO_ID { get; set; }
        public Nullable<int> TBL_PERSONEL_ID { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public Nullable<int> TBL_SPARIS_ID { get; set; }
        public virtual TBL_DEPO TBL_DEPO { get; set; }
        public virtual TBL_FATURA_TURU TBL_FATURA_TURU { get; set; }
        public virtual TBL_KASA TBL_KASA { get; set; }
        public virtual TBL_ODEME_TIPI TBL_ODEME_TIPI { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
        public virtual TBL_PERSONEL TBL_PERSONEL { get; set; }
        public virtual TBL_SIRKET TBL_SIRKET { get; set; }
        public virtual TBL_SPARIS TBL_SPARIS { get; set; }
        public virtual ICollection<TBL_URUN_FATURA> TBL_URUN_FATURA { get; set; }
    }
}
