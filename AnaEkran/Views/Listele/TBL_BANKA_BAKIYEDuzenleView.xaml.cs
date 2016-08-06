 
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
  using AnaEkran.Views.AraSayfalar.Banka;
  using AnaEkran.Views.Baglantilar.Banka;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_BANKA_BAKIYEDuzenleView.xaml
    /// </summary>
    public partial class TBL_BANKA_BAKIYEDuzenleView : UserControl
    {
        public TBL_BANKA_BAKIYEDuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_BANKA_BAKIYEMesaj>(this, OnEkleTBL_BANKA_BAKIYEMesaj);

        }

        private void OnEkleTBL_BANKA_BAKIYEMesaj(EkleTBL_BANKA_BAKIYEMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_BANKA_BAKIYEDuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_BANKA_BAKIYEMesaj>(this, OnEkleTBL_BANKA_BAKIYEMesaj);

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
            BankaBakiyeEklemeSayfasi sayfasi = new BankaBakiyeEklemeSayfasi();
            sayfasi.ShowDialog();
        }

        private void BtnbankaparaButton_OnClick(object sender, RoutedEventArgs e)
        {
            BankaParaDurumuSayfasi sayfasi = new BankaParaDurumuSayfasi();
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

