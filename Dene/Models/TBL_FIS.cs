using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_FIS
    {
        public TBL_FIS()
        {
            this.TBL_BANKA_BAKIYE = new List<TBL_BANKA_BAKIYE>();
            this.TBL_GIDER_BAKIYE = new List<TBL_GIDER_BAKIYE>();
            this.TBL_KASA_BAKIYE = new List<TBL_KASA_BAKIYE>();
            this.TBL_SIRKET_BAKIYE = new List<TBL_SIRKET_BAKIYE>();
        }

        public int TBL_FIS_ID { get; set; }
        public string ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_BANKA_BAKIYE> TBL_BANKA_BAKIYE { get; set; }
        public virtual ICollection<TBL_GIDER_BAKIYE> TBL_GIDER_BAKIYE { get; set; }
        public virtual ICollection<TBL_KASA_BAKIYE> TBL_KASA_BAKIYE { get; set; }
        public virtual ICollection<TBL_SIRKET_BAKIYE> TBL_SIRKET_BAKIYE { get; set; }
    }
}
