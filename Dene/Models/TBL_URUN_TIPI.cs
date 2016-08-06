using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_URUN_TIPI
    {
        public TBL_URUN_TIPI()
        {
            this.TBL_URUN = new List<TBL_URUN>();
            this.TBL_URUN_CINSI = new List<TBL_URUN_CINSI>();
            this.TBL_URUN_MARKA = new List<TBL_URUN_MARKA>();
        }

        public int TBL_URUN_TIPI_ID { get; set; }
        public string URUN_TIPI_ADI { get; set; }
        public string URUN_TIPI_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_URUN> TBL_URUN { get; set; }
        public virtual ICollection<TBL_URUN_CINSI> TBL_URUN_CINSI { get; set; }
        public virtual ICollection<TBL_URUN_MARKA> TBL_URUN_MARKA { get; set; }
    }
}
