using System;
using System.Collections.Generic;

namespace Dene.Models
{
    public partial class TBL_ODEME
    {
        public int TBL_ODEME_ID { get; set; }
        public string ODEME_KAYIT_TARIHI { get; set; }
        public string ODEME_VADE_TARIHI { get; set; }
        public Nullable<int> TBL_ODEME_TURU_ID { get; set; }
        public Nullable<int> TBL_ODEME_TIPI_ID { get; set; }
        public string BELGE_NO { get; set; }
        public Nullable<int> TBL_SIRKET_ID { get; set; }
        public string TUTAR { get; set; }
        public Nullable<int> TBL_PARA_TIPI_ID { get; set; }
        public Nullable<int> TBL_KASA_ID { get; set; }
        public string YEDEK { get; set; }
        public virtual TBL_KASA TBL_KASA { get; set; }
        public virtual TBL_ODEME_TIPI TBL_ODEME_TIPI { get; set; }
        public virtual TBL_ODEME_TURU TBL_ODEME_TURU { get; set; }
        public virtual TBL_PARA_TIPI TBL_PARA_TIPI { get; set; }
        public virtual TBL_SIRKET TBL_SIRKET { get; set; }
    }
}
