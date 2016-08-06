using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_SPARIS
    {
        public TBL_SPARIS()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_URUN_SPARIS = new List<TBL_URUN_SPARIS>();
        }

        public int TBL_SPARIS_ID { get; set; }
        public Nullable<int> TBL_SIRKET_ID { get; set; }
        public Nullable<int> TBL_SPARIS_TURU_ID { get; set; }
        public string SPARIS_TARIH { get; set; }
        public string SPARIS_VADE_TARIH { get; set; }
        public string SPARIS_FATURA_SERI_NO { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public Nullable<int> TBL_ODEME_TIPI_ID { get; set; }
        public Nullable<int> TBL_KASA_ID { get; set; }
        public Nullable<int> TBL_DEPO_ID { get; set; }
        public Nullable<int> TBL_PERSONEL_ID { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_DEPO TBL_DEPO { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual TBL_KASA TBL_KASA { get; set; }
        public virtual TBL_ODEME_TIPI TBL_ODEME_TIPI { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
        public virtual TBL_PERSONEL TBL_PERSONEL { get; set; }
        public virtual TBL_SIRKET TBL_SIRKET { get; set; }
        public virtual TBL_SPARIS_TURU TBL_SPARIS_TURU { get; set; }
        public virtual ICollection<TBL_URUN_SPARIS> TBL_URUN_SPARIS { get; set; }
    }
}
