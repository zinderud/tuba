using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_DEPO_ISLEM
    {
        public int TBL_DEPO_ISLEM_ID { get; set; }
        public Nullable<int> TBL_DEPO_ID { get; set; }
        public Nullable<int> TBL_URUN_ID { get; set; }
        public string DEPO_ISLEM_ADI { get; set; }
        public string URUN_MIKTAR { get; set; }
        public string DEPO_ONAY { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_DEPO TBL_DEPO { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
