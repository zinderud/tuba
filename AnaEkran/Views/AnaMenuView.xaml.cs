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
using AnaEkran.Views.AraSayfalar.Banka;
using AnaEkran.Views.AraSayfalar.Depo;
using AnaEkran.Views.AraSayfalar.Fatura;
using AnaEkran.Views.AraSayfalar.Fis;
using AnaEkran.Views.AraSayfalar.Gider;
using AnaEkran.Views.AraSayfalar.Kasa;
using AnaEkran.Views.AraSayfalar.Odeme;
using AnaEkran.Views.AraSayfalar.ParaTipi;
using AnaEkran.Views.AraSayfalar.Personel;
using AnaEkran.Views.AraSayfalar.Siparis;
using AnaEkran.Views.AraSayfalar.Sirket;
using AnaEkran.Views.AraSayfalar.Urun;
using AnaEkran.Views.Bolumler.Depo;
using AnaEkran.Views.Bolumler.Satis;
using AnaEkran.Views.Ekle;
using AnaEkran.Views.Goruntule;
using AnaEkran.Views.Listele;
 
using ZindeMesajServisi.Messaging;
using ZindeUI.Metro.Controls;
 
namespace AnaEkran.Views
{
    /// <summary>
    /// Interaction logic for AnaMenuView.xaml
    /// </summary>
    public partial class AnaMenuView : MetroWindow
    {
        public AnaMenuView()
        {
            Baslangic();
            InitializeComponent();
            Messenger.Default.Register<KullaniciGirisMesaj>(this, OnKullaniciGirisMesaj);
            Messenger.Default.Register<BilgilendiriciMesaj>(this, (message) => BilgilendiriciMesajHandler(message));

        }

