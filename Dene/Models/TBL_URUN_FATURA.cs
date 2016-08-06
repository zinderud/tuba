using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_FATURA
    {
        public int TBL_URUN_FATURA_ID { get; set; }
        public Nullable<int> TBL_URUN_ID { get; set; }
        public Nullable<int> TBL_FATURA_ID { get; set; }
        public string URUN_FATURA_MIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_FATURA TBL_FATURA { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
