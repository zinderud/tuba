using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_KASA_BAKIYE
    {
        public int TBL_KASA_BAKIYE_ID { get; set; }
        public Nullable<int> TBL_KASA_ID { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public Nullable<int> TBL_FIS_ID { get; set; }
        public string KUR { get; set; }
        public string TARIH { get; set; }
        public string TUTAR { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_FIS TBL_FIS { get; set; }
        public virtual TBL_KASA TBL_KASA { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
    }
}
