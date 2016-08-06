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
using AnaEkran.Mesaj;
using AnaEkran.Models;
using AnaEkran.Views.AraSayfalar.Depo;
using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Bolumler.Depo
{
    /// <summary>
    /// Interaction logic for BolumDepoIslemView.xaml
    /// </summary>
    public partial class BolumDepoIslemView : UserControl
    {
        public BolumDepoIslemView()
        {
            InitializeComponent();
        }
        public BolumDepoIslemView(double height)
        {
             InitializeComponent();
            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
            Messenger.Default.Register<EkleTBL_DEPO_ISLEMMesaj>(this, OnEkleTBL_DEPO_ISLEMMesaj);

        }
        private void OnEkleTBL_DEPO_ISLEMMesaj(EkleTBL_DEPO_ISLEMMesaj obj)
        {



            TBL_URUN_STOK_MODEL model = new TBL_URUN_STOK_MODEL();
            if (obj.MesajTBL_DEPO_ISLEM != null)
            {

                model.TBL_DEPO_ID = obj.MesajTBL_DEPO_ISLEM.TBL_DEPO_ID;
                model.TBL_URUN_ID = obj.MesajTBL_DEPO_ISLEM.TBL_URUN_ID;
                model.URUN_BIRIM_MIKTARI = Convert.ToInt32(obj.MesajTBL_DEPO_ISLEM.URUN_MIKTAR);
                model.ACIKLAMA = "Depo İşlem Ekleme Kısmından  ekleme işlemi yapıldı ";
                //model. = obj.MesajTBL_DEPO_ISLEM.DEPO_ONAY;
                //model. = "HAYIR";


            }
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);
                var deposotkekle = this.DataContext.GetType().GetMethod("UrunStokEkle");
                deposotkekle.Invoke(this.DataContext, new object[] { model });


            }
            MessageBox.Show(obj.mesaj);
        }
        public void Connect(int connectionId, object target)
        {
             
        }
        private void BtnEklemeButton_OnClick(object sender, RoutedEventArgs e)
        {
            DepoIslemEkleSayfasi sayfasi = new DepoIslemEkleSayfasi();
            sayfasi.ShowDialog();
        }
    }
}
