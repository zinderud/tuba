using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_ODEME_TURU
    {
        public TBL_ODEME_TURU()
        {
            this.TBL_ODEME = new List<TBL_ODEME>();
        }

        public int TBL_ODEME_TURU_ID { get; set; }
        public string ODEME_TURU_ADI { get; set; }
        public string ODEME_TURU_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
    }
}
