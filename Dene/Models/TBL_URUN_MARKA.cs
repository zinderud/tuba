using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_MARKA
    {
        public TBL_URUN_MARKA()
        {
            this.TBL_URUN = new List<TBL_URUN>();
        }

        public int TBL_URUN_MARKA_ID { get; set; }
        public Nullable<int> TBL_URUN_TIPI_ID { get; set; }
        public int TBL_URUN_CINSI_ID { get; set; }
        public string URUN_MARKA_ADI { get; set; }
        public string URUN_MARKA_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_URUN> TBL_URUN { get; set; }
        public virtual TBL_URUN_CINSI TBL_URUN_CINSI { get; set; }
        public virtual TBL_URUN_TIPI TBL_URUN_TIPI { get; set; }
    }
}
