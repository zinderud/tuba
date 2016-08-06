using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_BIRIM
    {
        public TBL_URUN_BIRIM()
        {
            this.TBL_URUN = new List<TBL_URUN>();
        }

        public int TBL_URUN_BIRIM_ID { get; set; }
        public string URUN_BIRIM_ADI { get; set; }
        public string URUN_BIRIM_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_URUN> TBL_URUN { get; set; }
    }
}
