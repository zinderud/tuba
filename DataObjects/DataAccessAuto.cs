

 
#region
// Murat onur Karadeniz Auto code for dataobjects için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

#endregion

namespace DataObjects
{
    public  static class DataAccess
    {
        private static readonly string connectionStringName =  "ActionEntities";
        private static readonly IDaoFactory factory = DaoFactories.GetFactory(connectionStringName);
		 

  public static  ITBL_BANKA   tbl_banka
   { get{return factory.tbl_banka; } }

  public static  ITBL_BANKA_BAKIYE   tbl_banka_bakıye
   { get{return factory.tbl_banka_bakıye; } }

  public static  ITBL_DEPO   tbl_depo
   { get{return factory.tbl_depo; } }

  public static  ITBL_DEPO_ISLEM   tbl_depo_ıslem
   { get{return factory.tbl_depo_ıslem; } }

  public static  ITBL_DEPO_TRANSFER   tbl_depo_transfer
   { get{return factory.tbl_depo_transfer; } }

  public static  ITBL_FATURA   tbl_fatura
   { get{return factory.tbl_fatura; } }

  public static  ITBL_FATURA_TURU   tbl_fatura_turu
   { get{return factory.tbl_fatura_turu; } }

  public static  ITBL_FIS   tbl_fıs
   { get{return factory.tbl_fıs; } }

  public static  ITBL_GIDER   tbl_gıder
   { get{return factory.tbl_gıder; } }

  public static  ITBL_GIDER_BAKIYE   tbl_gıder_bakıye
   { get{return factory.tbl_gıder_bakıye; } }

  public static  ITBL_KASA   tbl_kasa
   { get{return factory.tbl_kasa; } }

  public static  ITBL_KASA_BAKIYE   tbl_kasa_bakıye
   { get{return factory.tbl_kasa_bakıye; } }

  public static  ITBL_KDV   tbl_kdv
   { get{return factory.tbl_kdv; } }

  public static  ITBL_ODEME   tbl_odeme
   { get{return factory.tbl_odeme; } }

  public static  ITBL_ODEME_TIPI   tbl_odeme_tıpı
   { get{return factory.tbl_odeme_tıpı; } }

  public static  ITBL_ODEME_TURU   tbl_odeme_turu
   { get{return factory.tbl_odeme_turu; } }

  public static  ITBL_PARA_TIPI   tbl_para_tıpı
   { get{return factory.tbl_para_tıpı; } }

  public static  ITBL_PERSONEL   tbl_personel
   { get{return factory.tbl_personel; } }

  public static  ITBL_SIRKET   tbl_sırket
   { get{return factory.tbl_sırket; } }

  public static  ITBL_SIRKET_BAKIYE   tbl_sırket_bakıye
   { get{return factory.tbl_sırket_bakıye; } }

  public static  ITBL_SIRKET_GRUB   tbl_sırket_grub
   { get{return factory.tbl_sırket_grub; } }

  public static  ITBL_SIRKET_SINIF   tbl_sırket_sınıf
   { get{return factory.tbl_sırket_sınıf; } }

  public static  ITBL_SIRKET_TIPI   tbl_sırket_tıpı
   { get{return factory.tbl_sırket_tıpı; } }

  public static  ITBL_SPARIS   tbl_sparıs
   { get{return factory.tbl_sparıs; } }

  public static  ITBL_SPARIS_TURU   tbl_sparıs_turu
   { get{return factory.tbl_sparıs_turu; } }

  public static  ITBL_URUN   tbl_urun
   { get{return factory.tbl_urun; } }

  public static  ITBL_URUN_BIRIM   tbl_urun_bırım
   { get{return factory.tbl_urun_bırım; } }

  public static  ITBL_URUN_CINSI   tbl_urun_cınsı
   { get{return factory.tbl_urun_cınsı; } }

  public static  ITBL_URUN_FATURA   tbl_urun_fatura
   { get{return factory.tbl_urun_fatura; } }

  public static  ITBL_URUN_MARKA   tbl_urun_marka
   { get{return factory.tbl_urun_marka; } }

  public static  ITBL_URUN_SPARIS   tbl_urun_sparıs
   { get{return factory.tbl_urun_sparıs; } }

  public static  ITBL_URUN_STOK   tbl_urun_stok
   { get{return factory.tbl_urun_stok; } }

  public static  ITBL_URUN_TIPI   tbl_urun_tıpı
   { get{return factory.tbl_urun_tıpı; } }


}
}

 