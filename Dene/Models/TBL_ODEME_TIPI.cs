using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_ODEME_TIPI
    {
        public TBL_ODEME_TIPI()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_ODEME = new List<TBL_ODEME>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
        }

        public int TBL_ODEME_TIPI_ID { get; set; }
        public string ODEME_TIPI_ADI { get; set; }
        public string ODEME_TIPI_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
    }
}
