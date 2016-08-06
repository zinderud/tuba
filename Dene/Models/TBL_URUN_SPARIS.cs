using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_SPARIS
    {
        public int TBL_URUN_SPARIS_ID { get; set; }
        public Nullable<int> TBL_URUN_ID { get; set; }
        public Nullable<int> TBL_SIPARIS_ID { get; set; }
        public string URUN_SIPARIS_MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_SPARIS TBL_SPARIS { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
