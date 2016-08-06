using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_KDV
    {
        public TBL_KDV()
        {
            this.TBL_URUN = new List<TBL_URUN>();
        }

        public int TBL_KDV_ID { get; set; }
        public Nullable<int> KDV_YUZDESI { get; set; }
        public string KDV_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_URUN> TBL_URUN { get; set; }
    }
}
