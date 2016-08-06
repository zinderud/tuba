using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_STOK
    {
        public int TBL_URUN_STOK_ID { get; set; }
        public Nullable<int> TBL_URUN_ID { get; set; }
        public Nullable<int> TBL_DEPO_ID { get; set; }
        public Nullable<int> URUN_BIRIM_MIKTARI { get; set; }
        public string STOK_DURUM { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_DEPO TBL_DEPO { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
