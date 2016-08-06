using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_DEPO_TRANSFER
    {
        public int TBL_DEPO_TRANSFER_ID { get; set; }
        public string DEPO_TRANSFER_ADI { get; set; }
        public string DEPO_TRANSFER_TARIHI { get; set; }
        public string DEPO_TRANSFER_NEREDEN { get; set; }
        public string DEPO_TRANSFER_NEREYE { get; set; }
        public Nullable<int> TBL_URUN_ID { get; set; }
        public string DEPO_TRANSFER_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
