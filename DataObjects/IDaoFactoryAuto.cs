

 
#region
// Murat onur Karadeniz Auto code for dataobjects için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace DataObjects
{
    public partial interface IDaoFactory
    {

ITBL_BANKA   tbl_banka { get; }
ITBL_BANKA_BAKIYE   tbl_banka_bakıye { get; }
ITBL_DEPO   tbl_depo { get; }
ITBL_DEPO_ISLEM   tbl_depo_ıslem { get; }
ITBL_DEPO_TRANSFER   tbl_depo_transfer { get; }
ITBL_FATURA   tbl_fatura { get; }
ITBL_FATURA_TURU   tbl_fatura_turu { get; }
ITBL_FIS   tbl_fıs { get; }
ITBL_GIDER   tbl_gıder { get; }
ITBL_GIDER_BAKIYE   tbl_gıder_bakıye { get; }
ITBL_KASA   tbl_kasa { get; }
ITBL_KASA_BAKIYE   tbl_kasa_bakıye { get; }
ITBL_KDV   tbl_kdv { get; }
ITBL_ODEME   tbl_odeme { get; }
ITBL_ODEME_TIPI   tbl_odeme_tıpı { get; }
ITBL_ODEME_TURU   tbl_odeme_turu { get; }
ITBL_PARA_TIPI   tbl_para_tıpı { get; }
ITBL_PERSONEL   tbl_personel { get; }
ITBL_SIRKET   tbl_sırket { get; }
ITBL_SIRKET_BAKIYE   tbl_sırket_bakıye { get; }
ITBL_SIRKET_GRUB   tbl_sırket_grub { get; }
ITBL_SIRKET_SINIF   tbl_sırket_sınıf { get; }
ITBL_SIRKET_TIPI   tbl_sırket_tıpı { get; }
ITBL_SPARIS   tbl_sparıs { get; }
ITBL_SPARIS_TURU   tbl_sparıs_turu { get; }
ITBL_URUN   tbl_urun { get; }
ITBL_URUN_BIRIM   tbl_urun_bırım { get; }
ITBL_URUN_CINSI   tbl_urun_cınsı { get; }
ITBL_URUN_FATURA   tbl_urun_fatura { get; }
ITBL_URUN_MARKA   tbl_urun_marka { get; }
ITBL_URUN_SPARIS   tbl_urun_sparıs { get; }
ITBL_URUN_STOK   tbl_urun_stok { get; }
ITBL_URUN_TIPI   tbl_urun_tıpı { get; }

}
}