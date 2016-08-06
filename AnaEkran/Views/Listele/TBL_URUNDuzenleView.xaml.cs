 
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
  using AnaEkran.Views.AraSayfalar.Urun;
  using AnaEkran.Views.Raporlar.Urun;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_URUNDuzenleView.xaml
    /// </summary>
    public partial class TBL_URUNDuzenleView : UserControl
    {
        public TBL_URUNDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_URUNMesaj>(this, OnEkleTBL_URUNMesaj);

        }

        private void OnEkleTBL_URUNMesaj(EkleTBL_URUNMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_URUNDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_URUNMesaj>(this, OnEkleTBL_URUNMesaj);

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
            UrunEkleSayfasi sayfasi = new UrunEkleSayfasi();
            sayfasi.ShowDialog();
        }

        private void BtnRapor_OnClick(object sender, RoutedEventArgs e)
        {

            UrunListeRaporSayfasi sayfasi = new UrunListeRaporSayfasi();
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

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////

	 
      ///////////////////////////////////////////////////



 

 ///////////////////////////////////////////////////

