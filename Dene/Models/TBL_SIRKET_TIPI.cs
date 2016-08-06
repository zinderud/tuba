using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_SIRKET_TIPI
    {
        public TBL_SIRKET_TIPI()
        {
            this.TBL_SIRKET = new List<TBL_SIRKET>();
        }

        public int TBL_SIRKET_TIPI_ID { get; set; }
        public string SIRKET_TIPI_ADI { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_SIRKET> TBL_SIRKET { get; set; }
    }
}
