using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_PARA_TIPI
    {
        public TBL_PARA_TIPI()
        {
            this.TBL_BANKA = new List<TBL_BANKA>();
            this.TBL_BANKA_BAKIYE = new List<TBL_BANKA_BAKIYE>();
            this.TBL_FATURA = new List<TBL_FATURA>();
            this.TBL_GIDER = new List<TBL_GIDER>();
            this.TBL_GIDER_BAKIYE = new List<TBL_GIDER_BAKIYE>();
            this.TBL_KASA = new List<TBL_KASA>();
            this.TBL_KASA_BAKIYE = new List<TBL_KASA_BAKIYE>();
            this.TBL_ODEME = new List<TBL_ODEME>();
            this.TBL_SIRKET_BAKIYE = new List<TBL_SIRKET_BAKIYE>();
            this.TBL_SPARIS = new List<TBL_SPARIS>();
            this.TBL_URUN = new List<TBL_URUN>();
        }

        public int TBL_PARA_TIPI_ID { get; set; }
        public string PARA_TIPI_ADI { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_BANKA> TBL_BANKA { get; set; }
        public virtual ICollection<TBL_BANKA_BAKIYE> TBL_BANKA_BAKIYE { get; set; }
        public virtual ICollection<TBL_FATURA> TBL_FATURA { get; set; }
        public virtual ICollection<TBL_GIDER> TBL_GIDER { get; set; }
        public virtual ICollection<TBL_GIDER_BAKIYE> TBL_GIDER_BAKIYE { get; set; }
        public virtual ICollection<TBL_KASA> TBL_KASA { get; set; }
        public virtual ICollection<TBL_KASA_BAKIYE> TBL_KASA_BAKIYE { get; set; }
        public virtual ICollection<TBL_ODEME> TBL_ODEME { get; set; }
        public virtual ICollection<TBL_SIRKET_BAKIYE> TBL_SIRKET_BAKIYE { get; set; }
        public virtual ICollection<TBL_SPARIS> TBL_SPARIS { get; set; }
        public virtual ICollection<TBL_URUN> TBL_URUN { get; set; }
    }
}
