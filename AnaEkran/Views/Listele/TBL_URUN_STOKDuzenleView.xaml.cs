 
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
  using AnaEkran.Views.AraSayfalar.Urun;
  using AnaEkran.Views.Baglantilar.Urun;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_URUN_STOKDuzenleView.xaml
    /// </summary>
    public partial class TBL_URUN_STOKDuzenleView : UserControl
    {
        public TBL_URUN_STOKDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_URUN_STOKMesaj>(this, OnEkleTBL_URUN_STOKMesaj);

        }

        private void OnEkleTBL_URUN_STOKMesaj(EkleTBL_URUN_STOKMesaj obj)
        {
            TBL_DEPO_ISLEM_MODEL model = new TBL_DEPO_ISLEM_MODEL();
            if (obj.MesajTBL_URUN_STOK != null)
            {
               
                model.TBL_DEPO_ID = obj.MesajTBL_URUN_STOK.TBL_DEPO_ID;
                model.TBL_URUN_ID = obj.MesajTBL_URUN_STOK.TBL_URUN_ID;
                model.URUN_MIKTAR = obj.MesajTBL_URUN_STOK.URUN_BIRIM_MIKTARI.ToString();
                model.ACIKLAMA = "Urun Stok Ekleme Kýsmýndan  ekleme iþlemi yapýldý ";
                model.DEPO_ISLEM_ADI = obj.MesajTBL_URUN_STOK.ACIKLAMA;
                model.DEPO_ONAY = "HAYIR";


            }
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);
                var deposotkekle = this.DataContext.GetType().GetMethod("DepoStokEkle");
                deposotkekle.Invoke(this.DataContext, new object[] { model });
               

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_URUN_STOKDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_URUN_STOKMesaj>(this, OnEkleTBL_URUN_STOKMesaj);

            var anim = new AnimationHelper();
            anim.UserControlDropDownAnim(this, height);
         }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
 
        }

        public void Connect(int connectionId, object target)
        {
        }
        private void BtnEklemeButton_OnClick(object sender, RoutedEventArgs e)
        {
            UrunStokEkleSayfasi sayfasi = new UrunStokEkleSayfasi();
            sayfasi.ShowDialog();
        }

        private void BtnUrunStokdepoButton_OnClick(object sender, RoutedEventArgs e)
        {
             UrunAdetListesiSayfasi sayfasi=new UrunAdetListesiSayfasi();
             sayfasi.Show();
        }
    }
}




	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

