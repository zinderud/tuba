using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_BANKA
    {
        public TBL_BANKA()
        {
            this.TBL_BANKA_BAKIYE = new List<TBL_BANKA_BAKIYE>();
        }

        public int TBL_BANKA_ID { get; set; }
        public string BANKA_ADI { get; set; }
        public string BANKA_SUBE_ADI { get; set; }
        public string BANKA_IBAN_NO { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public string BANKA_TELEFON_1 { get; set; }
        public string BANKA_TELEFON_2 { get; set; }
        public string BANKA_ADRES { get; set; }
        public string BANKA_IL { get; set; }
        public string BANKA_ILCE { get; set; }
        public string BANKA_MAIL { get; set; }
        public string BANKA_ACIKLAMA { get; set; }
        public string YEDEK { get; set; }
        public virtual ICollection<TBL_BANKA_BAKIYE> TBL_BANKA_BAKIYE { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
    }
}
