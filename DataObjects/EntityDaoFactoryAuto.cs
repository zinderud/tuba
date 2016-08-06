

 
#region
// Murat onur Karadeniz Auto code for dataobjects için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#endregion

namespace DataObjects.EntityFramework.Implementation
{
    public partial class EntityDaoFactory :IDaoFactory
    {

public ITBL_BANKA   tbl_banka
 { get { return new  EntityTBL_BANKA();} }

public ITBL_BANKA_BAKIYE   tbl_banka_bakıye
 { get { return new  EntityTBL_BANKA_BAKIYE();} }

public ITBL_DEPO   tbl_depo
 { get { return new  EntityTBL_DEPO();} }

public ITBL_DEPO_ISLEM   tbl_depo_ıslem
 { get { return new  EntityTBL_DEPO_ISLEM();} }

public ITBL_DEPO_TRANSFER   tbl_depo_transfer
 { get { return new  EntityTBL_DEPO_TRANSFER();} }

public ITBL_FATURA   tbl_fatura
 { get { return new  EntityTBL_FATURA();} }

public ITBL_FATURA_TURU   tbl_fatura_turu
 { get { return new  EntityTBL_FATURA_TURU();} }

public ITBL_FIS   tbl_fıs
 { get { return new  EntityTBL_FIS();} }

public ITBL_GIDER   tbl_gıder
 { get { return new  EntityTBL_GIDER();} }

public ITBL_GIDER_BAKIYE   tbl_gıder_bakıye
 { get { return new  EntityTBL_GIDER_BAKIYE();} }

public ITBL_KASA   tbl_kasa
 { get { return new  EntityTBL_KASA();} }

public ITBL_KASA_BAKIYE   tbl_kasa_bakıye
 { get { return new  EntityTBL_KASA_BAKIYE();} }

public ITBL_KDV   tbl_kdv
 { get { return new  EntityTBL_KDV();} }

public ITBL_ODEME   tbl_odeme
 { get { return new  EntityTBL_ODEME();} }

public ITBL_ODEME_TIPI   tbl_odeme_tıpı
 { get { return new  EntityTBL_ODEME_TIPI();} }

public ITBL_ODEME_TURU   tbl_odeme_turu
 { get { return new  EntityTBL_ODEME_TURU();} }

public ITBL_PARA_TIPI   tbl_para_tıpı
 { get { return new  EntityTBL_PARA_TIPI();} }

public ITBL_PERSONEL   tbl_personel
 { get { return new  EntityTBL_PERSONEL();} }

public ITBL_SIRKET   tbl_sırket
 { get { return new  EntityTBL_SIRKET();} }

public ITBL_SIRKET_BAKIYE   tbl_sırket_bakıye
 { get { return new  EntityTBL_SIRKET_BAKIYE();} }

public ITBL_SIRKET_GRUB   tbl_sırket_grub
 { get { return new  EntityTBL_SIRKET_GRUB();} }

public ITBL_SIRKET_SINIF   tbl_sırket_sınıf
 { get { return new  EntityTBL_SIRKET_SINIF();} }

public ITBL_SIRKET_TIPI   tbl_sırket_tıpı
 { get { return new  EntityTBL_SIRKET_TIPI();} }

public ITBL_SPARIS   tbl_sparıs
 { get { return new  EntityTBL_SPARIS();} }

public ITBL_SPARIS_TURU   tbl_sparıs_turu
 { get { return new  EntityTBL_SPARIS_TURU();} }

public ITBL_URUN   tbl_urun
 { get { return new  EntityTBL_URUN();} }

public ITBL_URUN_BIRIM   tbl_urun_bırım
 { get { return new  EntityTBL_URUN_BIRIM();} }

public ITBL_URUN_CINSI   tbl_urun_cınsı
 { get { return new  EntityTBL_URUN_CINSI();} }

public ITBL_URUN_FATURA   tbl_urun_fatura
 { get { return new  EntityTBL_URUN_FATURA();} }

public ITBL_URUN_MARKA   tbl_urun_marka
 { get { return new  EntityTBL_URUN_MARKA();} }

public ITBL_URUN_SPARIS   tbl_urun_sparıs
 { get { return new  EntityTBL_URUN_SPARIS();} }

public ITBL_URUN_STOK   tbl_urun_stok
 { get { return new  EntityTBL_URUN_STOK();} }

public ITBL_URUN_TIPI   tbl_urun_tıpı
 { get { return new  EntityTBL_URUN_TIPI();} }


}
}


 