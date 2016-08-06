using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_FATURA_TURU
    {
        public TBL_FATURA_TURU()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
        }

        public int TBL_FATURA_TURU_ID { get; set; }
        public string FATURA_TURU_ADI { get; set; }
        public string FATURA_TURU_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
    }
}
