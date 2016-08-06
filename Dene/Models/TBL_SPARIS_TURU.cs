using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_SPARIS_TURU
    {
        public TBL_SPARIS_TURU()
        {
            this.TBL_SPARIS = new List<TBL_SPARIS>();
        }

        public int TBL_SPARIS_TURU_ID { get; set; }
        public string SPARIS_TURU_ADI { get; set; }
        public string SPARIS_TURU_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
    }
}
