using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_KASA
    {
        public TBL_KASA()
        {
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_KASA_BAKIYE = new List<TBL_KASA_BAKIYE>();
            this.TBL_ODEME = new List<TBL_ODEME>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
        }

        public int TBL_KASA_ID { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public string KASA_ADI { get; set; }
        public string KASA_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_KASA_BAKIYE> TBL_KASA_BAKIYE { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
    }
}