        private void BilgilendiriciMesajHandler(BilgilendiriciMesaj message)
        {

            #region bolumler
            if (message.Bilgilendirici == MesajDurumlari.BolumFaturaEkle)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new BolumFaturaEkleView(DynamicBorder.ActualHeight);

            }
              if (message.Bilgilendirici == MesajDurumlari.BolumDepoIslem)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new BolumDepoIslemView(DynamicBorder.ActualHeight);

            }
              if (message.Bilgilendirici == MesajDurumlari.BolumDepoTransfer)
              {
                  if (GizliPanels[0].IsOpen)
                  {
                      GizliPanels[0].IsOpen = false;
                  }
                  DynamicBorder.Child = null;
                  DynamicBorder.Child = new BolumDepoTransferView(DynamicBorder.ActualHeight);

              }
              if (message.Bilgilendirici == MesajDurumlari.BolumSiparisDuzenle)
              {
                  if (GizliPanels[0].IsOpen)
                  {
                      GizliPanels[0].IsOpen = false;
                  }
                  DynamicBorder.Child = null;
                  DynamicBorder.Child = new BolumSiparisDuzenleView(DynamicBorder.ActualHeight);

              }
            #endregion
            //Eger Kullanıcı giriş yapmış ise şifre ekranı  kapansın ara menu acılsın
            if (message.Bilgilendirici == MesajDurumlari.BankaAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new BankaAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.DepoAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new DepoAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.FaturaAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new FaturaAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.FisAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new FisAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.GiderAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new GiderAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.KasaAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new KasaAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.OdemeAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new OdemeAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.ParaTipiAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new ParaTipiAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.PersonelAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new PersonelAnasayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.SiparisAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new SiparisAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.SirketAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new SirketAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.UrunAnasayfa)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new UrunAnaSayfaView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.AnaGoruntu)
            {
                if (GizliPanels[0].IsOpen)
                {
                    GizliPanels[0].IsOpen = false;
                }
                DynamicBorder.Child = null;
                DynamicBorder.Child = new AnaGoruntu(DynamicBorder.ActualHeight);

            }
           
           
           
           
          




            //if (message.Bilgilendirici == MesajDurumlari.BankaEkle)
            //{
            //    DynamicBorder.Child = null;
            //    DynamicBorder.Child = new BankaEkleView(DynamicBorder.ActualHeight);

            //}
            //if (message.Bilgilendirici == MesajDurumlari.BankaDuzenle)
            //{
            //    DynamicBorder.Child = null;
            //    DynamicBorder.Child = new BankaDuzenleView(DynamicBorder.ActualHeight);

            //}
            //if (message.Bilgilendirici == MesajDurumlari.BankaBakiyeEkle)
            //{
            //    DynamicBorder.Child = null;
            //    DynamicBorder.Child = new BankaBakiyeEkleView(DynamicBorder.ActualHeight);

            //}
            //if (message.Bilgilendirici == MesajDurumlari.BankaBakiyelistele)
            //{
            //    DynamicBorder.Child = null;
            //    DynamicBorder.Child = new BankaListeleView(DynamicBorder.ActualHeight);

            //}
            if (message.Bilgilendirici == MesajDurumlari.TBL_BANKAEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_BANKAEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_BANKAListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_BANKADuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_BANKA_BAKIYEEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_BANKA_BAKIYEEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_BANKA_BAKIYEListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_BANKA_BAKIYEDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPOEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPOEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPOListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPODuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPO_ISLEMEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPO_ISLEMEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPO_ISLEMListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPO_ISLEMDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPO_TRANSFEREkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPO_TRANSFEREkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_DEPO_TRANSFERListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_DEPO_TRANSFERDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_FATURAEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FATURAEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_FATURAListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FATURADuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_FATURA_TURUEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FATURA_TURUEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_FATURA_TURUListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FATURA_TURUDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_FISEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FISEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_FISListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_FISDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_GIDEREkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_GIDEREkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_GIDERListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_GIDERDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_GIDER_BAKIYEEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_GIDER_BAKIYEEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_GIDER_BAKIYEListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_GIDER_BAKIYEDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_KASAEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KASAEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_KASAListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KASADuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_KASA_BAKIYEEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KASA_BAKIYEEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_KASA_BAKIYEListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KASA_BAKIYEDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_KDVEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KDVEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_KDVListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_KDVDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEMEEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEMEEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEMEListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEMEDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEME_TIPIEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEME_TIPIEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEME_TIPIListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEME_TIPIDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEME_TURUEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEME_TURUEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_ODEME_TURUListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_ODEME_TURUDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_PARA_TIPIEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_PARA_TIPIEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_PARA_TIPIListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_PARA_TIPIDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_PERSONELEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_PERSONELEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_PERSONELListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_PERSONELDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKETEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKETEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKETListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKETDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_BAKIYEEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_BAKIYEEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_BAKIYEListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_BAKIYEDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_GRUBEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_GRUBEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_GRUBListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_GRUBDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_SINIFEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_SINIFEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_SINIFListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_SINIFDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_TIPIEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_TIPIEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SIRKET_TIPIListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SIRKET_TIPIDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SPARISEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SPARISEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SPARISListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SPARISDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_SPARIS_TURUEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SPARIS_TURUEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_SPARIS_TURUListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_SPARIS_TURUDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUNEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUNEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUNListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUNDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_BIRIMEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_BIRIMEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_BIRIMListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_BIRIMDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_CINSIEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_CINSIEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_CINSIListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_CINSIDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_MARKAEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_MARKAEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_MARKAListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_MARKADuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_STOKEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_STOKEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_STOKListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_STOKDuzenleView(DynamicBorder.ActualHeight);

            }



            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_TIPIEkle)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_TIPIEkleView(DynamicBorder.ActualHeight);

            }
            if (message.Bilgilendirici == MesajDurumlari.TBL_URUN_TIPIListele)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new TBL_URUN_TIPIDuzenleView(DynamicBorder.ActualHeight);

            }
         }




        private TBL_PERSONEL_MODEL tblPersonelModel;
        private void OnKullaniciGirisMesaj(KullaniciGirisMesaj obj)
        {
            if (obj.Mesaj=="Başarılı" )
            {
             tblPersonelModel=new TBL_PERSONEL_MODEL();
                tblPersonelModel = obj.MesajTblPersonel;
                Aramenulink(tblPersonelModel) ;
                TxtKullaniciAdi.Text = tblPersonelModel.PERSONEL_AD_SOYAD;
            }
        }

      
        public void Aramenulink(TBL_PERSONEL_MODEL model)
        {

            //GridOfButtons.Children.Clear();
            DynamicBorder.Child = null;
            DynamicBorder.Child = new AraMenuView(DynamicBorder.ActualHeight,model);

        }
        private AnimationHelper anim;
        private double mousex = -1;
        private double mousey = -1;

        private bool IsCollapsed = true;
        private bool CanChange = true;
        private string deger;
        private void Baslangic()
        {
            anim = new AnimationHelper();
            //if (btnKirli.IsEnabled == false) BorderKirli.Opacity = 0.3d;
            //if (BtnTemiz.IsEnabled == false) BorderTemiz.Opacity = 0.3d;
            //if (BtnDepo.IsEnabled == false) BorderDepo.Opacity = 0.3d;
            //if (BtnDestek.IsEnabled == false) BorderDestek.Opacity = 0.3d;
            //if (BtnYonetici.IsEnabled == false) BorderYonetici.Opacity = 0.3d;






            #region YanPanelMauseHareketi
            this.MouseDown += (sm, em) =>
            {
                mousex = Mouse.GetPosition(this).X;
                mousey = Mouse.GetPosition(this).Y;

                if (mousex <= 50 & mousey <= 950)
                {
                    GizliPanels[0].IsOpen = !GizliPanels[0].IsOpen;
                }
                if (mousex <= 1650 & mousey <= 50)
                {
                    //GizliPanels[1].IsOpen = !GizliPanels[1].IsOpen;
                }
            };

            this.MouseLeave += (sm, em) =>
            {
                if (!IsCollapsed)
                {
                    CanChange = true;
                }
            };

            //this.MouseDown += (sm, em) => { mousex = Mouse.GetPosition(this).Y; };

            //this.MouseLeave += (sm, em) => { if (!IsCollapsed) { CanChange = true; } };

            //this.MouseMove += (sm, em) =>
            //{
            //    if (em.LeftButton == MouseButtonState.Released)
            //    {
            //        CanChange = true;
            //    }
            //    else if (em.LeftButton == MouseButtonState.Pressed && CanChange)
            //    {
            //        if (Mouse.GetPosition(this).Y - mousex > 150)
            //        {
            //            //VisualStateManager.GoToElementState(this, "Collapsed", true);
            //            GizliPanels[0].IsOpen = !GizliPanels[0].IsOpen;
            //            IsCollapsed = true;
            //            CanChange = false;
            //        }
            //    }
            //};

            this.Loaded += (sl, el) =>
            {
                var frameworkElement = this.Parent as FrameworkElement;
                if (frameworkElement != null)
                    frameworkElement.MouseMove += (sm, em) =>
                    {

                        if (em.LeftButton == MouseButtonState.Pressed && CanChange && IsCollapsed &&
                            Mouse.GetPosition(this.Parent as IInputElement).Y > (this.Parent as Grid).ActualWidth - 200)
                        {

                            IsCollapsed = false;
                            GizliPanels[0].IsOpen = !GizliPanels[0].IsOpen;
                            //VisualStateManager.GoToElementState(this, "Normal", true);
                            CanChange = false;

                        }
                        else if (em.LeftButton == MouseButtonState.Released && IsCollapsed &&
                                 Mouse.GetPosition(this.Parent as IInputElement).Y > (this.Parent as Grid).ActualWidth - 200)
                        {
                            CanChange = true;
                        }

                    };
                //GizliPanels[0].IsOpen = !GizliPanels[0].IsOpen;
                //VisualStateManager.GoToElementState(this, "Collapsed", true);
            };
            #endregion




        }
   
        public void Connect(int connectionId, object target)
        {
        }

        
        private void AnaMenuView_OnLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtngirisButton_OnClick(object sender, RoutedEventArgs e)
        {
            tblPersonelModel = null;
            DynamicBorder.Child = null;
            KullaniciGirisView sifre = new KullaniciGirisView();
            DynamicBorder.Child = sifre;
            if (GizliPanels[0].IsOpen)
            {
                GizliPanels[0].IsOpen = false;
            }
        }

        private void BtnanaMenu_OnClick(object sender, RoutedEventArgs e)
        {
            if (GizliPanels[0].IsOpen)
            {
                GizliPanels[0].IsOpen = false;
            }
            if (tblPersonelModel!=null)
            {
                DynamicBorder.Child = null;
                DynamicBorder.Child = new AraMenuView(DynamicBorder.ActualHeight, tblPersonelModel);
            }
            else
            {
                
            }
           
        }

        private void BtnSanalKlavye_OnClick(object sender, RoutedEventArgs e)
        {
            SanalKlavyem.IsOpen = true;
            if (GizliPanels[0].IsOpen)
            {
                GizliPanels[0].IsOpen = false;
            }
        }

        private void BtnKapat_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnKullaniciIslemleri_OnClick(object sender, RoutedEventArgs e)
        {
            if (GizliPanels[0].IsOpen)
            {
                GizliPanels[0].IsOpen = false;
            }
            if (tblPersonelModel != null)
            {
                //DynamicBorder.Child = null;
                //DynamicBorder.Child = new PesonelSifreView(DynamicBorder.ActualHeight);
            }

        }
    }
}
