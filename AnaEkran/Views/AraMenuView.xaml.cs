using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnaEkran.Helpers;
using AnaEkran.Models;
using AnaEkran.ViewModels;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views
{
    /// <summary>
    /// Interaction logic for AraMenuView.xaml
    /// </summary>
    public partial class AraMenuView : UserControl
    {
        public AraMenuView()
        {
            InitializeComponent();
        }
        TBL_PERSONEL_MODEL tblPersonelModel=new TBL_PERSONEL_MODEL();
        public AraMenuView(double height, TBL_PERSONEL_MODEL model)
        {
            InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);


            tblPersonelModel = model;


            if (tblPersonelModel.YETKI_SEVIYESI== "ADMİN YETKİLİSİ")
            {
                BorderSatis.Visibility = Visibility.Visible;
                //BorderPazarlama.Visibility = Visibility.Visible;
                //BorderDepo.Visibility = Visibility.Visible;

                //BorderRaporlar.Visibility = Visibility.Visible;
                //BorderYonetici.Visibility = Visibility.Visible;


            }
            else if (tblPersonelModel.YETKI_SEVIYESI == "SATIŞ YETKİLİSİ")
            {
                BorderSatis.Visibility = Visibility.Visible;
                //BorderPazarlama.Visibility = Visibility.Collapsed;
                //BorderDepo.Visibility = Visibility.Collapsed;

                //BorderRaporlar.Visibility = Visibility.Collapsed;
                //BorderYonetici.Visibility = Visibility.Collapsed;

            }
            else if (tblPersonelModel.YETKI_SEVIYESI == "DEPO YETKİLİSİ")
            {
                BorderSatis.Visibility = Visibility.Collapsed;
                //BorderPazarlama.Visibility = Visibility.Collapsed;
                //BorderDepo.Visibility =   Visibility.Visible;

                //BorderRaporlar.Visibility = Visibility.Collapsed;
                //BorderYonetici.Visibility = Visibility.Collapsed;

            }
            else if (tblPersonelModel.YETKI_SEVIYESI == "PAZARLAMA YETKİLİSİ")
            {
                BorderSatis.Visibility = Visibility.Collapsed;
                //BorderPazarlama.Visibility = Visibility.Visible;
                //BorderDepo.Visibility = Visibility.Collapsed;

                //BorderRaporlar.Visibility = Visibility.Collapsed;
                //BorderYonetici.Visibility = Visibility.Collapsed;

            }

        }  
        public void Connect(int connectionId, object target)
        {
        }

        private void BtnKullaniciEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.PersonelAnasayfa));

        }

        private void BtnBankaEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BankaEkle));
        }

        private void BtnBankaDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BankaDuzenle));

        }

        private void BtnBankaBakiyeEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BankaBakiyeEkle));
        }

        private void BtnBankaBakiyelistele_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BankaBakiyelistele));

        }

        private void BtnTBL_BANKAEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_BANKAEkle));

        }
        private void BtnTBL_BANKADuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_BANKAListele));

        }
        private void BtnTBL_BANKA_BAKIYEEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_BANKA_BAKIYEEkle));

        }
        private void BtnTBL_BANKA_BAKIYEDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_BANKA_BAKIYEListele));

        }
        private void BtnTBL_DEPOEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPOEkle));

        }
        private void BtnTBL_DEPODuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPOListele));

        }
        private void BtnTBL_DEPO_ISLEMEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPO_ISLEMEkle));

        }
        private void BtnTBL_DEPO_ISLEMDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPO_ISLEMListele));

        }
        private void BtnTBL_DEPO_TRANSFEREkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPO_TRANSFEREkle));

        }
        private void BtnTBL_DEPO_TRANSFERDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_DEPO_TRANSFERListele));

        }
        private void BtnTBL_FATURAEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FATURAEkle));

        }
        private void BtnTBL_FATURADuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FATURAListele));

        }
        private void BtnTBL_FATURA_TURUEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FATURA_TURUEkle));

        }
        private void BtnTBL_FATURA_TURUDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FATURA_TURUListele));

        }
        private void BtnTBL_FISEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FISEkle));

        }
        private void BtnTBL_FISDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_FISListele));

        }
        private void BtnTBL_GIDEREkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_GIDEREkle));

        }
        private void BtnTBL_GIDERDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_GIDERListele));

        }
        private void BtnTBL_GIDER_BAKIYEEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_GIDER_BAKIYEEkle));

        }
        private void BtnTBL_GIDER_BAKIYEDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_GIDER_BAKIYEListele));

        }
        private void BtnTBL_KASAEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KASAEkle));

        }
        private void BtnTBL_KASADuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KASAListele));

        }
        private void BtnTBL_KASA_BAKIYEEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KASA_BAKIYEEkle));

        }
        private void BtnTBL_KASA_BAKIYEDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KASA_BAKIYEListele));

        }
        private void BtnTBL_KDVEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KDVEkle));

        }
        private void BtnTBL_KDVDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_KDVListele));

        }
        private void BtnTBL_ODEMEEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEMEEkle));

        }
        private void BtnTBL_ODEMEDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEMEListele));

        }
        private void BtnTBL_ODEME_TIPIEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEME_TIPIEkle));

        }
        private void BtnTBL_ODEME_TIPIDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEME_TIPIListele));

        }
        private void BtnTBL_ODEME_TURUEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEME_TURUEkle));

        }
        private void BtnTBL_ODEME_TURUDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_ODEME_TURUListele));

        }
        private void BtnTBL_PARA_TIPIEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_PARA_TIPIEkle));

        }
        private void BtnTBL_PARA_TIPIDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_PARA_TIPIListele));

        }
        private void BtnTBL_PERSONELEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_PERSONELEkle));

        }
        private void BtnTBL_PERSONELDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_PERSONELListele));

        }
        private void BtnTBL_SIRKETEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKETEkle));

        }
        private void BtnTBL_SIRKETDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKETListele));

        }
        private void BtnTBL_SIRKET_BAKIYEEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_BAKIYEEkle));

        }
        private void BtnTBL_SIRKET_BAKIYEDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_BAKIYEListele));

        }
        private void BtnTBL_SIRKET_GRUBEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_GRUBEkle));

        }
        private void BtnTBL_SIRKET_GRUBDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_GRUBListele));

        }
        private void BtnTBL_SIRKET_SINIFEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_SINIFEkle));

        }
        private void BtnTBL_SIRKET_SINIFDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_SINIFListele));

        }
        private void BtnTBL_SIRKET_TIPIEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_TIPIEkle));

        }
        private void BtnTBL_SIRKET_TIPIDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SIRKET_TIPIListele));

        }
        private void BtnTBL_SPARISEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SPARISEkle));

        }
        private void BtnTBL_SPARISDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SPARISListele));

        }
        private void BtnTBL_SPARIS_TURUEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SPARIS_TURUEkle));

        }
        private void BtnTBL_SPARIS_TURUDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_SPARIS_TURUListele));

        }
        private void BtnTBL_URUNEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUNEkle));

        }
        private void BtnTBL_URUNDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUNListele));

        }
        private void BtnTBL_URUN_BIRIMEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_BIRIMEkle));

        }
        private void BtnTBL_URUN_BIRIMDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_BIRIMListele));

        }
        private void BtnTBL_URUN_CINSIEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_CINSIEkle));

        }
        private void BtnTBL_URUN_CINSIDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_CINSIListele));

        }
        private void BtnTBL_URUN_MARKAEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_MARKAEkle));

        }
        private void BtnTBL_URUN_MARKADuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_MARKAListele));

        }
        private void BtnTBL_URUN_STOKEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_STOKEkle));

        }
        private void BtnTBL_URUN_STOKDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_STOKListele));

        }
        private void BtnTBL_URUN_TIPIEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_TIPIEkle));

        }
        private void BtnTBL_URUN_TIPIDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.TBL_URUN_TIPIListele));

        }

      
      
     
        private void BtnBankaAnaSAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BankaAnasayfa));
        }
        private void BtnDepoSayfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.DepoAnasayfa));

        }

        private void BtnFaturaSayfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.FaturaAnasayfa));
        }

        private void BtnFisAnaSAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.FisAnasayfa));
        }

        private void BtnGiderAnaSAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.GiderAnasayfa));
        }

        private void BtnKasaSayfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.KasaAnasayfa));
        }


        private void BtnOdemeaSAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.OdemeAnasayfa));
        }

        private void BtnParaTipiaSAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.ParaTipiAnasayfa));
        }

        private void BtnSiparisAyfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.SiparisAnasayfa));
        }

        private void BtnSirketSayfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.SirketAnasayfa));
        }

        private void BtnUrunSayfasi_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.UrunAnasayfa));
        }

        private void BtnAnaGoruntu_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.AnaGoruntu));
        }

        private void BtnBolumDepoIslem_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BolumDepoIslem));
        }

        private void BtnBolumDepoTransfer_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BolumDepoTransfer));
        }

        private void BtnBolumSiparisDuzenle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BolumSiparisDuzenle));
        }

        private void BtnBolumFaturaEkle_OnClick(object sender, RoutedEventArgs e)
        {
            Messenger.Default.Send(new BilgilendiriciMesaj(MesajDurumlari.BolumFaturaEkle));
        }
    }
}
