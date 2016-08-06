using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_GIDER
    {
        public TBL_GIDER()
        {
            this.TBL_GIDER_BAKIYE = new List<TBL_GIDER_BAKIYE>();
        }

        public int TBL_GIDER_ID { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public string GİDER_ADI { get; set; }
        public string GİDER_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_GIDER_BAKIYE> TBL_GIDER_BAKIYE { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
    }
}
