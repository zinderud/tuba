using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_DEPO
    {
        public TBL_DEPO()
        {
            this.TBL_DEPO_ISLEM = new List<TBL_DEPO_ISLEM>();
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
            this.TBL_URUN_STOK = new List<TBL_URUN_STOK>();
        }

        public int TBL_DEPO_ID { get; set; }
        public string DEPO_ADI { get; set; }
        public string DEPO_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_DEPO_ISLEM> TBL_DEPO_ISLEM { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
        public virtual ICollection<TBL_URUN_STOK> TBL_URUN_STOK { get; set; }
    }
}
