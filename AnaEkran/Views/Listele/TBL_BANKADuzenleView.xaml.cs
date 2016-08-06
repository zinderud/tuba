 
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
  using AnaEkran.Views.Raporlar.Banka;
  using ZindeMesajServisi.Messaging;

namespace AnaEkran.Views.Listele
{
    /// <summary>
    /// Interaction logic for TBL_BANKADuzenleView.xaml
    /// </summary>
    public partial class TBL_BANKADuzenleView : UserControl
    {
        public TBL_BANKADuzenleView()
        {
            InitializeComponent();
            Messenger.Default.Register<EkleTBL_BANKAMesaj>(this, OnEkleTBL_BANKAMesaj);

        }

        private void OnEkleTBL_BANKAMesaj(EkleTBL_BANKAMesaj obj)
        {
            if (this.DataContext != null)
            {
                var Metodlar = this.DataContext.GetType().GetMethod("Listele");
                Metodlar.Invoke(this.DataContext, null);

            }
            MessageBox.Show(obj.mesaj);
        }

        public TBL_BANKADuzenleView(double height)
        {
             InitializeComponent();
             Messenger.Default.Register<EkleTBL_BANKAMesaj>(this, OnEkleTBL_BANKAMesaj);

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
        {BankaEkleSayfasý sayfasý=new BankaEkleSayfasý();
            sayfasý.ShowDialog();
        }

        private void BttnRapor_OnClick(object sender, RoutedEventArgs e)
        {
         //BankaListeRaporSayfasi sayfasi=new BankaListeRaporSayfasi();
         //   sayfasi.ShowDialog();
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

