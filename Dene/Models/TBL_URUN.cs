using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN
    {
        public TBL_URUN()
        {
            this.TBL_DEPO_ISLEM = new List<TBL_DEPO_ISLEM>();
            this.TBL_DEPO_TRANSFER = new List<TBL_DEPO_TRANSFER>();
            this.TBL_URUN_FATURA = new List<TBL_URUN_FATURA>();
            this.TBL_URUN_SPARIS = new List<TBL_URUN_SPARIS>();
            this.TBL_URUN_STOK = new List<TBL_URUN_STOK>();
        }

        public int TBL_URUN_ID { get; set; }
        public string URUN_ADI { get; set; }
        public string URUN_KODU { get; set; }
        public Nullable<int> TBL_URUN_TIPI_ID { get; set; }
        public Nullable<int> TBL_URUN_CINSI_ID { get; set; }
        public Nullable<int> TBL_URUN_MARKA_ID { get; set; }
        public Nullable<int> TBL_URUN_BIRIM_ID { get; set; }
        public Nullable<int> TBL_KDV_ID { get; set; }
        public string URUN_DURUM { get; set; }
        public string URUN_ALIS_FIYATI { get; set; }
        public string URUN_SATIS_FIYATI { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_DEPO_ISLEM> TBL_DEPO_ISLEM { get; set; }
        public virtual ICollection<TBL_DEPO_TRANSFER> TBL_DEPO_TRANSFER { get; set; }
        public virtual TBL_KDV TBL_KDV { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
        public virtual ICollection<TBL_URUN_FATURA> TBL_URUN_FATURA { get; set; }
        public virtual ICollection<TBL_URUN_SPARIS> TBL_URUN_SPARIS { get; set; }
        public virtual ICollection<TBL_URUN_STOK> TBL_URUN_STOK { get; set; }
        public virtual TBL_URUN_BIRIM TBL_URUN_BIRIM { get; set; }
        public virtual TBL_URUN_CINSI TBL_URUN_CINSI { get; set; }
        public virtual TBL_URUN_MARKA TBL_URUN_MARKA { get; set; }
        public virtual TBL_URUN_TIPI TBL_URUN_TIPI { get; set; }
    }
}
