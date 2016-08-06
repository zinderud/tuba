 
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
  using AnaEkran.Views.AraSayfalar.Kasa;
  using AnaEkran.Views.Baglantilar.Kasa;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_KASA_BAKIYEDuzenleView.xaml
    /// </summary>
    public partial class TBL_KASA_BAKIYEDuzenleView : UserControl
    {
        public TBL_KASA_BAKIYEDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_KASA_BAKIYEMesaj>(this, OnEkleTBL_KASA_BAKIYEMesaj);

        }

        private void OnEkleTBL_KASA_BAKIYEMesaj(EkleTBL_KASA_BAKIYEMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_KASA_BAKIYEDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_KASA_BAKIYEMesaj>(this, OnEkleTBL_KASA_BAKIYEMesaj);

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
        {KasaBakiyeEkleSayfasi sayfasi=new KasaBakiyeEkleSayfasi();
            sayfasi.ShowDialog();
        }

        private void BtnKasaparaButton_OnClick(object sender, RoutedEventArgs e)
        {
            KasaParaDurumuSayfasi sayfasi = new KasaParaDurumuSayfasi();
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

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

